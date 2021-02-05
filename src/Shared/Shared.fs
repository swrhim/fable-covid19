namespace Shared

open System
open Core

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

type USDataFull =
    {
        date : int
        dateTime : DateTime
        month : int
        unixDate : float
        death : int
        deathIncrease : int
        hospitalized : int
        hospitalizedCumulative : int
        hospitalizedCurrently : int
        hospitalizedIncrease : int
        negative : int
        pending : int
        positive : int
        total : int
        positiveIncrease : int
        recovered : int
        totalTestResults : int
        totalTestResultsIncreased : int
    }

type Location =
    | US
    | NJ
    | NY
    | MOON
with
    static member ToString loc =
        match loc with
        | US -> "US"
        | NJ -> "NJ"
        | NY -> "NY"
        | MOON -> "MOON"

    static member FromString loc =
        match loc with
        | "US" -> US
        | "NJ" -> NJ
        | "NY" -> NY
        | _ -> MOON

type USData =
    {
        date : int
        loc : Location
        dateTime : DateTime
        month : int
        unixDate : float
        death : int
        hospitalized : int
        negative : int
        pending : int
        positive : int
        total : int
        recovered : int
        totalTestResults : int
        groupingField : string
    }

 type StateData =
     {
         date : int
         state : string
         dateTime : DateTime
         month : int
         unixDate : float
         death : int
         hospitalized : int
         negative : int
         pending : int
         positive : int
         total : int
         recovered : int
         totalTestResults : int
     }

type ICovidApi =
    {
        getHistoricalUSData : Location -> Async<USData array>
    }