module Index

open System
open Elmish
open Fable.Core
open Fable.FontAwesome
open Fable.Remoting.Client
open Shared
open Fable.MomentJs
open Fable.React
open Fable.React.Props
open Fable.Recharts
open Fable.Recharts.Props
open Fulma

type ServerState = Idle | Loading | ServerError of string
let DropDownItems = [ "US" ; "NJ" ; "NY" ]
type Report =
    {
        USData : USData array option
        SelectedItem : string
    }

type Model =
    {
        Title : string
        Time : DateTime
        ServerState : ServerState
        Report : Report option
    }

type Msg =
    | GetCurrentUSCovid
    | GotCurrentUSCovid of Report
    | GetStateCovid
    | GotStateCovid of Report
    | ChangeDropDown of string
    | ErrorMsg of exn



let init () =
    {
        Title = "Current US Covid Numbers"
        Time = DateTime.Now
        ServerState = Idle
        Report = None
    }, Cmd.ofMsg (GetCurrentUSCovid)

let covidApi =
    Remoting.createApi()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.buildProxy<ICovidApi>

let getResponse loc = async{
    let! usData = covidApi.getHistoricalUSData loc
    return
        {
            USData = Some usData
            SelectedItem = loc
        }
}

let update msg model =
    match model, msg with
    | _, GetCurrentUSCovid ->
        {model with ServerState = Loading}, Cmd.OfAsync.either getResponse "US" GotCurrentUSCovid ErrorMsg
    | _, GotCurrentUSCovid response ->
        { model with Report = Some response ; ServerState = Idle }, Cmd.none
    | _, ChangeDropDown item ->
        {model with ServerState = Loading}, Cmd.OfAsync.either getResponse item GotCurrentUSCovid ErrorMsg
    | _, ErrorMsg e->
        { model with ServerState = ServerError e.Message }, Cmd.none

module ViewParts =
    let basicTile title option content =
        Tile.tile option [
            Notification.notification [ Notification.Props [ Style [ Height "100%" ; Width "100%" ] ] ] [
                Heading.h2 [] [str title]
                yield! content
            ]
        ]
    let graphTile model =
        basicTile model.Title [] [

        ]

let margin t r b l =
    Chart.Margin {top = t; bottom = b; right = r; left = l}

let private onMouseEvent data evt = // should have sig (data, activeIndex, event)
  JS.console.log("MOUSE:", data, evt)

let private onMouseEventIndexed data index evt = // should have sig (data, activeIndex, event)
  JS.console.log("MOUSE:", "Group " + string index, data, evt)

let format (x: float)  =
    printf "%A" x
    moment.unix(x).format("MMM Do")

let customizedAxisTick x y payload =
    text [ X x ; Y y ;  ] [ payload ]

let intersperse sep ls =
    List.foldBack (fun x -> function
        | [] -> [x]
        | xs -> x::sep::xs) ls []

let safeComponents =
    let components =
        [ "Saturn", "https://saturnframework.github.io/docs/"
          "Fable", "http://fable.io"
          "Elmish", "https://fable-elmish.github.io/"
          "Fulma", "https://fulma.github.io/Fulma/" ]
        |> List.map (fun (desc,link) -> a [ Href link ] [ str desc ] )
        |> intersperse (str ", ")
        |> span []

    p [] [
        strong [] [ a [ Href "https://safe-stack.github.io/" ] [ str "SAFE Template" ] ]
        str " powered by: "
        components
    ]

let basicTile title options content =
        Tile.tile options [
            Notification.notification [ Notification.Props [ Style [ Height "100%"; Width "100%" ] ] ] [
                Heading.h2 [] [ str title ]
                yield! content
            ]
        ]
type Line = {
    DataKey : string
    Color : string
}

let drawLine (lineToDraw : Line list) =
    let xAxis =
        [
            xaxis
          [ Cartesian.DataKey "unixDate"
            Cartesian.Type "number"
            Cartesian.Domain [| "auto" ; "auto" |]
            Cartesian.TickFormatter (fun x-> format x)
            //Cartesian.Interval 0
            //Cartesian.Tick customizedAxisTick
            Cartesian.Scale ScaleType.Time
            ]
          []
        ]
    let yAxis = [ yaxis [] [] ]
    let tooltip =[ tooltip [] [] ]
    let legend = [ legend [] [] ]

    lineToDraw
    |> List.map(fun y ->
        line [ Cartesian.Type Monotone ; Cartesian.DataKey y.DataKey ; Cartesian.Dot false ; Cartesian.Stroke y.Color] []
    )
    |> List.append yAxis
    |> List.append tooltip
    |> List.append legend

let drawChart (title : string) (lines : Line list) (chartData : USData array) =

    basicTile title [ Tile.Size Tile.Is12 ] [
        lineChart
            [ margin 5. 40. 5. 40.
              Chart.Width 1000.
              Chart.Height 500.
              Chart.Data chartData
              Chart.OnClick onMouseEvent ]

            (drawLine lines)
        ]

let populateDropDown items selectedItem (dispatch : Msg ->  unit) =
    items |> List.map(fun item ->
        if item = selectedItem then
            Dropdown.Item.a [ Dropdown.Item.IsActive true ] [ str item ]
        else Dropdown.Item.a [ Dropdown.Item.Props [ OnClick (fun _ -> dispatch (Msg.ChangeDropDown item))]] [ str item ]
    )

//End Helpers
let view (model : Model) (dispatch : Msg -> unit) =
    section [] [
        Hero.hero [ Hero.Color Color.IsInfo ] [
            Hero.body [ ] [
                Container.container [
                    Container.IsFluid
                    Container.Modifiers [ Modifier.TextAlignment (Screen.All, TextAlignment.Centered) ]
                ] [
                    Heading.h1 [] [
                        str "COVID-19 Tracker"
                    ]
                ]
            ]
        ]
        Container.container [] [
            Tile.ancestor [
                Tile.Size Tile.Is12
            ] [
                match model with
                | { Report = None ; ServerState = Idle | Loading } -> ()
                | { ServerState = ServerError error} -> str error
                | { Report = Some report } ->
                        Tile.parent[ Tile.Size Tile.Is12 ] [
                        let d = [ { Line.Color = "red" ; DataKey = "positive" } ; { Line.Color = "black" ; DataKey = "total" } ]
                        drawChart model.Title d (report.USData |> Option.get)
                        ]
                        Tile.parent [ ] [
                            Tile.child [  ] [
                                    Dropdown.dropdown [ Dropdown.IsHoverable ]
                                        [ Dropdown.trigger [ ]
                                            [ Button.button [ ]
                                                [ span [ ]
                                                    [ str "States" ]
                                                  Icon.icon [ Icon.Size IsSmall ]
                                                    [ Fa.i [ Fa.Solid.AngleDown ]
                                                        [ ] ] ] ]
                                          Dropdown.menu [ ]
                                            [ Dropdown.content [  ] (populateDropDown DropDownItems report.SelectedItem dispatch) ]
                                        ]
                            ]
                        ]
                | _ -> str "test"

            ]
        ]
        br []
        Footer.footer [] [
            Content.content [
                Content.Modifiers [ Fulma.Modifier.TextAlignment(Screen.All, TextAlignment.Centered) ]
            ] [ safeComponents ]
        ]
    ]