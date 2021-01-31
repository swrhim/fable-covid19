module DataAccess

open System.Net.Http

[<AutoOpen>]
module CovidDataApi =
    let baseUrl = "https://api.covidtracking.com"
    let usFormat baseUrl apiUrl = sprintf "%s/v1/us/%s" baseUrl apiUrl
    let stateFormat baseUrl state apiUrl = sprintf "%s/v1/states/%s/%s" baseUrl state apiUrl
    let client = new HttpClient()
    let getHistoricalCovidData = async {
        let currentUrl = usFormat baseUrl "daily.json"
        let! response = client.GetAsync(currentUrl) |> Async.AwaitTask
        let x = response.Content.ReadAsStringAsync().Result
        return x |> USDataRaw.deserialize
    }

    let getHistoricalStateCovidData state = async{
        let currentUrl = stateFormat baseUrl state "daily.json"
        let! response = client.GetAsync(currentUrl) |> Async.AwaitTask
        let x = response.Content.ReadAsStringAsync().Result
        printf "GOING TO DESErIALIZE"
        let b = x |> USDataRaw.deserialize
        printf "YO I DID IT"
        return b
    }