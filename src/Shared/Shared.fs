namespace Shared

open System
open Core

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

type USData =
    {
        date : DateTime
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

type ICovidApi =
    {
        getCurrentUSData : unit -> Async<USData>
        //getCurrentStateData : unit -> Async<StateData list>
    }