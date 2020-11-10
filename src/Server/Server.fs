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
    member __.GetCurrentUSData() =
        getCurrentCovidData
        |> Async.map USData.Create

let covidData = CovidData()
let covidApi =
    {
        getCurrentUSData = fun () -> covidData.GetCurrentUSData()
        //getCurrentStateData = fun () -> async.Return ()
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