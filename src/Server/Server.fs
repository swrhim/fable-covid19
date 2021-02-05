module Server

open FSharp.Core
open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open Saturn


open Core
open DataAccess
open Shared
open Types

type CovidData () =
    member __.GetHistoricalUSData loc =
        let results =
            if(loc = Location.US) then
                getHistoricalCovidData
            else
                getHistoricalStateCovidData loc
        results |> Async.map(fun a ->
            a
            |> Array.map(fun c -> USData.Create c loc)
            |> Array.rev
            //|> Array.groupBy(fun x -> x.groupingField)
            (*|> Array.map(fun (k, v) ->
                let r =
                    v
                    |> Array.sortBy(fun y -> y.date)
                let sum = USData.SumUp(r)
                //take last item and fill in some data for grouping purposes
                let lastItem = v |> Array.last
                { sum with
                    date = lastItem.date
                    loc = lastItem.loc
                    unixDate = lastItem.unixDate
                    month = lastItem.month
                    groupingField = lastItem.groupingField
                }
            ) *)
        )

let covidData =
        CovidData()
let covidApi =
    {
        getHistoricalUSData = covidData.GetHistoricalUSData
    }

let webApp =
    Remoting.createApi()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.fromValue covidApi
    |> Remoting.buildHttpHandler

let app =
    application {
        url "http://0.0.0.0:8085"
        use_router webApp
        memory_cache
        use_static "public"
        use_gzip
    }

run app