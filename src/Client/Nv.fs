// ts2fable 0.8.0
module rec Nv
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open D3

type Array<'T> = System.Collections.Generic.IList<'T>

let [<Import("nv","module")>] nv: Nv.Nvd3Static = jsNative

module Nv =

    type [<AllowNullLiteral>] Margin =
        abstract left: float option with get, set
        abstract right: float option with get, set
        abstract top: float option with get, set
        abstract bottom: float option with get, set

    type [<AllowNullLiteral>] Size =
        abstract height: float with get, set
        abstract width: float with get, set

    type [<AllowNullLiteral>] ArcsRadius =
        abstract inner: float with get, set
        abstract outer: float with get, set

    type [<AllowNullLiteral>] Offset =
        abstract left: float option with get, set
        abstract top: float option with get, set

    type [<AllowNullLiteral>] State =
        abstract dispatch: D3.Dispatch with get, set

    type [<AllowNullLiteral>] InteractiveLayer =
        abstract tooltip: Tooltip with get, set

    type [<AllowNullLiteral>] SymbolMap =
        abstract set: name: string * func: (obj option -> unit) -> unit

    type [<AllowNullLiteral>] Utils =
        abstract defaultColor: unit -> ResizeArray<string>
        abstract getColor: arg: obj option -> ResizeArray<string>
        abstract windowResize: listener: (Event -> obj option) -> unit
        abstract windowSize: unit -> Size
        abstract state: unit -> State
        abstract symbolMap: SymbolMap with get, set

    type [<AllowNullLiteral>] ChartFactory<'TChart when 'TChart :> Nvd3Element> =
        abstract generate: (unit -> 'TChart) with get, set
        abstract callback: ('TChart -> unit) option with get, set

    type [<AllowNullLiteral>] Nvd3TooltipStatic =
        abstract show: leftTop: float * float * content: string * ?gravity: string -> unit
        abstract cleanup: unit -> unit

    type [<AllowNullLiteral>] Nvd3Element =
        abstract dispatch: D3.Dispatch with get, set
        abstract options: options: obj option -> Nvd3Element
        abstract update: unit -> unit
        [<Emit "$0($1...)">] abstract Invoke: transition: D3.Transition<ResizeArray<obj option>> * [<ParamArray>] args: ResizeArray<obj option> -> obj option
        [<Emit "$0($1...)">] abstract Invoke: selection: D3.Selection<ResizeArray<obj option>> * [<ParamArray>] args: ResizeArray<obj option> -> obj option
        [<Emit "$0($1...)">] abstract Invoke: transition: D3.Transition<obj option> * [<ParamArray>] args: ResizeArray<obj option> -> obj option
        [<Emit "$0($1...)">] abstract Invoke: selection: D3.Selection<obj option> * [<ParamArray>] args: ResizeArray<obj option> -> obj option

    type [<AllowNullLiteral>] Chart =
        inherit Nvd3Element
        abstract state: State with get, set
        abstract interactiveLayer: InteractiveLayer with get, set

    type [<AllowNullLiteral>] Legend =
        inherit Nvd3Element
        abstract align: unit -> bool
        abstract align: value: bool -> Legend
        abstract color: value: ResizeArray<string> -> Legend
        abstract color: func: (obj option -> float -> string) -> Legend
        abstract expanded: unit -> bool
        abstract expanded: value: bool -> Legend
        abstract height: unit -> float
        abstract height: value: float -> Legend
        abstract key: unit -> obj option
        abstract key: value: obj option -> Legend
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> Legend
        abstract padding: unit -> float
        abstract padding: value: float -> Legend
        abstract radioButtonMode: unit -> bool
        abstract radioButtonMode: value: bool -> Legend
        abstract rightAlign: unit -> bool
        abstract rightAlign: value: bool -> Legend
        abstract updateState: unit -> bool
        abstract updateState: value: bool -> Legend
        abstract vers: unit -> string
        abstract vers: value: string -> Legend
        abstract width: unit -> float
        abstract width: value: float -> Legend

    type [<AllowNullLiteral>] Focus =
        inherit Nvd3Element
        abstract color: value: ResizeArray<string> -> Focus
        abstract color: func: (obj option -> float -> string) -> Focus
        abstract width: unit -> float
        abstract width: value: float -> Focus
        abstract height: unit -> float
        abstract height: value: float -> Focus
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> Focus
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> Focus
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> Focus
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> Focus
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> Focus
        abstract brushExtent: unit -> U2<float * float, float * float * float * float>
        abstract brushExtent: value: U2<float * float, float * float * float * float> -> Focus
        abstract duration: unit -> float
        abstract duration: value: float -> Focus
        abstract xTickFormat: unit -> (obj option -> string)
        abstract xTickFormat: format: (obj option -> string) -> Focus
        abstract xTickFormat: format: string -> Focus
        abstract xTickFormat: format: (obj option -> obj option -> string) -> Focus
        abstract yTickFormat: unit -> (obj option -> string)
        abstract yTickFormat: format: (obj option -> string) -> Focus
        abstract yTickFormat: format: string -> Focus
        abstract yTickFormat: format: (obj option -> obj option -> string) -> Focus
        abstract interpolate: unit -> string
        abstract interpolate: value: string -> Focus
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> Focus
        abstract syncBrushing: unit -> bool
        abstract syncBrushing: value: bool -> Focus

    type [<AllowNullLiteral>] Nvd3Axis =
        inherit D3.Svg.Axis
        abstract axisLabel: unit -> string
        abstract axisLabel: value: string -> Nvd3Axis
        abstract axisLabelDistance: unit -> float
        abstract axisLabelDistance: value: float -> Nvd3Axis
        abstract domain: unit -> ResizeArray<float>
        abstract domain: domain: ResizeArray<float> -> Nvd3Axis
        abstract duration: unit -> float
        abstract duration: value: float -> Nvd3Axis
        abstract height: unit -> float
        abstract height: value: float -> Nvd3Axis
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> Nvd3Axis
        abstract orient: unit -> string
        abstract orient: orientation: string -> Nvd3Axis
        abstract range: unit -> ResizeArray<float>
        abstract range: range: ResizeArray<float> -> Nvd3Axis
        abstract rangeBand: unit -> float
        abstract rangeBands: interval: float * float * ?padding: float * ?outerPadding: float -> Nvd3Axis
        abstract rotateLabels: unit -> float
        abstract rotateLabels: range: float -> Nvd3Axis
        abstract rotateYLabels: unit -> float
        abstract rotateYLabels: range: float -> Nvd3Axis
        abstract scale: unit -> obj option
        abstract scale: scale: obj option -> Nvd3Axis
        abstract showMaxMin: value: bool -> Nvd3Axis
        abstract staggerLabels: unit -> bool
        abstract staggerLabels: value: bool -> Nvd3Axis
        abstract tickFormat: unit -> (obj option -> string)
        abstract tickFormat: format: (obj option -> string) -> Nvd3Axis
        abstract tickFormat: format: string -> Nvd3Axis
        abstract tickFormat: format: (obj option -> obj option -> string) -> Nvd3Axis
        abstract tickPadding: unit -> float
        abstract tickPadding: padding: float -> Nvd3Axis
        abstract tickSize: unit -> float
        abstract tickSize: size: float -> Nvd3Axis
        abstract tickSize: inner: float * outer: float -> Nvd3Axis
        abstract tickValues: unit -> ResizeArray<obj option>
        abstract tickValues: values: ResizeArray<obj option> -> Nvd3Axis
        abstract ticks: unit -> ResizeArray<obj option>
        abstract ticks: [<ParamArray>] args: ResizeArray<obj option> -> Nvd3Axis
        abstract width: unit -> float
        abstract width: value: float -> Nvd3Axis

    type [<AllowNullLiteral>] BoxPlot =
        inherit Nvd3Element
        abstract color: value: ResizeArray<string> -> BoxPlot
        abstract color: func: (obj option -> float -> string) -> BoxPlot
        abstract duration: unit -> float
        abstract duration: value: float -> BoxPlot
        abstract height: unit -> float
        abstract height: value: float -> BoxPlot
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> BoxPlot
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> BoxPlot
        abstract maxBoxWidth: unit -> float
        abstract maxBoxWidth: value: float -> BoxPlot
        abstract width: unit -> float
        abstract width: value: float -> BoxPlot
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> BoxPlot
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> BoxPlot
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> BoxPlot
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> BoxPlot
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> BoxPlot
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> BoxPlot
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> BoxPlot
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> BoxPlot

    type [<AllowNullLiteral>] Bullet =
        inherit Nvd3Element
        abstract color: value: ResizeArray<string> -> Bullet
        abstract color: func: (obj option -> float -> string) -> Bullet
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> Bullet
        abstract height: unit -> float
        abstract height: value: float -> Bullet
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> Bullet
        abstract markers: unit -> (obj option -> obj option)
        abstract markers: func: (obj option -> obj option) -> Bullet
        abstract measures: unit -> (obj option -> obj option)
        abstract measures: func: (obj option -> obj option) -> Bullet
        abstract orient: unit -> string
        abstract orient: orientation: string -> Bullet
        abstract ranges: unit -> (obj option -> obj option)
        abstract ranges: func: (obj option -> obj option) -> Bullet
        abstract tickFormat: unit -> (obj option -> string)
        abstract tickFormat: format: (obj option -> string) -> Bullet
        abstract tickFormat: format: string -> Bullet
        abstract tickFormat: format: (obj option -> obj option -> string) -> Bullet
        abstract width: unit -> float
        abstract width: value: float -> Bullet

    type [<AllowNullLiteral>] CandlestickBar =
        inherit Nvd3Element
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> CandlestickBar
        abstract close: unit -> (obj option -> float)
        abstract close: func: (obj option -> float) -> CandlestickBar
        abstract color: value: ResizeArray<string> -> CandlestickBar
        abstract color: func: (obj option -> float -> string) -> CandlestickBar
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> CandlestickBar
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> CandlestickBar
        abstract height: unit -> float
        abstract height: value: float -> CandlestickBar
        abstract high: unit -> (obj option -> float)
        abstract high: func: (obj option -> float) -> CandlestickBar
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> CandlestickBar
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> CandlestickBar
        abstract low: unit -> (obj option -> float)
        abstract low: func: (obj option -> float) -> CandlestickBar
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> CandlestickBar
        abstract ``open``: unit -> (obj option -> float)
        abstract ``open``: func: (obj option -> float) -> CandlestickBar
        abstract padData: unit -> bool
        abstract padData: value: bool -> CandlestickBar
        abstract width: unit -> float
        abstract width: value: float -> CandlestickBar
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> CandlestickBar
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> CandlestickBar
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> CandlestickBar
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> CandlestickBar
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> CandlestickBar
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> CandlestickBar
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> CandlestickBar
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> CandlestickBar

    type [<AllowNullLiteral>] DiscreteBar =
        inherit Nvd3Element
        abstract color: value: ResizeArray<string> -> DiscreteBar
        abstract color: func: (obj option -> float -> string) -> DiscreteBar
        abstract duration: unit -> float
        abstract duration: value: float -> DiscreteBar
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> DiscreteBar
        abstract height: unit -> float
        abstract height: value: float -> DiscreteBar
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> DiscreteBar
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> DiscreteBar
        abstract rectClass: unit -> string
        abstract rectClass: value: string -> DiscreteBar
        abstract showValues: unit -> bool
        abstract showValues: value: bool -> DiscreteBar
        abstract valueFormat: unit -> string
        abstract valueFormat: value: string -> DiscreteBar
        abstract width: unit -> float
        abstract width: value: float -> DiscreteBar
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> DiscreteBar
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> DiscreteBar
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> DiscreteBar
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> DiscreteBar
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> DiscreteBar
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> DiscreteBar
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> DiscreteBar
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> DiscreteBar

    type [<AllowNullLiteral>] Distribution =
        inherit Nvd3Element
        abstract axis: unit -> string
        [<Emit "$0.axis('x')">] abstract axis_x: unit -> Distribution
        [<Emit "$0.axis('y')">] abstract axis_y: unit -> Distribution
        abstract axis: value: string -> Distribution
        abstract color: value: ResizeArray<string> -> Distribution
        abstract color: func: (obj option -> float -> string) -> Distribution
        abstract domain: unit -> ResizeArray<float>
        abstract domain: value: ResizeArray<float> -> Distribution
        abstract duration: unit -> float
        abstract duration: value: float -> Distribution
        abstract getData: func: (obj option -> float) -> Distribution
        abstract scale: unit -> obj option
        abstract scale: value: obj option -> Distribution
        abstract size: unit -> float
        abstract size: value: float -> Distribution
        abstract width: unit -> float
        abstract width: value: float -> Distribution

    type [<AllowNullLiteral>] HistoricalBar =
        inherit Nvd3Element
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> HistoricalBar
        abstract color: value: ResizeArray<string> -> HistoricalBar
        abstract color: func: (obj option -> float -> string) -> HistoricalBar
        abstract duration: unit -> float
        abstract duration: value: float -> HistoricalBar
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> HistoricalBar
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> HistoricalBar
        abstract height: unit -> float
        abstract height: value: float -> HistoricalBar
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> HistoricalBar
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> HistoricalBar
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> HistoricalBar
        abstract padData: unit -> bool
        abstract padData: value: bool -> HistoricalBar
        abstract width: unit -> float
        abstract width: value: float -> HistoricalBar
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> HistoricalBar
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> HistoricalBar
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> HistoricalBar
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> HistoricalBar
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> HistoricalBar
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> HistoricalBar
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> HistoricalBar
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> HistoricalBar

    type [<AllowNullLiteral>] Line =
        inherit Scatter
        abstract scatter: Scatter with get, set
        abstract defined: unit -> (obj option -> float -> bool)
        abstract defined: func: (obj option -> float -> bool) -> Line
        abstract interpolate: unit -> string
        abstract interpolate: value: string -> Line
        abstract isArea: unit -> (obj option -> bool)
        abstract isArea: value: bool -> Line
        abstract isArea: func: (obj option -> bool) -> Line

    type [<AllowNullLiteral>] MultiBar =
        inherit Nvd3Element
        abstract barColor: value: ResizeArray<string> -> MultiBar
        abstract barColor: func: (obj option -> float -> string) -> MultiBar
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> MultiBar
        abstract color: value: ResizeArray<string> -> MultiBar
        abstract color: func: (obj option -> float -> string) -> MultiBar
        abstract disabled: unit -> ResizeArray<bool>
        abstract disabled: value: ResizeArray<bool> -> MultiBar
        abstract duration: unit -> float
        abstract duration: value: float -> MultiBar
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> MultiBar
        abstract groupSpacing: unit -> float
        abstract groupSpacing: value: float -> MultiBar
        abstract height: unit -> float
        abstract height: value: float -> MultiBar
        abstract hideable: unit -> bool
        abstract hideable: value: bool -> MultiBar
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> MultiBar
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> MultiBar
        abstract stacked: unit -> bool
        abstract stacked: value: bool -> MultiBar
        [<Emit "$0.stackOffset('silhouette')">] abstract stackOffset_silhouette: unit -> MultiBar
        [<Emit "$0.stackOffset('wiggle')">] abstract stackOffset_wiggle: unit -> MultiBar
        [<Emit "$0.stackOffset('expand')">] abstract stackOffset_expand: unit -> MultiBar
        [<Emit "$0.stackOffset('zero')">] abstract stackOffset_zero: unit -> MultiBar
        abstract stackOffset: offset: string -> MultiBar
        abstract stackOffset: offset: (Array<float * float> -> ResizeArray<float>) -> MultiBar
        abstract width: unit -> float
        abstract width: value: float -> MultiBar
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> MultiBar
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> MultiBar
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> MultiBar
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> MultiBar
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> MultiBar
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> MultiBar
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> MultiBar
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> MultiBar

    type [<AllowNullLiteral>] MultiBarHorizontal =
        inherit Nvd3Element
        abstract barColor: value: ResizeArray<string> -> MultiBarHorizontal
        abstract barColor: func: (obj option -> float -> string) -> MultiBarHorizontal
        abstract color: value: ResizeArray<string> -> MultiBarHorizontal
        abstract color: func: (obj option -> float -> string) -> MultiBarHorizontal
        abstract disabled: unit -> ResizeArray<bool>
        abstract disabled: value: ResizeArray<bool> -> MultiBarHorizontal
        abstract duration: unit -> float
        abstract duration: value: float -> MultiBarHorizontal
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> MultiBarHorizontal
        abstract groupSpacing: unit -> float
        abstract groupSpacing: value: float -> MultiBarHorizontal
        abstract height: unit -> float
        abstract height: value: float -> MultiBarHorizontal
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> MultiBarHorizontal
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> MultiBarHorizontal
        abstract showValues: unit -> bool
        abstract showValues: value: bool -> MultiBarHorizontal
        abstract stacked: unit -> bool
        abstract stacked: value: bool -> MultiBarHorizontal
        [<Emit "$0.stackOffset('silhouette')">] abstract stackOffset_silhouette: unit -> MultiBarHorizontal
        [<Emit "$0.stackOffset('wiggle')">] abstract stackOffset_wiggle: unit -> MultiBarHorizontal
        [<Emit "$0.stackOffset('expand')">] abstract stackOffset_expand: unit -> MultiBarHorizontal
        [<Emit "$0.stackOffset('zero')">] abstract stackOffset_zero: unit -> MultiBarHorizontal
        abstract stackOffset: offset: string -> MultiBarHorizontal
        abstract stackOffset: offset: (Array<float * float> -> ResizeArray<float>) -> MultiBarHorizontal
        abstract valueFormat: unit -> string
        abstract valueFormat: value: string -> MultiBarHorizontal
        abstract valuePadding: unit -> float
        abstract valuePadding: value: float -> MultiBarHorizontal
        abstract width: unit -> float
        abstract width: value: float -> MultiBarHorizontal
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> MultiBarHorizontal
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> MultiBarHorizontal
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> MultiBarHorizontal
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> MultiBarHorizontal
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> MultiBarHorizontal
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> MultiBarHorizontal
        abstract yErr: unit -> (obj option -> float -> U2<float, ResizeArray<float>>)
        abstract yErr: func: (obj option -> float -> U2<float, ResizeArray<float>>) -> MultiBarHorizontal
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> MultiBarHorizontal
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> MultiBarHorizontal

    type [<AllowNullLiteral>] OhlcBar =
        inherit Nvd3Element
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> OhlcBar
        abstract close: unit -> (obj option -> float)
        abstract close: func: (obj option -> float) -> OhlcBar
        abstract color: value: ResizeArray<string> -> OhlcBar
        abstract color: func: (obj option -> float -> string) -> OhlcBar
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> OhlcBar
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> OhlcBar
        abstract height: unit -> float
        abstract height: value: float -> OhlcBar
        abstract high: unit -> (obj option -> float)
        abstract high: func: (obj option -> float) -> OhlcBar
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> OhlcBar
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> OhlcBar
        abstract low: unit -> (obj option -> float)
        abstract low: func: (obj option -> float) -> OhlcBar
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> OhlcBar
        abstract ``open``: unit -> (obj option -> float)
        abstract ``open``: func: (obj option -> float) -> OhlcBar
        abstract padData: unit -> bool
        abstract padData: value: bool -> OhlcBar
        abstract width: unit -> float
        abstract width: value: float -> OhlcBar
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> OhlcBar
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> OhlcBar
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> OhlcBar
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> OhlcBar
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> OhlcBar
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> OhlcBar
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> OhlcBar
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> OhlcBar

    type [<AllowNullLiteral>] ParallelCoordinates =
        inherit Nvd3Element
        abstract color: value: ResizeArray<string> -> ParallelCoordinates
        abstract color: func: (obj option -> float -> string) -> ParallelCoordinates
        abstract dimensionData: unit -> obj option
        abstract dimensionData: d: obj option -> ParallelCoordinates
        abstract dimensionFormats: unit -> ResizeArray<string>
        abstract dimensionFormats: value: ResizeArray<string> -> ParallelCoordinates
        abstract dimensionNames: unit -> ResizeArray<string>
        abstract dimensionNames: value: ResizeArray<string> -> ParallelCoordinates
        abstract dimensions: unit -> obj option
        abstract dimensions: value: obj option -> ParallelCoordinates
        abstract height: unit -> float
        abstract height: value: float -> ParallelCoordinates
        abstract lineTension: unit -> float
        abstract lineTension: value: float -> ParallelCoordinates
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> ParallelCoordinates
        abstract width: unit -> float
        abstract width: value: float -> ParallelCoordinates

    type [<AllowNullLiteral>] Pie =
        inherit Nvd3Element
        abstract arcsRadius: unit -> ResizeArray<ArcsRadius>
        abstract arcsRadius: value: ResizeArray<ArcsRadius> -> Pie
        abstract color: value: ResizeArray<string> -> Pie
        abstract color: func: (obj option -> float -> string) -> Pie
        abstract cornerRadius: unit -> float
        abstract cornerRadius: value: float -> Pie
        abstract donut: unit -> bool
        abstract donut: value: bool -> Pie
        abstract donutLabelsOutside: unit -> bool
        abstract donutLabelsOutside: value: bool -> Pie
        abstract donutRatio: unit -> float
        abstract donutRatio: value: float -> Pie
        abstract endAngle: unit -> (obj option -> float)
        abstract endAngle: func: (obj option -> float) -> Pie
        abstract growOnHover: unit -> bool
        abstract growOnHover: value: bool -> Pie
        abstract height: unit -> float
        abstract height: value: float -> Pie
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> Pie
        abstract labelFormat: unit -> string
        abstract labelFormat: value: string -> Pie
        abstract labelFormat: format: (obj option -> string) -> Pie
        abstract labelSunbeamLayout: unit -> bool
        abstract labelSunbeamLayout: value: bool -> Pie
        abstract labelThreshold: unit -> float
        abstract labelThreshold: value: float -> Pie
        abstract labelType: unit -> string
        [<Emit "$0.labelType('key')">] abstract labelType_key: unit -> Pie
        [<Emit "$0.labelType('value')">] abstract labelType_value: unit -> Pie
        [<Emit "$0.labelType('percent')">] abstract labelType_percent: unit -> Pie
        abstract labelType: value: string -> Pie
        abstract labelType: func: (obj option -> float -> obj option -> string) -> Pie
        abstract labelsOutside: unit -> bool
        abstract labelsOutside: value: bool -> Pie
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> Pie
        abstract padAngle: unit -> float
        abstract padAngle: value: float -> Pie
        abstract pieLabelsOutside: unit -> bool
        abstract pieLabelsOutside: value: bool -> Pie
        abstract showLabels: unit -> bool
        abstract showLabels: value: bool -> Pie
        abstract startAngle: unit -> (obj option -> float)
        abstract startAngle: func: (obj option -> float) -> Pie
        abstract title: unit -> string
        abstract title: value: string -> Pie
        abstract titleOffset: unit -> float
        abstract titleOffset: value: float -> Pie
        abstract valueFormat: unit -> string
        abstract valueFormat: value: string -> Pie
        abstract valueFormat: format: (obj option -> string) -> Pie
        abstract width: unit -> float
        abstract width: value: float -> Pie
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> Pie
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> Pie

    type [<AllowNullLiteral>] Scatter =
        inherit Nvd3Element
        abstract clearHighlights: unit -> Scatter
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> Scatter
        abstract clipRadius: func: (obj option -> float) -> Scatter
        abstract clipRadius: value: float -> Scatter
        abstract clipVoronoi: unit -> bool
        abstract clipVoronoi: value: bool -> Scatter
        abstract color: value: ResizeArray<string> -> Scatter
        abstract color: func: (obj option -> float -> string) -> Scatter
        abstract duration: unit -> float
        abstract duration: value: float -> Scatter
        abstract forcePoint: unit -> ResizeArray<float>
        abstract forcePoint: value: ResizeArray<float> -> Scatter
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> Scatter
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> Scatter
        abstract height: unit -> float
        abstract height: value: float -> Scatter
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> Scatter
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> Scatter
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> Scatter
        abstract padData: unit -> bool
        abstract padData: value: bool -> Scatter
        abstract padDataOuter: unit -> float
        abstract padDataOuter: value: float -> Scatter
        abstract pointActive: unit -> (obj option -> bool)
        abstract pointActive: func: (obj option -> bool) -> Scatter
        abstract pointxDomain: unit -> ResizeArray<float>
        abstract pointDomain: value: ResizeArray<float> -> Scatter
        abstract pointRange: unit -> ResizeArray<float>
        abstract pointRange: value: ResizeArray<float> -> Scatter
        abstract pointScale: unit -> obj option
        abstract pointScale: value: obj option -> Scatter
        abstract pointSize: unit -> (obj option -> float)
        abstract pointSize: func: (obj option -> float) -> Scatter
        abstract pointSize: value: float -> Scatter
        abstract showVoronoi: unit -> bool
        abstract showVoronoi: value: bool -> Scatter
        abstract useVoronoi: unit -> bool
        abstract useVoronoi: value: bool -> Scatter
        abstract width: unit -> float
        abstract width: value: float -> Scatter
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> Scatter
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> Scatter
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> Scatter
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> Scatter
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> Scatter
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> Scatter
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> Scatter
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> Scatter

    type [<AllowNullLiteral>] SparkLine =
        inherit Nvd3Element
        abstract animate: unit -> bool
        abstract animate: value: bool -> SparkLine
        abstract color: value: ResizeArray<string> -> SparkLine
        abstract color: func: (obj option -> float -> string) -> SparkLine
        abstract height: unit -> float
        abstract height: value: float -> SparkLine
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> SparkLine
        abstract width: unit -> float
        abstract width: value: float -> SparkLine
        abstract x: unit -> (obj option -> float -> float)
        abstract x: func: (obj option -> float -> float) -> SparkLine
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> SparkLine
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> SparkLine
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> SparkLine
        abstract y: unit -> (obj option -> float -> float)
        abstract y: func: (obj option -> float -> float) -> SparkLine
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> SparkLine
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> SparkLine
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> SparkLine

    type [<AllowNullLiteral>] SparkLinePlus =
        inherit SparkLine
        abstract sparkline: SparkLine with get, set
        abstract alignValue: unit -> bool
        abstract alignValue: value: bool -> SparkLinePlus
        abstract noData: unit -> string
        abstract noData: value: string -> SparkLinePlus
        abstract rightAlignValue: unit -> bool
        abstract rightAlignValue: value: bool -> SparkLinePlus
        abstract showLastValue: unit -> bool
        abstract showLastValue: value: bool -> SparkLinePlus
        abstract xTickFormat: format: (obj option -> string) -> SparkLinePlus
        abstract xTickFormat: format: string -> SparkLinePlus
        abstract xTickFormat: format: (obj option -> obj option -> string) -> SparkLinePlus
        abstract yTickFormat: format: (obj option -> string) -> SparkLinePlus
        abstract yTickFormat: format: string -> SparkLinePlus
        abstract yTickFormat: format: (obj option -> obj option -> string) -> SparkLinePlus

    type [<AllowNullLiteral>] StackedArea =
        inherit Scatter
        abstract scatter: Scatter with get, set
        abstract defined: unit -> (obj option -> float -> bool)
        abstract defined: func: (obj option -> float -> bool) -> StackedArea
        abstract interpolate: unit -> string
        abstract interpolate: value: string -> StackedArea
        [<Emit "$0.offset('silhouette')">] abstract offset_silhouette: unit -> StackedArea
        [<Emit "$0.offset('wiggle')">] abstract offset_wiggle: unit -> StackedArea
        [<Emit "$0.offset('expand')">] abstract offset_expand: unit -> StackedArea
        [<Emit "$0.offset('zero')">] abstract offset_zero: unit -> StackedArea
        abstract offset: offset: string -> StackedArea
        abstract offset: offset: (Array<float * float> -> ResizeArray<float>) -> StackedArea
        abstract order: unit -> string
        abstract order: value: string -> StackedArea
        [<Emit "$0.style('stack')">] abstract style_stack: unit -> StackedArea
        [<Emit "$0.style('stream')">] abstract style_stream: unit -> StackedArea
        [<Emit "$0.style('stream-center')">] abstract ``style_stream-center``: unit -> StackedArea
        [<Emit "$0.style('expand')">] abstract style_expand: unit -> StackedArea
        [<Emit "$0.style('stack_percent')">] abstract style_stack_percent: unit -> StackedArea
        abstract style: offset: string -> StackedArea
        abstract width: unit -> float
        abstract width: value: float -> StackedArea
        abstract height: unit -> float
        abstract height: value: float -> StackedArea

    type [<AllowNullLiteral>] Sunburst =
        inherit Nvd3Element
        abstract color: value: ResizeArray<string> -> Sunburst
        abstract color: func: (obj option -> float -> string) -> Sunburst
        abstract height: unit -> float
        abstract height: value: float -> Sunburst
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> Sunburst
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> Sunburst
        abstract mode: unit -> string
        [<Emit "$0.mode('size')">] abstract mode_size: unit -> Sunburst
        [<Emit "$0.mode('count')">] abstract mode_count: unit -> Sunburst
        abstract mode: value: string -> Sunburst
        abstract width: unit -> float
        abstract width: value: float -> Sunburst

    type [<AllowNullLiteral>] Tooltip =
        abstract chartContainer: el: HTMLElement -> Tooltip
        abstract chartContainer: unit -> HTMLElement
        abstract classes: el: string -> Tooltip
        abstract classes: unit -> string
        abstract contentGenerator: unit -> (obj option -> string)
        abstract contentGenerator: func: (obj option -> string) -> Tooltip
        abstract data: unit -> obj option
        abstract data: value: obj option -> Tooltip
        abstract distance: unit -> float
        abstract distance: value: float -> Tooltip
        abstract duration: unit -> float
        abstract duration: value: float -> Tooltip
        abstract enabled: unit -> bool
        abstract enabled: value: bool -> Tooltip
        abstract fixedTop: unit -> float
        abstract fixedTop: value: float -> Tooltip
        abstract gravity: unit -> string
        abstract gravity: value: string -> Tooltip
        abstract headerEnabled: unit -> bool
        abstract headerEnabled: value: bool -> Tooltip
        abstract headerFormatter: func: (obj option -> string) -> Tooltip
        abstract headerFormatter: unit -> (obj option -> string)
        abstract hidden: unit -> bool
        abstract hidden: value: bool -> Tooltip
        abstract hideDelay: unit -> float
        abstract hideDelay: value: float -> Tooltip
        abstract id: unit -> obj option
        abstract keyFormatter: unit -> (obj option -> float -> string)
        abstract keyFormatter: func: (obj option -> float -> string) -> Tooltip
        abstract offset: unit -> Offset
        abstract offset: value: Offset -> Tooltip
        abstract position: unit -> Offset
        abstract position: value: Offset -> Tooltip
        abstract snapDistance: unit -> float
        abstract snapDistance: value: float -> Tooltip
        abstract tooltipElem: unit -> HTMLElement
        abstract valueFormatter: unit -> (obj option -> string)
        abstract valueFormatter: func: (obj option -> string) -> Tooltip

    type [<AllowNullLiteral>] SankeyNodeStyleOptions =
        abstract title: obj option with get, set
        abstract fillColor: obj option with get, set
        abstract strokeColor: obj option with get, set

    type [<AllowNullLiteral>] BoxPlotChart =
        inherit Chart
        abstract boxplot: BoxPlot with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract color: value: ResizeArray<string> -> BoxPlotChart
        abstract color: func: (obj option -> float -> string) -> BoxPlotChart
        abstract duration: unit -> float
        abstract duration: value: float -> BoxPlotChart
        abstract height: unit -> float
        abstract height: value: float -> BoxPlotChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> BoxPlotChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> BoxPlotChart
        abstract maxBoxWidth: unit -> float
        abstract maxBoxWidth: value: float -> BoxPlotChart
        abstract noData: unit -> string
        abstract noData: value: string -> BoxPlotChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> BoxPlotChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> BoxPlotChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> BoxPlotChart
        abstract staggerLabels: unit -> bool
        abstract staggerLabels: value: bool -> BoxPlotChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> BoxPlotChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> BoxPlotChart
        abstract width: unit -> float
        abstract width: value: float -> BoxPlotChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> BoxPlotChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> BoxPlotChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> BoxPlotChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> BoxPlotChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> BoxPlotChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> BoxPlotChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> BoxPlotChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> BoxPlotChart

    type [<AllowNullLiteral>] BulletChart =
        inherit Chart
        abstract bullet: Bullet with get, set
        abstract tooltip: Tooltip with get, set
        abstract color: value: ResizeArray<string> -> BulletChart
        abstract color: func: (obj option -> float -> string) -> BulletChart
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> BulletChart
        abstract height: unit -> float
        abstract height: value: float -> BulletChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> BulletChart
        abstract markers: unit -> (obj option -> obj option)
        abstract markers: func: (obj option -> obj option) -> BulletChart
        abstract measures: unit -> (obj option -> obj option)
        abstract measures: func: (obj option -> obj option) -> BulletChart
        abstract noData: unit -> string
        abstract noData: value: string -> BulletChart
        abstract orient: unit -> string
        abstract orient: orientation: string -> BulletChart
        abstract ranges: unit -> (obj option -> obj option)
        abstract ranges: func: (obj option -> obj option) -> BulletChart
        abstract tickFormat: unit -> (obj option -> string)
        abstract tickFormat: format: (obj option -> string) -> BulletChart
        abstract tickFormat: format: string -> BulletChart
        abstract tickFormat: format: (obj option -> obj option -> string) -> BulletChart
        abstract ticks: unit -> ResizeArray<obj option>
        abstract ticks: [<ParamArray>] args: ResizeArray<obj option> -> BulletChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> BulletChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> BulletChart
        abstract width: unit -> float
        abstract width: value: float -> BulletChart

    type [<AllowNullLiteral>] CandlestickBarChart =
        inherit Chart
        abstract bars: CandlestickBar with get, set
        abstract legend: Legend with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> CandlestickBarChart
        abstract close: unit -> (obj option -> float)
        abstract close: func: (obj option -> float) -> CandlestickBarChart
        abstract color: value: ResizeArray<string> -> CandlestickBarChart
        abstract color: func: (obj option -> float -> string) -> CandlestickBarChart
        abstract duration: unit -> float
        abstract duration: value: float -> CandlestickBarChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> CandlestickBarChart
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> CandlestickBarChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> CandlestickBarChart
        abstract height: unit -> float
        abstract height: value: float -> CandlestickBarChart
        abstract high: unit -> (obj option -> float)
        abstract high: func: (obj option -> float) -> CandlestickBarChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> CandlestickBarChart
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> CandlestickBarChart
        abstract low: unit -> (obj option -> float)
        abstract low: func: (obj option -> float) -> CandlestickBarChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> CandlestickBarChart
        abstract noData: unit -> string
        abstract noData: value: string -> CandlestickBarChart
        abstract ``open``: unit -> (obj option -> float)
        abstract ``open``: func: (obj option -> float) -> CandlestickBarChart
        abstract padData: unit -> bool
        abstract padData: value: bool -> CandlestickBarChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> CandlestickBarChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> CandlestickBarChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> CandlestickBarChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> CandlestickBarChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> CandlestickBarChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> CandlestickBarChart
        abstract useInteractiveGuideline: unit -> bool
        abstract useInteractiveGuideline: value: bool -> CandlestickBarChart
        abstract width: unit -> float
        abstract width: value: float -> CandlestickBarChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> CandlestickBarChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> CandlestickBarChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> CandlestickBarChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> CandlestickBarChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> CandlestickBarChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> CandlestickBarChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> CandlestickBarChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> CandlestickBarChart

    type [<AllowNullLiteral>] CumulativeLineChart =
        inherit LineChart
        abstract controls: Legend with get, set
        abstract average: func: (obj option -> float) -> CumulativeLineChart
        abstract average: unit -> (obj option -> float)
        abstract noErrorCheck: value: bool -> CumulativeLineChart
        abstract noErrorCheck: unit -> bool

    type [<AllowNullLiteral>] DiscreteBarChart =
        inherit Chart
        abstract discretebar: DiscreteBar with get, set
        abstract legend: Legend with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract color: value: ResizeArray<string> -> DiscreteBarChart
        abstract color: func: (obj option -> float -> string) -> DiscreteBarChart
        abstract duration: unit -> float
        abstract duration: value: float -> DiscreteBarChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> DiscreteBarChart
        abstract height: unit -> float
        abstract height: value: float -> DiscreteBarChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> DiscreteBarChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> DiscreteBarChart
        abstract noData: unit -> string
        abstract noData: value: string -> DiscreteBarChart
        abstract rectClass: unit -> string
        abstract rectClass: value: string -> DiscreteBarChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> DiscreteBarChart
        abstract showValues: unit -> bool
        abstract showValues: value: bool -> DiscreteBarChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> DiscreteBarChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> DiscreteBarChart
        abstract staggerLabels: unit -> bool
        abstract staggerLabels: value: bool -> DiscreteBarChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> DiscreteBarChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> DiscreteBarChart
        abstract valueFormat: unit -> string
        abstract valueFormat: value: string -> DiscreteBarChart
        abstract valueFormat: format: (obj option -> string) -> DiscreteBarChart
        abstract width: unit -> float
        abstract width: value: float -> DiscreteBarChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> DiscreteBarChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> DiscreteBarChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> DiscreteBarChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> DiscreteBarChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> DiscreteBarChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> DiscreteBarChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> DiscreteBarChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> DiscreteBarChart

    type [<AllowNullLiteral>] HistoricalBarChart =
        inherit Chart
        abstract bars: HistoricalBar with get, set
        abstract legend: Legend with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> HistoricalBarChart
        abstract color: value: ResizeArray<string> -> HistoricalBarChart
        abstract color: func: (obj option -> float -> string) -> HistoricalBarChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> HistoricalBarChart
        abstract duration: unit -> float
        abstract duration: value: float -> HistoricalBarChart
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> HistoricalBarChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> HistoricalBarChart
        abstract height: unit -> float
        abstract height: value: float -> HistoricalBarChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> HistoricalBarChart
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> HistoricalBarChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> HistoricalBarChart
        abstract noData: unit -> string
        abstract noData: value: string -> HistoricalBarChart
        abstract padData: unit -> bool
        abstract padData: value: bool -> HistoricalBarChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> HistoricalBarChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> HistoricalBarChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> HistoricalBarChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> HistoricalBarChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> HistoricalBarChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> HistoricalBarChart
        abstract useInteractiveGuideline: unit -> bool
        abstract useInteractiveGuideline: value: bool -> HistoricalBarChart
        abstract width: unit -> float
        abstract width: value: float -> HistoricalBarChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> HistoricalBarChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> HistoricalBarChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> HistoricalBarChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> HistoricalBarChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> HistoricalBarChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> HistoricalBarChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> HistoricalBarChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> HistoricalBarChart

    type [<AllowNullLiteral>] LineChart =
        inherit Chart
        abstract lines: Line with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract legend: Legend with get, set
        abstract tooltip: Tooltip with get, set
        abstract focus: Focus with get, set
        abstract clearHighlights: unit -> LineChart
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> LineChart
        abstract clipRadius: func: (obj option -> float) -> LineChart
        abstract clipRadius: value: float -> LineChart
        abstract clipVoronoi: unit -> bool
        abstract clipVoronoi: value: bool -> LineChart
        abstract color: value: ResizeArray<string> -> LineChart
        abstract color: func: (obj option -> float -> string) -> LineChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> LineChart
        abstract defined: unit -> (obj option -> float -> bool)
        abstract defined: func: (obj option -> float -> bool) -> LineChart
        abstract duration: unit -> float
        abstract duration: value: float -> LineChart
        abstract forcePoint: unit -> ResizeArray<float>
        abstract forcePoint: value: ResizeArray<float> -> LineChart
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> LineChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> LineChart
        abstract height: unit -> float
        abstract height: value: float -> LineChart
        abstract highlightPoint: unit -> (obj option -> bool)
        abstract highlightPoint: func: (obj option -> bool) -> LineChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> LineChart
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> LineChart
        abstract interpolate: unit -> string
        abstract interpolate: value: string -> LineChart
        abstract isArea: unit -> (obj option -> bool)
        abstract isArea: value: bool -> LineChart
        abstract isArea: func: (obj option -> bool) -> LineChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> LineChart
        abstract noData: unit -> string
        abstract noData: value: string -> LineChart
        abstract padData: unit -> bool
        abstract padData: value: bool -> LineChart
        abstract padDataOuter: unit -> float
        abstract padDataOuter: value: float -> LineChart
        abstract pointActive: unit -> (obj option -> bool)
        abstract pointActive: func: (obj option -> bool) -> LineChart
        abstract pointxDomain: unit -> ResizeArray<float>
        abstract pointDomain: value: ResizeArray<float> -> LineChart
        abstract pointRange: unit -> ResizeArray<float>
        abstract pointRange: value: ResizeArray<float> -> LineChart
        abstract pointScale: unit -> obj option
        abstract pointScale: value: obj option -> LineChart
        abstract pointSize: unit -> (obj option -> float)
        abstract pointSize: func: (obj option -> float) -> LineChart
        abstract pointSize: value: float -> LineChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> LineChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> LineChart
        abstract showVoronoi: unit -> bool
        abstract showVoronoi: value: bool -> LineChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> LineChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> LineChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> LineChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> LineChart
        abstract useInteractiveGuideline: unit -> bool
        abstract useInteractiveGuideline: value: bool -> LineChart
        abstract useVoronoi: unit -> bool
        abstract useVoronoi: value: bool -> LineChart
        abstract width: unit -> float
        abstract width: value: float -> LineChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> LineChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> LineChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> LineChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> LineChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> LineChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> LineChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> LineChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> LineChart

    type [<AllowNullLiteral>] LinePlusBarChart =
        inherit Chart
        abstract legend: Legend with get, set
        abstract lines: Line with get, set
        abstract lines2: Line with get, set
        abstract bars: HistoricalBar with get, set
        abstract bars2: HistoricalBar with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract x2Axis: Nvd3Axis with get, set
        abstract y1Axis: Nvd3Axis with get, set
        abstract y2Axis: Nvd3Axis with get, set
        abstract y3Axis: Nvd3Axis with get, set
        abstract y4Axis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract brushExtent: unit -> U2<float * float, float * float * float * float>
        abstract brushExtent: value: U2<float * float, float * float * float * float> -> LinePlusBarChart
        abstract clearHighlights: unit -> LinePlusBarChart
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> LinePlusBarChart
        abstract clipRadius: func: (obj option -> float) -> LinePlusBarChart
        abstract clipRadius: value: float -> LinePlusBarChart
        abstract clipVoronoi: unit -> bool
        abstract clipVoronoi: value: bool -> LinePlusBarChart
        abstract color: value: ResizeArray<string> -> LinePlusBarChart
        abstract color: func: (obj option -> float -> string) -> LinePlusBarChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> LinePlusBarChart
        abstract defined: unit -> (obj option -> float -> bool)
        abstract defined: func: (obj option -> float -> bool) -> LinePlusBarChart
        abstract duration: unit -> float
        abstract duration: value: float -> LinePlusBarChart
        abstract focusEnable: unit -> bool
        abstract focusEnable: value: bool -> LinePlusBarChart
        abstract focusHeight: unit -> float
        abstract focusHeight: value: float -> LinePlusBarChart
        abstract focusShowAxisX: unit -> bool
        abstract focusShowAxisX: value: bool -> LinePlusBarChart
        abstract focusShowAxisY: unit -> bool
        abstract focusShowAxisY: value: bool -> LinePlusBarChart
        abstract forcePoint: unit -> ResizeArray<float>
        abstract forcePoint: value: ResizeArray<float> -> LinePlusBarChart
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> LinePlusBarChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> LinePlusBarChart
        abstract height: unit -> float
        abstract height: value: float -> LinePlusBarChart
        abstract highlightPoint: unit -> (obj option -> bool)
        abstract highlightPoint: func: (obj option -> bool) -> LinePlusBarChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> LinePlusBarChart
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> LinePlusBarChart
        abstract interpolate: unit -> string
        abstract interpolate: value: string -> LinePlusBarChart
        abstract isArea: unit -> (obj option -> bool)
        abstract isArea: value: bool -> LinePlusBarChart
        abstract isArea: func: (obj option -> bool) -> LinePlusBarChart
        abstract legendLeftAxisHint: unit -> string
        abstract legendLeftAxisHint: value: string -> LinePlusBarChart
        abstract legendRightAxisHint: unit -> string
        abstract legendRightAxisHint: value: string -> LinePlusBarChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> LinePlusBarChart
        abstract noData: unit -> string
        abstract noData: value: string -> LinePlusBarChart
        abstract padData: unit -> bool
        abstract padData: value: bool -> LinePlusBarChart
        abstract padDataOuter: unit -> float
        abstract padDataOuter: value: float -> LinePlusBarChart
        abstract pointActive: unit -> (obj option -> bool)
        abstract pointActive: func: (obj option -> bool) -> LinePlusBarChart
        abstract pointxDomain: unit -> ResizeArray<float>
        abstract pointDomain: value: ResizeArray<float> -> LinePlusBarChart
        abstract pointRange: unit -> ResizeArray<float>
        abstract pointRange: value: ResizeArray<float> -> LinePlusBarChart
        abstract pointScale: unit -> obj option
        abstract pointScale: value: obj option -> LinePlusBarChart
        abstract pointSize: unit -> (obj option -> float)
        abstract pointSize: func: (obj option -> float) -> LinePlusBarChart
        abstract pointSize: value: float -> LinePlusBarChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> LinePlusBarChart
        abstract showVoronoi: unit -> bool
        abstract showVoronoi: value: bool -> LinePlusBarChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> LinePlusBarChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> LinePlusBarChart
        abstract useInteractiveGuideline: unit -> bool
        abstract useInteractiveGuideline: value: bool -> LinePlusBarChart
        abstract useVoronoi: unit -> bool
        abstract useVoronoi: value: bool -> LinePlusBarChart
        abstract width: unit -> float
        abstract width: value: float -> LinePlusBarChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> LinePlusBarChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> LinePlusBarChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> LinePlusBarChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> LinePlusBarChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> LinePlusBarChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> LinePlusBarChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> LinePlusBarChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> LinePlusBarChart

    type [<AllowNullLiteral>] LineWithFocusChart =
        inherit Chart
        abstract legend: Legend with get, set
        abstract lines: Line with get, set
        abstract lines2: Line with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract x2Axis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract y2Axis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract brushExtent: unit -> U2<float * float, float * float * float * float>
        abstract brushExtent: value: U2<float * float, float * float * float * float> -> LineWithFocusChart
        abstract clearHighlights: unit -> LineWithFocusChart
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> LineWithFocusChart
        abstract clipRadius: func: (obj option -> float) -> LineWithFocusChart
        abstract clipRadius: value: float -> LineWithFocusChart
        abstract clipVoronoi: unit -> bool
        abstract clipVoronoi: value: bool -> LineWithFocusChart
        abstract color: value: ResizeArray<string> -> LineWithFocusChart
        abstract color: func: (obj option -> float -> string) -> LineWithFocusChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> LineWithFocusChart
        abstract defined: unit -> (obj option -> float -> bool)
        abstract defined: func: (obj option -> float -> bool) -> LineWithFocusChart
        abstract duration: unit -> float
        abstract duration: value: float -> LineWithFocusChart
        abstract focusHeight: unit -> float
        abstract focusHeight: value: float -> LineWithFocusChart
        abstract focusMargin: unit -> Margin
        abstract focusMargin: value: Margin -> LineWithFocusChart
        abstract forcePoint: unit -> ResizeArray<float>
        abstract forcePoint: value: ResizeArray<float> -> LineWithFocusChart
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> LineWithFocusChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> LineWithFocusChart
        abstract height: unit -> float
        abstract height: value: float -> LineWithFocusChart
        abstract highlightPoint: unit -> (obj option -> bool)
        abstract highlightPoint: func: (obj option -> bool) -> LineWithFocusChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> LineWithFocusChart
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> LineWithFocusChart
        abstract interpolate: unit -> string
        abstract interpolate: value: string -> LineWithFocusChart
        abstract isArea: unit -> (obj option -> bool)
        abstract isArea: value: bool -> LineWithFocusChart
        abstract isArea: func: (obj option -> bool) -> LineWithFocusChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> LineWithFocusChart
        abstract noData: unit -> string
        abstract noData: value: string -> LineWithFocusChart
        abstract padData: unit -> bool
        abstract padData: value: bool -> LineWithFocusChart
        abstract padDataOuter: unit -> float
        abstract padDataOuter: value: float -> LineWithFocusChart
        abstract pointActive: unit -> (obj option -> bool)
        abstract pointActive: func: (obj option -> bool) -> LineWithFocusChart
        abstract pointxDomain: unit -> ResizeArray<float>
        abstract pointDomain: value: ResizeArray<float> -> LineWithFocusChart
        abstract pointRange: unit -> ResizeArray<float>
        abstract pointRange: value: ResizeArray<float> -> LineWithFocusChart
        abstract pointScale: unit -> obj option
        abstract pointScale: value: obj option -> LineWithFocusChart
        abstract pointSize: unit -> (obj option -> float)
        abstract pointSize: func: (obj option -> float) -> LineWithFocusChart
        abstract pointSize: value: float -> LineWithFocusChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> LineWithFocusChart
        abstract showVoronoi: unit -> bool
        abstract showVoronoi: value: bool -> LineWithFocusChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> LineWithFocusChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> LineWithFocusChart
        abstract useInteractiveGuideline: unit -> bool
        abstract useInteractiveGuideline: value: bool -> LineWithFocusChart
        abstract useVoronoi: unit -> bool
        abstract useVoronoi: value: bool -> LineWithFocusChart
        abstract width: unit -> float
        abstract width: value: float -> LineWithFocusChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> LineWithFocusChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> LineWithFocusChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> LineWithFocusChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> LineWithFocusChart
        abstract xTickFormat: unit -> (obj option -> string)
        abstract xTickFormat: format: (obj option -> string) -> LineWithFocusChart
        abstract xTickFormat: format: string -> LineWithFocusChart
        abstract xTickFormat: format: (obj option -> obj option -> string) -> LineWithFocusChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> LineWithFocusChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> LineWithFocusChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> LineWithFocusChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> LineWithFocusChart
        abstract yTickFormat: unit -> (obj option -> string)
        abstract yTickFormat: format: (obj option -> string) -> LineWithFocusChart
        abstract yTickFormat: format: string -> LineWithFocusChart
        abstract yTickFormat: format: (obj option -> obj option -> string) -> LineWithFocusChart

    type [<AllowNullLiteral>] MultiBarChart =
        inherit Chart
        abstract multibar: MultiBar with get, set
        abstract legend: Legend with get, set
        abstract controls: Legend with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract barColor: value: ResizeArray<string> -> MultiBarChart
        abstract barColor: func: (obj option -> float -> string) -> MultiBarChart
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> MultiBarChart
        abstract color: value: ResizeArray<string> -> MultiBarChart
        abstract color: func: (obj option -> float -> string) -> MultiBarChart
        abstract controlLabels: unit -> obj option
        abstract controlLabels: value: obj option -> MultiBarChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> MultiBarChart
        abstract disabled: unit -> ResizeArray<bool>
        abstract disabled: value: ResizeArray<bool> -> MultiBarChart
        abstract duration: unit -> float
        abstract duration: value: float -> MultiBarChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> MultiBarChart
        abstract groupSpacing: unit -> float
        abstract groupSpacing: value: float -> MultiBarChart
        abstract height: unit -> float
        abstract height: value: float -> MultiBarChart
        abstract hideable: unit -> bool
        abstract hideable: value: bool -> MultiBarChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> MultiBarChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> MultiBarChart
        abstract noData: unit -> string
        abstract noData: value: string -> MultiBarChart
        abstract reduceXTicks: unit -> bool
        abstract reduceXTicks: value: bool -> MultiBarChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> MultiBarChart
        abstract rotateLabels: unit -> float
        abstract rotateLabels: value: float -> MultiBarChart
        abstract showControls: unit -> bool
        abstract showControls: value: bool -> MultiBarChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> MultiBarChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> MultiBarChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> MultiBarChart
        abstract stacked: unit -> bool
        abstract stacked: value: bool -> MultiBarChart
        [<Emit "$0.stackOffset('silhouette')">] abstract stackOffset_silhouette: unit -> MultiBarChart
        [<Emit "$0.stackOffset('wiggle')">] abstract stackOffset_wiggle: unit -> MultiBarChart
        [<Emit "$0.stackOffset('expand')">] abstract stackOffset_expand: unit -> MultiBarChart
        [<Emit "$0.stackOffset('zero')">] abstract stackOffset_zero: unit -> MultiBarChart
        abstract stackOffset: offset: string -> MultiBarChart
        abstract stackOffset: offset: (Array<float * float> -> ResizeArray<float>) -> MultiBarChart
        abstract staggerLabels: unit -> bool
        abstract staggerLabels: value: bool -> MultiBarChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> MultiBarChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> MultiBarChart
        abstract width: unit -> float
        abstract width: value: float -> MultiBarChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> MultiBarChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> MultiBarChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> MultiBarChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> MultiBarChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> MultiBarChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> MultiBarChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> MultiBarChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> MultiBarChart

    type [<AllowNullLiteral>] MultiBarHorizontalChart =
        inherit Chart
        abstract multibar: MultiBar with get, set
        abstract legend: Legend with get, set
        abstract controls: Legend with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract barColor: value: ResizeArray<string> -> MultiBarHorizontalChart
        abstract barColor: func: (obj option -> float -> string) -> MultiBarHorizontalChart
        abstract color: value: ResizeArray<string> -> MultiBarHorizontalChart
        abstract color: func: (obj option -> float -> string) -> MultiBarHorizontalChart
        abstract controlLabels: unit -> obj option
        abstract controlLabels: value: obj option -> MultiBarHorizontalChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> MultiBarHorizontalChart
        abstract disabled: unit -> ResizeArray<bool>
        abstract disabled: value: ResizeArray<bool> -> MultiBarHorizontalChart
        abstract duration: unit -> float
        abstract duration: value: float -> MultiBarHorizontalChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> MultiBarHorizontalChart
        abstract groupSpacing: unit -> float
        abstract groupSpacing: value: float -> MultiBarHorizontalChart
        abstract height: unit -> float
        abstract height: value: float -> MultiBarHorizontalChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> MultiBarHorizontalChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> MultiBarHorizontalChart
        abstract noData: unit -> string
        abstract noData: value: string -> MultiBarHorizontalChart
        abstract showControls: unit -> bool
        abstract showControls: value: bool -> MultiBarHorizontalChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> MultiBarHorizontalChart
        abstract showValues: unit -> bool
        abstract showValues: value: bool -> MultiBarHorizontalChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> MultiBarHorizontalChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> MultiBarHorizontalChart
        abstract stacked: unit -> bool
        abstract stacked: value: bool -> MultiBarHorizontalChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> MultiBarHorizontalChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> MultiBarHorizontalChart
        abstract valueFormat: unit -> string
        abstract valueFormat: value: string -> MultiBarHorizontalChart
        abstract valueFormat: format: (obj option -> string) -> MultiBarHorizontalChart
        abstract valuePadding: unit -> float
        abstract valuePadding: value: float -> MultiBarHorizontalChart
        abstract width: unit -> float
        abstract width: value: float -> MultiBarHorizontalChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> MultiBarHorizontalChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> MultiBarHorizontalChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> MultiBarHorizontalChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> MultiBarHorizontalChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> MultiBarHorizontalChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> MultiBarHorizontalChart
        abstract yErr: unit -> (obj option -> float -> U2<float, ResizeArray<float>>)
        abstract yErr: func: (obj option -> float -> U2<float, ResizeArray<float>>) -> MultiBarHorizontalChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> MultiBarHorizontalChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> MultiBarHorizontalChart

    type [<AllowNullLiteral>] MultiChart =
        inherit Chart
        abstract lines1: Line with get, set
        abstract lines2: Line with get, set
        abstract bars1: MultiBar with get, set
        abstract bars2: MultiBar with get, set
        abstract scatters1: Scatter with get, set
        abstract scatters2: Scatter with get, set
        abstract stack1: StackedArea with get, set
        abstract stack2: StackedArea with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis1: Nvd3Axis with get, set
        abstract yAxis2: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract color: value: ResizeArray<string> -> MultiChart
        abstract color: func: (obj option -> float -> string) -> MultiChart
        abstract interpolate: unit -> string
        abstract interpolate: value: string -> MultiChart
        abstract isArea: unit -> (obj option -> bool)
        abstract isArea: value: bool -> MultiChart
        abstract isArea: func: (obj option -> bool) -> MultiChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> MultiChart
        abstract noData: unit -> string
        abstract noData: value: string -> MultiChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> MultiChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> MultiChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> MultiChart
        abstract useVoronoi: unit -> bool
        abstract useVoronoi: value: bool -> MultiChart
        abstract width: unit -> float
        abstract width: value: float -> MultiChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> MultiChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> MultiChart
        abstract yDomain1: unit -> ResizeArray<float>
        abstract yDomain1: value: ResizeArray<float> -> MultiChart
        abstract yDomain2: unit -> ResizeArray<float>
        abstract yDomain2: value: ResizeArray<float> -> MultiChart

    type [<AllowNullLiteral>] OhlcBarChart =
        inherit Chart
        abstract bars: OhlcBar with get, set
        abstract legend: Legend with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> OhlcBarChart
        abstract close: unit -> (obj option -> float)
        abstract close: func: (obj option -> float) -> OhlcBarChart
        abstract color: value: ResizeArray<string> -> OhlcBarChart
        abstract color: func: (obj option -> float -> string) -> OhlcBarChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> OhlcBarChart
        abstract duration: unit -> float
        abstract duration: value: float -> OhlcBarChart
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> OhlcBarChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> OhlcBarChart
        abstract height: unit -> float
        abstract height: value: float -> OhlcBarChart
        abstract high: unit -> (obj option -> float)
        abstract high: func: (obj option -> float) -> OhlcBarChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> OhlcBarChart
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> OhlcBarChart
        abstract low: unit -> (obj option -> float)
        abstract low: func: (obj option -> float) -> OhlcBarChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> OhlcBarChart
        abstract noData: unit -> string
        abstract noData: value: string -> OhlcBarChart
        abstract ``open``: unit -> (obj option -> float)
        abstract ``open``: func: (obj option -> float) -> OhlcBarChart
        abstract padData: unit -> bool
        abstract padData: value: bool -> OhlcBarChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> OhlcBarChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> OhlcBarChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> OhlcBarChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> OhlcBarChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> OhlcBarChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> OhlcBarChart
        abstract useInteractiveGuideline: unit -> bool
        abstract useInteractiveGuideline: value: bool -> OhlcBarChart
        abstract width: unit -> float
        abstract width: value: float -> OhlcBarChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> OhlcBarChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> OhlcBarChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> OhlcBarChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> OhlcBarChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> OhlcBarChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> OhlcBarChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> OhlcBarChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> OhlcBarChart

    type [<AllowNullLiteral>] ParallelCoordinatesChart =
        inherit Chart
        abstract parallelCoordinates: ParallelCoordinates with get, set
        abstract legend: Legend with get, set
        abstract tooltip: Tooltip with get, set
        abstract color: value: ResizeArray<string> -> ParallelCoordinatesChart
        abstract color: func: (obj option -> float -> string) -> ParallelCoordinatesChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> ParallelCoordinatesChart
        abstract dimensionData: unit -> obj option
        abstract dimensionData: d: obj option -> ParallelCoordinatesChart
        abstract dimensionFormats: unit -> ResizeArray<string>
        abstract dimensionFormats: value: ResizeArray<string> -> ParallelCoordinatesChart
        abstract dimensionNames: unit -> ResizeArray<string>
        abstract dimensionNames: value: ResizeArray<string> -> ParallelCoordinatesChart
        abstract dimensions: unit -> obj option
        abstract dimensions: value: obj option -> ParallelCoordinatesChart
        abstract displayBrush: unit -> bool
        abstract displayBrush: value: bool -> ParallelCoordinatesChart
        abstract height: unit -> float
        abstract height: value: float -> ParallelCoordinatesChart
        abstract lineTension: unit -> float
        abstract lineTension: value: float -> ParallelCoordinatesChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> ParallelCoordinatesChart
        abstract noData: unit -> string
        abstract noData: value: string -> ParallelCoordinatesChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> ParallelCoordinatesChart
        abstract width: unit -> float
        abstract width: value: float -> ParallelCoordinatesChart

    type [<AllowNullLiteral>] PieChart =
        inherit Chart
        abstract legend: Legend with get, set
        abstract pie: Pie with get, set
        abstract tooltip: Tooltip with get, set
        abstract arcsRadius: unit -> ResizeArray<ArcsRadius>
        abstract arcsRadius: value: ResizeArray<ArcsRadius> -> PieChart
        abstract color: value: ResizeArray<string> -> PieChart
        abstract color: func: (obj option -> float -> string) -> PieChart
        abstract cornerRadius: unit -> float
        abstract cornerRadius: value: float -> PieChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> PieChart
        abstract donut: unit -> bool
        abstract donut: value: bool -> PieChart
        abstract donutLabelsOutside: unit -> bool
        abstract donutLabelsOutside: value: bool -> PieChart
        abstract donutRatio: unit -> float
        abstract donutRatio: value: float -> PieChart
        abstract duration: unit -> float
        abstract duration: value: float -> PieChart
        abstract endAngle: unit -> (obj option -> float)
        abstract endAngle: func: (obj option -> float) -> PieChart
        abstract growOnHover: unit -> bool
        abstract growOnHover: value: bool -> PieChart
        abstract height: unit -> float
        abstract height: value: float -> PieChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> PieChart
        abstract labelFormat: unit -> string
        abstract labelFormat: value: string -> PieChart
        abstract labelFormat: format: (obj option -> string) -> PieChart
        abstract labelSunbeamLayout: unit -> bool
        abstract labelSunbeamLayout: value: bool -> PieChart
        abstract labelThreshold: unit -> float
        abstract labelThreshold: value: float -> PieChart
        abstract labelType: unit -> string
        [<Emit "$0.labelType('key')">] abstract labelType_key: unit -> PieChart
        [<Emit "$0.labelType('value')">] abstract labelType_value: unit -> PieChart
        [<Emit "$0.labelType('percent')">] abstract labelType_percent: unit -> PieChart
        abstract labelType: value: string -> PieChart
        abstract labelType: func: (obj option -> float -> obj option -> string) -> PieChart
        abstract labelsOutside: unit -> bool
        abstract labelsOutside: value: bool -> PieChart
        abstract legendPosition: unit -> string
        [<Emit "$0.legendPosition('top')">] abstract legendPosition_top: unit -> PieChart
        [<Emit "$0.legendPosition('right')">] abstract legendPosition_right: unit -> PieChart
        abstract legendPosition: value: string -> PieChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> PieChart
        abstract noData: unit -> string
        abstract noData: value: string -> PieChart
        abstract padAngle: unit -> float
        abstract padAngle: value: float -> PieChart
        abstract pieLabelsOutside: unit -> bool
        abstract pieLabelsOutside: value: bool -> PieChart
        abstract showLabels: unit -> bool
        abstract showLabels: value: bool -> PieChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> PieChart
        abstract startAngle: unit -> (obj option -> float)
        abstract startAngle: func: (obj option -> float) -> PieChart
        abstract title: unit -> string
        abstract title: value: string -> PieChart
        abstract titleOffset: unit -> float
        abstract titleOffset: value: float -> PieChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> PieChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> PieChart
        abstract valueFormat: unit -> string
        abstract valueFormat: value: string -> PieChart
        abstract valueFormat: format: (obj option -> string) -> PieChart
        abstract width: unit -> float
        abstract width: value: float -> PieChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> PieChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> PieChart

    type [<AllowNullLiteral>] ScatterChart =
        inherit Chart
        abstract scatter: Scatter with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract legend: Legend with get, set
        abstract tooltip: Tooltip with get, set
        abstract distX: Distribution with get, set
        abstract distY: Distribution with get, set
        abstract clearHighlights: unit -> ScatterChart
        abstract clipEdge: unit -> bool
        abstract clipEdge: value: bool -> ScatterChart
        abstract clipRadius: func: (obj option -> float) -> ScatterChart
        abstract clipRadius: value: float -> ScatterChart
        abstract clipVoronoi: unit -> bool
        abstract clipVoronoi: value: bool -> ScatterChart
        abstract color: value: ResizeArray<string> -> ScatterChart
        abstract color: func: (obj option -> float -> string) -> ScatterChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> ScatterChart
        abstract duration: unit -> float
        abstract duration: value: float -> ScatterChart
        abstract forcePoint: unit -> ResizeArray<float>
        abstract forcePoint: value: ResizeArray<float> -> ScatterChart
        abstract forceX: unit -> ResizeArray<float>
        abstract forceX: value: ResizeArray<float> -> ScatterChart
        abstract forceY: unit -> ResizeArray<float>
        abstract forceY: value: ResizeArray<float> -> ScatterChart
        abstract height: unit -> float
        abstract height: value: float -> ScatterChart
        abstract highlightPoint: unit -> (obj option -> bool)
        abstract highlightPoint: func: (obj option -> bool) -> ScatterChart
        abstract id: unit -> obj option
        abstract id: value: U2<float, string> -> ScatterChart
        abstract interactive: unit -> bool
        abstract interactive: value: bool -> ScatterChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> ScatterChart
        abstract noData: unit -> string
        abstract noData: value: string -> ScatterChart
        abstract padData: unit -> bool
        abstract padData: value: bool -> ScatterChart
        abstract padDataOuter: unit -> float
        abstract padDataOuter: value: float -> ScatterChart
        abstract pointActive: unit -> (obj option -> bool)
        abstract pointActive: func: (obj option -> bool) -> ScatterChart
        abstract pointxDomain: unit -> ResizeArray<float>
        abstract pointDomain: value: ResizeArray<float> -> ScatterChart
        abstract pointRange: unit -> ResizeArray<float>
        abstract pointRange: value: ResizeArray<float> -> ScatterChart
        abstract pointScale: unit -> obj option
        abstract pointScale: value: obj option -> ScatterChart
        abstract pointSize: unit -> (obj option -> float)
        abstract pointSize: func: (obj option -> float) -> ScatterChart
        abstract pointSize: value: float -> ScatterChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> ScatterChart
        abstract showDistX: unit -> bool
        abstract showDistX: value: bool -> ScatterChart
        abstract showDistY: unit -> bool
        abstract showDistY: value: bool -> ScatterChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> ScatterChart
        abstract showVoronoi: unit -> bool
        abstract showVoronoi: value: bool -> ScatterChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> ScatterChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> ScatterChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> ScatterChart
        abstract tooltipXContent: unit -> (obj option -> string)
        abstract tooltipXContent: func: (obj option -> string) -> ScatterChart
        abstract tooltipYContent: unit -> (obj option -> string)
        abstract tooltipYContent: func: (obj option -> string) -> ScatterChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> ScatterChart
        abstract useVoronoi: unit -> bool
        abstract useVoronoi: value: bool -> ScatterChart
        abstract width: unit -> float
        abstract width: value: float -> ScatterChart
        abstract x: unit -> (obj option -> obj option)
        abstract x: func: (obj option -> obj option) -> ScatterChart
        abstract xDomain: unit -> ResizeArray<float>
        abstract xDomain: value: ResizeArray<float> -> ScatterChart
        abstract xRange: unit -> ResizeArray<float>
        abstract xRange: value: ResizeArray<float> -> ScatterChart
        abstract xScale: unit -> obj option
        abstract xScale: value: obj option -> ScatterChart
        abstract y: unit -> (obj option -> float)
        abstract y: func: (obj option -> float) -> ScatterChart
        abstract yDomain: unit -> ResizeArray<float>
        abstract yDomain: value: ResizeArray<float> -> ScatterChart
        abstract yRange: unit -> ResizeArray<float>
        abstract yRange: value: ResizeArray<float> -> ScatterChart
        abstract yScale: unit -> obj option
        abstract yScale: value: obj option -> ScatterChart

    type [<AllowNullLiteral>] SankeyChart =
        inherit Chart
        abstract center: unit -> float
        abstract center: value: (obj option -> obj option) -> SankeyChart
        abstract format: unit -> string
        abstract format: formatter: (obj option -> string) -> SankeyChart
        abstract height: unit -> float
        abstract height: value: float -> SankeyChart
        abstract linkTitle: unit -> string
        abstract linkTitle: formatter: (obj option -> string) -> SankeyChart
        abstract nodePadding: unit -> float
        abstract nodePadding: value: float -> SankeyChart
        abstract margin: unit -> Margin
        abstract margin: value: Margin -> SankeyChart
        abstract nodeWidth: unit -> float
        abstract nodeWidth: value: float -> SankeyChart
        abstract nodeStyle: unit -> SankeyNodeStyleOptions
        abstract nodeStyle: value: SankeyNodeStyleOptions -> SankeyChart
        abstract width: unit -> float
        abstract width: value: float -> SankeyChart
        abstract units: unit -> string
        abstract units: value: string -> SankeyChart

    type [<AllowNullLiteral>] StackedAreaChart =
        inherit StackedArea
        inherit Chart
        abstract stacked: StackedArea with get, set
        abstract legend: Legend with get, set
        abstract controls: Legend with get, set
        abstract xAxis: Nvd3Axis with get, set
        abstract x2Axis: Nvd3Axis with get, set
        abstract yAxis: Nvd3Axis with get, set
        abstract y2Axis: Nvd3Axis with get, set
        abstract tooltip: Tooltip with get, set
        abstract focus: Focus with get, set
        abstract controlLabels: unit -> obj option
        abstract controlLabels: value: obj option -> StackedAreaChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> StackedAreaChart
        abstract noData: unit -> string
        abstract noData: value: string -> StackedAreaChart
        abstract rightAlignYAxis: unit -> bool
        abstract rightAlignYAxis: value: bool -> StackedAreaChart
        abstract showLegend: unit -> bool
        abstract showLegend: value: bool -> StackedAreaChart
        abstract showXAxis: unit -> bool
        abstract showXAxis: value: bool -> StackedAreaChart
        abstract showYAxis: unit -> bool
        abstract showYAxis: value: bool -> StackedAreaChart
        abstract tooltipContent: unit -> (obj option -> string)
        abstract tooltipContent: func: (obj option -> string) -> StackedAreaChart
        abstract tooltips: unit -> bool
        abstract tooltips: value: bool -> StackedAreaChart
        abstract useInteractiveGuideline: unit -> bool
        abstract useInteractiveGuideline: value: bool -> StackedAreaChart
        abstract focusEnable: unit -> bool
        abstract focusEnable: value: bool -> StackedAreaChart
        abstract focusHeight: unit -> float
        abstract focusHeight: value: float -> StackedAreaChart
        abstract showControls: unit -> bool
        abstract showControls: value: bool -> StackedAreaChart
        abstract brushExtent: unit -> U2<float * float, float * float * float * float>
        abstract brushExtent: value: U2<float * float, float * float * float * float> -> StackedAreaChart

    type [<AllowNullLiteral>] SunburstChart =
        inherit Sunburst
        inherit Chart
        abstract sunburst: Sunburst with get, set
        abstract tooltip: Tooltip with get, set
        abstract duration: unit -> float
        abstract duration: value: float -> SunburstChart
        abstract defaultState: unit -> obj option
        abstract defaultState: value: obj option -> SunburstChart
        abstract noData: unit -> string
        abstract noData: value: string -> SunburstChart

    type [<AllowNullLiteral>] Models =
        abstract boxPlotChart: unit -> BoxPlotChart
        abstract bullet: unit -> Bullet
        abstract bulletChart: unit -> BulletChart
        abstract candlestickBar: unit -> CandlestickBar
        abstract candlestickBarChart: unit -> CandlestickBarChart
        abstract cumulativeLineChart: unit -> CumulativeLineChart
        abstract discreteBar: unit -> DiscreteBar
        abstract discreteBarChart: unit -> DiscreteBarChart
        abstract distribution: unit -> Distribution
        abstract historicalBar: unit -> HistoricalBar
        abstract historicalBarChart: ?bar_model: HistoricalBar -> HistoricalBarChart
        abstract ohlcBar: unit -> OhlcBar
        abstract ohlcBarChart: unit -> OhlcBarChart
        abstract legend: unit -> Legend
        abstract line: unit -> Line
        abstract lineChart: unit -> LineChart
        abstract linePlusBarChart: unit -> LinePlusBarChart
        abstract lineWithFocusChart: unit -> LineWithFocusChart
        abstract multiBarChart: unit -> MultiBarChart
        abstract multiBarHorizontalChart: unit -> MultiBarHorizontalChart
        abstract multiChart: unit -> MultiChart
        abstract parallelCoordinates: unit -> ParallelCoordinates
        abstract parallelCoordinatesChart: unit -> ParallelCoordinatesChart
        abstract pie: unit -> Pie
        abstract pieChart: unit -> PieChart
        abstract sankeyChart: unit -> SankeyChart
        abstract scatter: unit -> Scatter
        abstract scatterChart: unit -> ScatterChart
        abstract sparkline: unit -> SparkLine
        abstract sparklinePlus: unit -> SparkLinePlus
        abstract stackedArea: unit -> StackedArea
        abstract stackedAreaChart: unit -> StackedAreaChart
        abstract sunburst: unit -> Sunburst
        abstract sunburstChart: unit -> SunburstChart
        abstract tooltip: unit -> Tooltip

    type [<AllowNullLiteral>] Nvd3Static =
        abstract dev: bool with get, set
        abstract charts: obj option with get, set
        abstract models: Models with get, set
        abstract tooltip: Nvd3TooltipStatic with get, set
        abstract utils: Utils with get, set
        abstract logs: obj option with get, set
        abstract addGraph: factory: ChartFactory<'TChart> -> unit when 'TChart :> Nvd3Element
        abstract addGraph: generate: (unit -> 'TChart) * ?callBack: ('TChart -> unit) -> unit when 'TChart :> Nvd3Element
        abstract log: topic: string * ?value: string -> string
        abstract log: arg: ResizeArray<obj option> -> obj option