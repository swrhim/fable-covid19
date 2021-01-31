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
type USData =
    {
        date : int
        loc : string
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
        getHistoricalUSData : string -> Async<USData array>
    }