module Test
let models: ChartModels = failwith "JS only"

type ChartModels =
    abstract lineChart: unit -> LineChart
    abstract scatterChart: unit -> ScatterChart