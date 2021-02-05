[<AutoOpen>]
module Types

open System
open System.Globalization
open Shared
open Core

type USDataRaw =
    {
        date : int
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
        totalTestResults : int option
        totalTestResultsIncrease : int option
    }
    with
        static member deserialize (json : string) : USDataRaw array =
            FsCodec.NewtonsoftJson.Serdes.Deserialize json
        static member serialize (x : USDataRaw) : string = FsCodec.NewtonsoftJson.Serdes.Serialize x

type USData with
    static member Zero = {
            USData.date = 0
            loc = MOON
            dateTime = DateTime.Now
            month = 0
            unixDate = 0.
            death = 0
            hospitalized = 0
            negative = 0
            pending = 0
            positive = 0
            total = 0
            recovered = 0
            totalTestResults = 0
            groupingField = ""
        }

    static member Create (x : USDataRaw) loc =
        let dt = DateTime.ParseExact(x.date.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None)
        let a =
            {
                USData.date = x.date
                loc = loc
                unixDate = (float)(((DateTimeOffset)dt).ToUnixTimeSeconds())
                dateTime = dt
                month = dt.Month
                groupingField = sprintf "%d-%d" dt.Month dt.Year
                death = x.death |> Option.getValueOr 0
                hospitalized = x.hospitalizedCumulative |> Option.getValueOr 0
                negative = x.negative |> Option.getValueOr 0
                pending = x.pending |> Option.getValueOr 0
                positive = x.positive |> Option.getValueOr 0
                total = 0
                recovered = x.recovered |> Option.getValueOr 0
                totalTestResults = x.totalTestResults |> Option.getValueOr 0
            }
        { a with total = a.pending + a.negative + a.positive }

    static member SumUp (x : USData []) : USData =
        let r : USData =
            x
            |> Array.fold(fun agg item ->
                {
                    agg with
                        death = agg.death + item.death
                        hospitalized = agg.hospitalized + item.hospitalized
                        negative = agg.negative + item.negative
                        pending = agg.pending + item.pending
                        positive = agg.positive + item.positive
                        total =  agg.total + item.total
                        recovered = agg.recovered + item.recovered
                        totalTestResults = agg.totalTestResults + item.totalTestResults
                }
            ) USData.Zero
        r