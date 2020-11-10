module Index

open D3
open Elmish
open Fable.Remoting.Client
open Shared
open System

type ServerState = Idle | Loading | ServerError of string

type Report =
    {
        USData : USData
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

let getResponse () = async{
    let! usData = covidApi.getCurrentUSData ()
    printf "********** %A *********" usData
    return
        {
            USData = usData
        }
}

open Fable.React
open Fable.React.Props
open Fulma

let update msg model =
    match model, msg with
    | _, GetCurrentUSCovid ->
        {model with ServerState = Loading}, Cmd.OfAsync.either getResponse () GotCurrentUSCovid ErrorMsg
    | _, GotCurrentUSCovid response ->
        { model with Report = Some response ; ServerState = Idle }, Cmd.none
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

//Start Helpers
let nv = Nv.nv
let d3 = D3.d3

type DataPoints = {
    x : int
    y : int
}

type Feed = {
    values : DataPoints list
    key : string
    colors : string
}

type MM (l: float option, r: float option, t : float option, b : float option) =
    interface Nv.Nv.Margin with
        member val left = l with get, set
        member val right = r with get, set
        member val top = t with get, set
        member val bottom = b with get, set
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
            match model with
            | { Report = None ; ServerState = Idle | Loading} -> ()
            | {ServerState = ServerError error} ->
                Field.div [][
                    Tag.list [ Tag.List.HasAddons ; Tag.List.IsCentered ] [
                        Tag.tag [ Tag.Color Color.IsDanger ; Tag.Size IsMedium ] [
                            str error
                        ]
                    ]
                ]
            | {Report = Some report} ->
                let chart = nv.models.lineChart ()
                str "SOMETHING"

            (*
            | { Report = Some report } ->
                Tile.ancestor[
                    Tile.Size Tile.Is12
                ] [
                    Tile.parent [ Tile.Size Tile.Is12 ] [

                    ]
                ]*)
        ]
    ]