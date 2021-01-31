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
            if(loc = "US") then
                getHistoricalCovidData
            else
                getHistoricalStateCovidData loc
        results |> Async.map(fun a ->
            a
            |> Array.map(fun c -> USData.Create c loc)
            |> Array.rev
            |> Array.groupBy(fun x -> x.month)
            |> Array.map(fun (_, v) ->
                 let r =
                     v
                     |> Array.sortBy(fun y -> y.date)
                 Array.get r (v.Length-1)
            )
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