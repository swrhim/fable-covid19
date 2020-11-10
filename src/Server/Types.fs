[<AutoOpen>]
module Types

open System
open System.Globalization
open Shared
open Core

type USDataRaw =
    {
        date : int
        dateChecked : string
        death : int option
        deathIncrease : int option
        hash : string
        hospitalized : int option
        hospitalizedCumulative : int option
        hospitalizedCurrently : int option
        hospitalizedIncrease : int option
        inIcuCumulative : int option
        inIcuCurrently : int option
        negative : int option
        negativeIncrease : int option
        onVentilatorCumulative : int option
        onVentilatorCurrently : int option
        pending : int option
        positive : int option
        positiveIncrease : int option
        recovered : int option
        states : int option
        totalTestResults : int option
        totalTestResultsIncrease : int option
    }
    with
        static member deserialize (json : string) : USDataRaw =
            let raw : USDataRaw array = FsCodec.NewtonsoftJson.Serdes.Deserialize json
            raw.[0]
        static member serialize (x : USDataRaw) : string = FsCodec.NewtonsoftJson.Serdes.Serialize x


type USData with
    static member Create (x : USDataRaw) =
        let dt = DateTime.ParseExact(x.date.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None)
        let a =
            {
                USData.date = dt
                death = x.death |> Option.getValueOr 0
                deathIncrease = x.deathIncrease |> Option.getValueOr 0
                hospitalized = x.hospitalized |> Option.getValueOr 0
                hospitalizedCumulative = x.hospitalizedCumulative |> Option.getValueOr 0
                hospitalizedCurrently = x.hospitalizedCurrently |> Option.getValueOr 0
                hospitalizedIncrease = x.hospitalizedIncrease |> Option.getValueOr 0
                negative = x.negative |> Option.getValueOr 0
                pending = x.pending |> Option.getValueOr 0
                positive = x.positive |> Option.getValueOr 0
                total = 0
                positiveIncrease = x.positiveIncrease |> Option.getValueOr 0
                recovered = x.recovered |> Option.getValueOr 0
                totalTestResults = x.totalTestResults |> Option.getValueOr 0
                totalTestResultsIncreased = x.totalTestResultsIncrease |> Option.getValueOr 0
            }
        { a with total = a.pending + a.negative + a.positive }