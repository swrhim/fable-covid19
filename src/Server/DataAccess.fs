module DataAccess

open System.Net.Http

[<AutoOpen>]
module CovidDataApi =
    let baseUrl = "https://api.covidtracking.com"
    let format baseUrl apiUrl = sprintf "%s/v1/us/%s" baseUrl apiUrl
    let client = new HttpClient()
    let getHistoricalCovidData = async {
        let currentUrl = format baseUrl "daily.json"
        let! response = client.GetAsync(currentUrl) |> Async.AwaitTask
        let x = response.Content.ReadAsStringAsync().Result
        return x |> USDataRaw.deserialize
    }