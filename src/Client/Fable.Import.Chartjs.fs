// ts2fable 0.8.0
module rec moduleName
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open Fable.Import.Moment

[<Erase>] type KeyOf<'T> = Key of string
type Array<'T> = System.Collections.Generic.IList<'T>


let [<Import("*","module")>] chart: IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Chart: ChartStatic
    abstract PluginService: PluginServiceStaticStatic

type [<AllowNullLiteral>] Chart =
    abstract config: Chart.ChartConfiguration with get, set
    abstract data: Chart.ChartData with get, set
    abstract destroy: (unit -> ChartDestroy) with get, set
    abstract update: (Chart.ChartUpdateProps -> ChartDestroy) with get, set
    abstract render: (Chart.ChartRenderProps -> ChartDestroy) with get, set
    abstract stop: (unit -> Chart) with get, set
    abstract resize: (unit -> Chart) with get, set
    abstract clear: (unit -> Chart) with get, set
    abstract toBase64Image: (unit -> string) with get, set
    abstract generateLegend: (unit -> ChartDestroy) with get, set
    abstract getElementAtEvent: (obj option -> ChartDestroy) with get, set
    abstract getElementsAtEvent: (obj option -> Array<ChartDestroy>) with get, set
    abstract getElementsAtXAxis: (obj option -> Array<ChartDestroy>) with get, set
    abstract getDatasetAtEvent: (obj option -> Array<ChartDestroy>) with get, set
    abstract getDatasetMeta: (float -> Meta) with get, set
    abstract getVisibleDatasetCount: (unit -> float) with get, set
    abstract isDatasetVisible: (float -> bool) with get, set
    abstract setDatasetVisibility: (float -> bool -> unit) with get, set
    abstract ctx: CanvasRenderingContext2D option with get, set
    abstract canvas: HTMLCanvasElement option with get, set
    abstract width: float option with get, set
    abstract height: float option with get, set
    abstract aspectRatio: float option with get, set
    abstract options: Chart.ChartOptions with get, set
    abstract chartArea: Chart.ChartArea with get, set

type [<AllowNullLiteral>] ChartStatic =
    abstract Chart: obj
    [<EmitConstructor>] abstract Create: context: U4<string, CanvasRenderingContext2D, HTMLCanvasElement, ArrayLike<U2<CanvasRenderingContext2D, HTMLCanvasElement>>> * options: Chart.ChartConfiguration -> Chart
    abstract pluginService: PluginServiceStatic with get, set
    abstract plugins: PluginServiceStatic with get, set
    abstract defaults: ChartStaticDefaults with get, set
    abstract controllers: ChartStaticControllers with get, set
    abstract helpers: ChartStaticControllers with get, set
    abstract platform: ChartStaticPlatform with get, set
    abstract scaleService: ChartStaticScaleService with get, set
    abstract Tooltip: Chart.ChartTooltipsStaticConfiguration with get, set
    abstract instances: ChartStaticInstances

type [<AllowNullLiteral>] Plugin =
    interface end

type [<AllowNullLiteral>] PluginDescriptor =
    abstract plugin: Plugin with get, set
    abstract options: Chart.ChartPluginsOptions with get, set

type [<AllowNullLiteral>] PluginServiceStatic =
    abstract register: plugin: Plugin -> unit
    abstract unregister: plugin: Plugin -> unit
    abstract clear: unit -> unit
    abstract count: unit -> float
    abstract getAll: unit -> ResizeArray<Plugin>
    abstract notify: chart: Chart * hook: KeyOf<Chart.PluginServiceRegistrationOptions> * args: obj option -> bool
    abstract descriptors: chart: Chart -> ResizeArray<PluginDescriptor>

type [<AllowNullLiteral>] PluginServiceStaticStatic =
    [<EmitConstructor>] abstract Create: unit -> PluginServiceStatic

type [<AllowNullLiteral>] Meta =
    abstract ``type``: Chart.ChartType with get, set
    abstract data: ResizeArray<MetaData> with get, set
    abstract dataset: Chart.ChartDataSets option with get, set
    abstract controller: ChartStaticControllers with get, set
    abstract hidden: bool option with get, set
    abstract total: string option with get, set
    abstract xAxisID: string option with get, set
    abstract yAxisID: string option with get, set
    abstract ``$filler``: ChartStaticControllers option with get, set

type [<AllowNullLiteral>] MetaData =
    abstract _chart: Chart with get, set
    abstract _datasetIndex: float with get, set
    abstract _index: float with get, set
    abstract _model: Model with get, set
    abstract _start: obj option with get, set
    abstract _view: Model with get, set
    abstract _xScale: Chart.ChartScales with get, set
    abstract _yScale: Chart.ChartScales with get, set
    abstract hidden: bool option with get, set

type [<AllowNullLiteral>] Model =
    abstract backgroundColor: string with get, set
    abstract borderAlign: Chart.BorderAlignment option with get, set
    abstract borderColor: string with get, set
    abstract borderWidth: float option with get, set
    abstract circumference: float option with get, set
    abstract controlPointNextX: float with get, set
    abstract controlPointNextY: float with get, set
    abstract controlPointPreviousX: float with get, set
    abstract controlPointPreviousY: float with get, set
    abstract endAngle: float option with get, set
    abstract hitRadius: float with get, set
    abstract innerRadius: float option with get, set
    abstract outerRadius: float option with get, set
    abstract pointStyle: string with get, set
    abstract radius: string with get, set
    abstract skip: bool option with get, set
    abstract startAngle: float option with get, set
    abstract steppedLine: obj option with get, set
    abstract tension: float with get, set
    abstract x: float with get, set
    abstract y: float with get, set
    abstract ``base``: float with get, set
    abstract head: float with get, set

module Chart =

    type [<StringEnum>] [<RequireQualifiedAccess>] ChartType =
        | Line
        | Bar
        | HorizontalBar
        | Radar
        | Doughnut
        | PolarArea
        | Bubble
        | Pie
        | Scatter

    type [<StringEnum>] [<RequireQualifiedAccess>] TimeUnit =
        | Millisecond
        | Second
        | Minute
        | Hour
        | Day
        | Week
        | Month
        | Quarter
        | Year

    type [<StringEnum>] [<RequireQualifiedAccess>] ScaleType =
        | Category
        | Linear
        | Logarithmic
        | Time
        | RadialLinear

    type [<StringEnum>] [<RequireQualifiedAccess>] PointStyle =
        | Circle
        | Cross
        | CrossRot
        | Dash
        | Line
        | Rect
        | RectRounded
        | RectRot
        | Star
        | Triangle

    type [<StringEnum>] [<RequireQualifiedAccess>] PositionType =
        | Left
        | Right
        | Top
        | Bottom
        | ChartArea

    type [<AllowNullLiteral>] InteractionModeRegistry =
        abstract point: string with get, set
        abstract nearest: string with get, set
        abstract single: string with get, set
        abstract label: string with get, set
        abstract index: string with get, set
        abstract ``x-axis``: string with get, set
        abstract dataset: string with get, set
        abstract x: string with get, set
        abstract y: string with get, set

    type InteractionMode =
        InteractionModeRegistry

    type [<StringEnum>] [<RequireQualifiedAccess>] Easing =
        | Linear
        | EaseInQuad
        | EaseOutQuad
        | EaseInOutQuad
        | EaseInCubic
        | EaseOutCubic
        | EaseInOutCubic
        | EaseInQuart
        | EaseOutQuart
        | EaseInOutQuart
        | EaseInQuint
        | EaseOutQuint
        | EaseInOutQuint
        | EaseInSine
        | EaseOutSine
        | EaseInOutSine
        | EaseInExpo
        | EaseOutExpo
        | EaseInOutExpo
        | EaseInCirc
        | EaseOutCirc
        | EaseInOutCirc
        | EaseInElastic
        | EaseOutElastic
        | EaseInOutElastic
        | EaseInBack
        | EaseOutBack
        | EaseInOutBack
        | EaseInBounce
        | EaseOutBounce
        | EaseInOutBounce

    type [<StringEnum>] [<RequireQualifiedAccess>] TextAlignment =
        | Left
        | Center
        | Right

    type [<StringEnum>] [<RequireQualifiedAccess>] BorderAlignment =
        | Center
        | Inner

    type BorderWidth =
        U2<float, obj>

    type [<AllowNullLiteral>] ChartArea =
        abstract top: float with get, set
        abstract right: float with get, set
        abstract bottom: float with get, set
        abstract left: float with get, set

    type [<AllowNullLiteral>] ChartLegendItem =
        abstract text: string option with get, set
        abstract fillStyle: string option with get, set
        abstract hidden: bool option with get, set
        abstract index: float option with get, set
        abstract lineCap: ChartLegendItemLineCap option with get, set
        abstract lineDash: ResizeArray<float> option with get, set
        abstract lineDashOffset: float option with get, set
        abstract lineJoin: ChartLegendItemLineJoin option with get, set
        abstract lineWidth: float option with get, set
        abstract strokeStyle: string option with get, set
        abstract pointStyle: PointStyle option with get, set

    type [<AllowNullLiteral>] ChartLegendLabelItem =
        inherit ChartLegendItem
        abstract datasetIndex: float option with get, set

    type [<AllowNullLiteral>] ChartTooltipItem =
        abstract label: string option with get, set
        abstract value: string option with get, set
        abstract xLabel: U2<string, float> option with get, set
        abstract yLabel: U2<string, float> option with get, set
        abstract datasetIndex: float option with get, set
        abstract index: float option with get, set
        abstract x: float option with get, set
        abstract y: float option with get, set

    type [<AllowNullLiteral>] ChartTooltipLabelColor =
        abstract borderColor: ChartColor with get, set
        abstract backgroundColor: ChartColor with get, set

    type [<AllowNullLiteral>] ChartTooltipCallback =
        abstract beforeTitle: item: ResizeArray<ChartTooltipItem> * data: ChartData -> U2<string, ResizeArray<string>>
        abstract title: item: ResizeArray<ChartTooltipItem> * data: ChartData -> U2<string, ResizeArray<string>>
        abstract afterTitle: item: ResizeArray<ChartTooltipItem> * data: ChartData -> U2<string, ResizeArray<string>>
        abstract beforeBody: item: ResizeArray<ChartTooltipItem> * data: ChartData -> U2<string, ResizeArray<string>>
        abstract beforeLabel: tooltipItem: ChartTooltipItem * data: ChartData -> U2<string, ResizeArray<string>>
        abstract label: tooltipItem: ChartTooltipItem * data: ChartData -> U2<string, ResizeArray<string>>
        abstract labelColor: tooltipItem: ChartTooltipItem * chart: Chart -> ChartTooltipLabelColor
        abstract labelTextColor: tooltipItem: ChartTooltipItem * chart: Chart -> string
        abstract afterLabel: tooltipItem: ChartTooltipItem * data: ChartData -> U2<string, ResizeArray<string>>
        abstract afterBody: item: ResizeArray<ChartTooltipItem> * data: ChartData -> U2<string, ResizeArray<string>>
        abstract beforeFooter: item: ResizeArray<ChartTooltipItem> * data: ChartData -> U2<string, ResizeArray<string>>
        abstract footer: item: ResizeArray<ChartTooltipItem> * data: ChartData -> U2<string, ResizeArray<string>>
        abstract afterFooter: item: ResizeArray<ChartTooltipItem> * data: ChartData -> U2<string, ResizeArray<string>>

    type [<AllowNullLiteral>] ChartAnimationParameter =
        abstract chartInstance: obj option with get, set
        abstract animationObject: obj option with get, set

    type [<AllowNullLiteral>] ChartPoint =
        abstract x: U4<float, string, DateTime, Moment> option with get, set
        abstract y: U4<float, string, DateTime, Moment> option with get, set
        abstract r: float option with get, set
        abstract t: U4<float, string, DateTime, Moment> option with get, set

    type [<AllowNullLiteral>] ChartConfiguration =
        abstract ``type``: U2<ChartType, string> option with get, set
        abstract data: ChartData option with get, set
        abstract options: ChartOptions option with get, set
        abstract plugins: ResizeArray<PluginServiceRegistrationOptions> option with get, set

    type [<AllowNullLiteral>] ChartData =
        abstract labels: Array<U8<string, ResizeArray<string>, float, ResizeArray<float>, DateTime, ResizeArray<DateTime>, Moment, ResizeArray<Moment>>> option with get, set
        abstract datasets: ResizeArray<ChartDataSets> option with get, set

    type [<AllowNullLiteral>] RadialChartOptions =
        inherit ChartOptions
        abstract scale: RadialLinearScale option with get, set

    type [<AllowNullLiteral>] ChartSize =
        abstract height: float with get, set
        abstract width: float with get, set

    type [<AllowNullLiteral>] ChartOptions =
        abstract responsive: bool option with get, set
        abstract responsiveAnimationDuration: float option with get, set
        abstract aspectRatio: float option with get, set
        abstract maintainAspectRatio: bool option with get, set
        abstract events: ResizeArray<string> option with get, set
        abstract legendCallback: chart: Chart -> string
        abstract onHover: this: Chart * ``event``: MouseEvent * activeElements: Array<ChartOptionsOnHoverArray> -> obj option
        abstract onClick: ?``event``: MouseEvent * ?activeElements: Array<ChartOptionsOnHoverArray> -> obj option
        abstract onResize: this: Chart * newSize: ChartSize -> unit
        abstract title: ChartTitleOptions option with get, set
        abstract legend: ChartLegendOptions option with get, set
        abstract tooltips: ChartTooltipOptions option with get, set
        abstract hover: ChartHoverOptions option with get, set
        abstract animation: ChartAnimationOptions option with get, set
        abstract elements: ChartElementsOptions option with get, set
        abstract layout: ChartLayoutOptions option with get, set
        abstract scale: RadialLinearScale option with get, set
        abstract scales: U4<ChartScales, LinearScale, LogarithmicScale, TimeScale> option with get, set
        abstract showLines: bool option with get, set
        abstract spanGaps: bool option with get, set
        abstract cutoutPercentage: float option with get, set
        abstract circumference: float option with get, set
        abstract rotation: float option with get, set
        abstract devicePixelRatio: float option with get, set
        abstract plugins: ChartPluginsOptions option with get, set
        abstract defaultColor: ChartColor option with get, set

    type [<AllowNullLiteral>] ChartFontOptions =
        abstract defaultFontColor: ChartColor option with get, set
        abstract defaultFontFamily: string option with get, set
        abstract defaultFontSize: float option with get, set
        abstract defaultFontStyle: string option with get, set

    type [<AllowNullLiteral>] ChartTitleOptions =
        abstract display: bool option with get, set
        abstract position: PositionType option with get, set
        abstract fullWidth: bool option with get, set
        abstract fontSize: float option with get, set
        abstract fontFamily: string option with get, set
        abstract fontColor: ChartColor option with get, set
        abstract fontStyle: string option with get, set
        abstract padding: float option with get, set
        abstract lineHeight: U2<float, string> option with get, set
        abstract text: U2<string, ResizeArray<string>> option with get, set

    type [<AllowNullLiteral>] ChartLegendOptions =
        abstract align: ChartLegendOptionsAlign option with get, set
        abstract display: bool option with get, set
        abstract position: PositionType option with get, set
        abstract fullWidth: bool option with get, set
        abstract onClick: ``event``: MouseEvent * legendItem: ChartLegendLabelItem -> unit
        abstract onHover: ``event``: MouseEvent * legendItem: ChartLegendLabelItem -> unit
        abstract onLeave: ``event``: MouseEvent * legendItem: ChartLegendLabelItem -> unit
        abstract labels: ChartLegendLabelOptions option with get, set
        abstract reverse: bool option with get, set
        abstract rtl: bool option with get, set
        abstract textDirection: string option with get, set

    type [<AllowNullLiteral>] ChartLegendLabelOptions =
        abstract boxWidth: float option with get, set
        abstract fontSize: float option with get, set
        abstract fontStyle: string option with get, set
        abstract fontColor: ChartColor option with get, set
        abstract fontFamily: string option with get, set
        abstract padding: float option with get, set
        abstract generateLabels: chart: Chart -> ResizeArray<ChartLegendLabelItem>
        abstract filter: legendItem: ChartLegendLabelItem * data: ChartData -> obj option
        abstract usePointStyle: bool option with get, set

    type [<AllowNullLiteral>] ChartTooltipOptions =
        abstract axis: ChartTooltipOptionsAxis option with get, set
        abstract enabled: bool option with get, set
        abstract custom: (ChartTooltipModel -> unit) option with get, set
        abstract mode: InteractionMode option with get, set
        abstract intersect: bool option with get, set
        abstract backgroundColor: ChartColor option with get, set
        abstract titleAlign: TextAlignment option with get, set
        abstract titleFontFamily: string option with get, set
        abstract titleFontSize: float option with get, set
        abstract titleFontStyle: string option with get, set
        abstract titleFontColor: ChartColor option with get, set
        abstract titleSpacing: float option with get, set
        abstract titleMarginBottom: float option with get, set
        abstract bodyAlign: TextAlignment option with get, set
        abstract bodyFontFamily: string option with get, set
        abstract bodyFontSize: float option with get, set
        abstract bodyFontStyle: string option with get, set
        abstract bodyFontColor: ChartColor option with get, set
        abstract bodySpacing: float option with get, set
        abstract footerAlign: TextAlignment option with get, set
        abstract footerFontFamily: string option with get, set
        abstract footerFontSize: float option with get, set
        abstract footerFontStyle: string option with get, set
        abstract footerFontColor: ChartColor option with get, set
        abstract footerSpacing: float option with get, set
        abstract footerMarginTop: float option with get, set
        abstract xPadding: float option with get, set
        abstract yPadding: float option with get, set
        abstract caretSize: float option with get, set
        abstract cornerRadius: float option with get, set
        abstract multiKeyBackground: string option with get, set
        abstract callbacks: ChartTooltipCallback option with get, set
        abstract filter: item: ChartTooltipItem * data: ChartData -> bool
        abstract itemSort: itemA: ChartTooltipItem * itemB: ChartTooltipItem * ?data: ChartData -> float
        abstract position: string option with get, set
        abstract caretPadding: float option with get, set
        abstract displayColors: bool option with get, set
        abstract borderColor: ChartColor option with get, set
        abstract borderWidth: float option with get, set
        abstract rtl: bool option with get, set
        abstract textDirection: string option with get, set

    type [<AllowNullLiteral>] ChartTooltipModel =
        abstract afterBody: ResizeArray<string> with get, set
        abstract backgroundColor: string with get, set
        abstract beforeBody: ResizeArray<string> with get, set
        abstract body: ResizeArray<ChartTooltipModelBody> with get, set
        abstract bodyFontColor: string with get, set
        abstract bodyFontSize: float with get, set
        abstract bodySpacing: float with get, set
        abstract borderColor: string with get, set
        abstract borderWidth: float with get, set
        abstract caretPadding: float with get, set
        abstract caretSize: float with get, set
        abstract caretX: float with get, set
        abstract caretY: float with get, set
        abstract cornerRadius: float with get, set
        abstract dataPoints: ResizeArray<ChartTooltipItem> with get, set
        abstract displayColors: bool with get, set
        abstract footer: ResizeArray<string> with get, set
        abstract footerFontColor: string with get, set
        abstract footerFontSize: float with get, set
        abstract footerMarginTop: float with get, set
        abstract footerSpacing: float with get, set
        abstract height: float with get, set
        abstract labelColors: ResizeArray<string> with get, set
        abstract labelTextColors: ResizeArray<string> with get, set
        abstract legendColorBackground: string with get, set
        abstract opacity: float with get, set
        abstract title: ResizeArray<string> with get, set
        abstract titleFontColor: string with get, set
        abstract titleFontSize: float with get, set
        abstract titleMarginBottom: float with get, set
        abstract titleSpacing: float with get, set
        abstract width: float with get, set
        abstract x: float with get, set
        abstract xAlign: string with get, set
        abstract xPadding: float with get, set
        abstract y: float with get, set
        abstract yAlign: string with get, set
        abstract yPadding: float with get, set
        abstract _bodyAlign: string with get, set
        abstract _bodyFontFamily: string with get, set
        abstract _bodyFontStyle: string with get, set
        abstract _footerAlign: string with get, set
        abstract _footerFontFamily: string with get, set
        abstract _footerFontStyle: string with get, set
        abstract _titleAlign: string with get, set
        abstract _titleFontFamily: string with get, set
        abstract _titleFontStyle: string with get, set

    type [<AllowNullLiteral>] ChartTooltipModelBody =
        abstract before: ResizeArray<string> with get, set
        abstract lines: ResizeArray<string> with get, set
        abstract after: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] ChartPluginsOptions =
        [<EmitIndexer>] abstract Item: pluginId: string -> obj option with get, set

    type [<AllowNullLiteral>] ChartTooltipsStaticConfiguration =
        abstract positioners: ChartTooltipsStaticConfigurationPositioners with get, set

    type [<AllowNullLiteral>] ChartTooltipPositioner =
        [<Emit "$0($1...)">] abstract Invoke: elements: ResizeArray<obj option> * eventPosition: Point -> Point

    type [<AllowNullLiteral>] ChartHoverOptions =
        abstract mode: InteractionMode option with get, set
        abstract animationDuration: float option with get, set
        abstract intersect: bool option with get, set
        abstract axis: ChartTooltipOptionsAxis option with get, set
        abstract onHover: this: Chart * ``event``: MouseEvent * activeElements: Array<ChartOptionsOnHoverArray> -> obj option

    type [<AllowNullLiteral>] ChartAnimationObject =
        abstract currentStep: float option with get, set
        abstract numSteps: float option with get, set
        abstract easing: Easing option with get, set
        abstract render: arg: obj option -> unit
        abstract onAnimationProgress: arg: obj option -> unit
        abstract onAnimationComplete: arg: obj option -> unit

    type [<AllowNullLiteral>] ChartAnimationOptions =
        abstract duration: float option with get, set
        abstract easing: Easing option with get, set
        abstract onProgress: chart: obj option -> unit
        abstract onComplete: chart: obj option -> unit
        abstract animateRotate: bool option with get, set
        abstract animateScale: bool option with get, set

    type [<AllowNullLiteral>] ChartElementsOptions =
        abstract point: ChartPointOptions option with get, set
        abstract line: ChartLineOptions option with get, set
        abstract arc: ChartArcOptions option with get, set
        abstract rectangle: ChartRectangleOptions option with get, set

    type [<AllowNullLiteral>] ChartArcOptions =
        abstract angle: float option with get, set
        abstract backgroundColor: ChartColor option with get, set
        abstract borderAlign: BorderAlignment option with get, set
        abstract borderColor: ChartColor option with get, set
        abstract borderWidth: float option with get, set

    type [<AllowNullLiteral>] ChartLineOptions =
        abstract cubicInterpolationMode: ChartLineOptionsCubicInterpolationMode option with get, set
        abstract tension: float option with get, set
        abstract backgroundColor: ChartColor option with get, set
        abstract borderWidth: float option with get, set
        abstract borderColor: ChartColor option with get, set
        abstract borderCapStyle: string option with get, set
        abstract borderDash: ResizeArray<obj option> option with get, set
        abstract borderDashOffset: float option with get, set
        abstract borderJoinStyle: string option with get, set
        abstract capBezierPoints: bool option with get, set
        abstract fill: U2<bool, string> option with get, set
        abstract stepped: bool option with get, set

    type [<AllowNullLiteral>] ChartPointOptions =
        abstract radius: float option with get, set
        abstract pointStyle: PointStyle option with get, set
        abstract rotation: float option with get, set
        abstract backgroundColor: ChartColor option with get, set
        abstract borderWidth: float option with get, set
        abstract borderColor: ChartColor option with get, set
        abstract hitRadius: float option with get, set
        abstract hoverRadius: float option with get, set
        abstract hoverBorderWidth: float option with get, set

    type [<AllowNullLiteral>] ChartRectangleOptions =
        abstract backgroundColor: ChartColor option with get, set
        abstract borderWidth: float option with get, set
        abstract borderColor: ChartColor option with get, set
        abstract borderSkipped: string option with get, set

    type [<AllowNullLiteral>] ChartLayoutOptions =
        abstract padding: U2<ChartLayoutPaddingObject, float> option with get, set

    type [<AllowNullLiteral>] ChartLayoutPaddingObject =
        abstract top: float option with get, set
        abstract right: float option with get, set
        abstract bottom: float option with get, set
        abstract left: float option with get, set

    type [<AllowNullLiteral>] GridLineOptions =
        abstract display: bool option with get, set
        abstract circular: bool option with get, set
        abstract color: ChartColor option with get, set
        abstract borderDash: ResizeArray<float> option with get, set
        abstract borderDashOffset: float option with get, set
        abstract lineWidth: U2<float, ResizeArray<float>> option with get, set
        abstract drawBorder: bool option with get, set
        abstract drawOnChartArea: bool option with get, set
        abstract drawTicks: bool option with get, set
        abstract tickMarkLength: float option with get, set
        abstract zeroLineWidth: float option with get, set
        abstract zeroLineColor: ChartColor option with get, set
        abstract zeroLineBorderDash: ResizeArray<float> option with get, set
        abstract zeroLineBorderDashOffset: float option with get, set
        abstract offsetGridLines: bool option with get, set
        abstract z: float option with get, set

    type [<AllowNullLiteral>] ScaleTitleOptions =
        abstract display: bool option with get, set
        abstract labelString: string option with get, set
        abstract lineHeight: U2<float, string> option with get, set
        abstract fontColor: ChartColor option with get, set
        abstract fontFamily: string option with get, set
        abstract fontSize: float option with get, set
        abstract fontStyle: string option with get, set
        abstract padding: U2<ChartLayoutPaddingObject, float> option with get, set

    type [<AllowNullLiteral>] TickOptions =
        inherit NestedTickOptions
        abstract minor: NestedTickOptions option with get, set
        abstract major: MajorTickOptions option with get, set

    type [<AllowNullLiteral>] NestedTickOptions =
        abstract autoSkip: bool option with get, set
        abstract autoSkipPadding: float option with get, set
        abstract backdropColor: ChartColor option with get, set
        abstract backdropPaddingX: float option with get, set
        abstract backdropPaddingY: float option with get, set
        abstract beginAtZero: bool option with get, set
        /// If the callback returns null or undefined the associated grid line will be hidden.
        abstract callback: value: U2<float, string> * index: float * values: U2<ResizeArray<float>, ResizeArray<string>> -> U2<string, float> option
        abstract display: bool option with get, set
        abstract fontColor: ChartColor option with get, set
        abstract fontFamily: string option with get, set
        abstract fontSize: float option with get, set
        abstract fontStyle: string option with get, set
        abstract labelOffset: float option with get, set
        abstract lineHeight: float option with get, set
        abstract max: obj option with get, set
        abstract maxRotation: float option with get, set
        abstract maxTicksLimit: float option with get, set
        abstract min: obj option with get, set
        abstract minRotation: float option with get, set
        abstract mirror: bool option with get, set
        abstract padding: float option with get, set
        abstract precision: float option with get, set
        abstract reverse: bool option with get, set
        /// <summary>
        /// The number of ticks to examine when deciding how many labels will fit.
        /// Setting a smaller value will be faster, but may be less accurate
        /// when there is large variability in label length.
        /// Deault: <c>ticks.length</c>
        /// </summary>
        abstract sampleSize: float option with get, set
        abstract showLabelBackdrop: bool option with get, set
        abstract source: NestedTickOptionsSource option with get, set
        abstract stepSize: float option with get, set
        abstract suggestedMax: float option with get, set
        abstract suggestedMin: float option with get, set

    type [<AllowNullLiteral>] MajorTickOptions =
        inherit NestedTickOptions
        abstract enabled: bool option with get, set

    type [<AllowNullLiteral>] AngleLineOptions =
        abstract display: bool option with get, set
        abstract color: ChartColor option with get, set
        abstract lineWidth: float option with get, set
        abstract borderDash: ResizeArray<float> option with get, set
        abstract borderDashOffset: float option with get, set

    type [<AllowNullLiteral>] PointLabelOptions =
        abstract callback: arg: obj option -> obj option
        abstract fontColor: ChartColor option with get, set
        abstract fontFamily: string option with get, set
        abstract fontSize: float option with get, set
        abstract fontStyle: string option with get, set
        abstract lineHeight: U2<float, string> option with get, set

    type [<AllowNullLiteral>] LinearTickOptions =
        inherit TickOptions
        abstract maxTicksLimit: float option with get, set
        abstract stepSize: float option with get, set
        abstract precision: float option with get, set
        abstract suggestedMin: float option with get, set
        abstract suggestedMax: float option with get, set

    type [<AllowNullLiteral>] LogarithmicTickOptions =
        inherit TickOptions

    type ChartColor =
        U4<string, CanvasGradient, CanvasPattern, ResizeArray<string>>

    type [<AllowNullLiteral>] Scriptable<'T> =
        [<Emit "$0($1...)">] abstract Invoke: ctx: ScriptableInvokeCtx -> 'T

    type [<AllowNullLiteral>] ScriptableInvokeCtx =
        abstract chart: Chart option with get, set
        abstract dataIndex: float option with get, set
        abstract dataset: ChartDataSets option with get, set
        abstract datasetIndex: float option with get, set

    type [<AllowNullLiteral>] ChartDataSets =
        abstract cubicInterpolationMode: ChartLineOptionsCubicInterpolationMode option with get, set
        abstract backgroundColor: U3<ChartColor, ResizeArray<ChartColor>, Scriptable<ChartColor>> option with get, set
        abstract barPercentage: float option with get, set
        abstract barThickness: U2<float, string> option with get, set
        abstract borderAlign: U3<BorderAlignment, ResizeArray<BorderAlignment>, Scriptable<BorderAlignment>> option with get, set
        abstract borderWidth: U3<BorderWidth, ResizeArray<BorderWidth>, Scriptable<BorderWidth>> option with get, set
        abstract borderColor: U3<ChartColor, ResizeArray<ChartColor>, Scriptable<ChartColor>> option with get, set
        abstract borderCapStyle: ChartLegendItemLineCap option with get, set
        abstract borderDash: ResizeArray<float> option with get, set
        abstract borderDashOffset: float option with get, set
        abstract borderJoinStyle: ChartLegendItemLineJoin option with get, set
        abstract borderSkipped: U3<PositionType, ResizeArray<PositionType>, Scriptable<PositionType>> option with get, set
        abstract categoryPercentage: float option with get, set
        abstract data: U2<Array<U2<float, ResizeArray<float>> option>, ResizeArray<ChartPoint>> option with get, set
        abstract fill: U3<bool, float, string> option with get, set
        abstract hitRadius: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract hoverBackgroundColor: U3<ChartColor, ResizeArray<ChartColor>, Scriptable<ChartColor>> option with get, set
        abstract hoverBorderColor: U3<ChartColor, ResizeArray<ChartColor>, Scriptable<ChartColor>> option with get, set
        abstract hoverBorderWidth: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract hoverRadius: float option with get, set
        abstract label: string option with get, set
        abstract lineTension: float option with get, set
        abstract maxBarThickness: float option with get, set
        abstract minBarLength: float option with get, set
        abstract steppedLine: U2<bool, string> option with get, set
        abstract order: float option with get, set
        abstract pointBorderColor: U3<ChartColor, ResizeArray<ChartColor>, Scriptable<ChartColor>> option with get, set
        abstract pointBackgroundColor: U3<ChartColor, ResizeArray<ChartColor>, Scriptable<ChartColor>> option with get, set
        abstract pointBorderWidth: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract pointRadius: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract pointRotation: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract pointHoverRadius: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract pointHitRadius: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract pointHoverBackgroundColor: U3<ChartColor, ResizeArray<ChartColor>, Scriptable<ChartColor>> option with get, set
        abstract pointHoverBorderColor: U3<ChartColor, ResizeArray<ChartColor>, Scriptable<ChartColor>> option with get, set
        abstract pointHoverBorderWidth: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract pointStyle: U5<PointStyle, HTMLImageElement, HTMLCanvasElement, Array<U3<PointStyle, HTMLImageElement, HTMLCanvasElement>>, Scriptable<U3<PointStyle, HTMLImageElement, HTMLCanvasElement>>> option with get, set
        abstract radius: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract rotation: U3<float, ResizeArray<float>, Scriptable<float>> option with get, set
        abstract xAxisID: string option with get, set
        abstract yAxisID: string option with get, set
        abstract ``type``: U2<ChartType, string> option with get, set
        abstract hidden: bool option with get, set
        abstract hideInLegendAndTooltip: bool option with get, set
        abstract showLine: bool option with get, set
        abstract stack: string option with get, set
        abstract spanGaps: bool option with get, set
        abstract weight: float option with get, set

    type [<AllowNullLiteral>] ChartScales =
        abstract ``type``: U2<ScaleType, string> option with get, set
        abstract display: bool option with get, set
        abstract position: U2<PositionType, string> option with get, set
        abstract gridLines: GridLineOptions option with get, set
        abstract scaleLabel: ScaleTitleOptions option with get, set
        abstract ticks: TickOptions option with get, set
        abstract xAxes: ResizeArray<ChartXAxe> option with get, set
        abstract yAxes: ResizeArray<ChartYAxe> option with get, set

    type [<AllowNullLiteral>] CommonAxe =
        abstract bounds: string option with get, set
        abstract ``type``: U2<ScaleType, string> option with get, set
        abstract display: U2<bool, string> option with get, set
        abstract id: string option with get, set
        abstract labels: ResizeArray<string> option with get, set
        abstract stacked: bool option with get, set
        abstract position: string option with get, set
        abstract ticks: TickOptions option with get, set
        abstract gridLines: GridLineOptions option with get, set
        abstract scaleLabel: ScaleTitleOptions option with get, set
        abstract time: TimeScale option with get, set
        abstract offset: bool option with get, set
        abstract beforeUpdate: ?scale: obj -> unit
        abstract beforeSetDimension: ?scale: obj -> unit
        abstract beforeDataLimits: ?scale: obj -> unit
        abstract beforeBuildTicks: ?scale: obj -> unit
        abstract beforeTickToLabelConversion: ?scale: obj -> unit
        abstract beforeCalculateTickRotation: ?scale: obj -> unit
        abstract beforeFit: ?scale: obj -> unit
        abstract afterUpdate: ?scale: obj -> unit
        abstract afterSetDimension: ?scale: obj -> unit
        abstract afterDataLimits: ?scale: obj -> unit
        abstract afterBuildTicks: scale: obj option * ticks: ResizeArray<float> -> ResizeArray<float>
        abstract afterTickToLabelConversion: ?scale: obj -> unit
        abstract afterCalculateTickRotation: ?scale: obj -> unit
        abstract afterFit: ?scale: obj -> unit

    type [<AllowNullLiteral>] ChartXAxe =
        inherit CommonAxe
        abstract distribution: ChartXAxeDistribution option with get, set

    type [<AllowNullLiteral>] ChartYAxe =
        inherit CommonAxe

    type [<AllowNullLiteral>] LinearScale =
        inherit ChartScales
        abstract ticks: LinearTickOptions option with get, set

    type [<AllowNullLiteral>] LogarithmicScale =
        inherit ChartScales
        abstract ticks: LogarithmicTickOptions option with get, set

    type [<AllowNullLiteral>] TimeDisplayFormat =
        abstract millisecond: string option with get, set
        abstract second: string option with get, set
        abstract minute: string option with get, set
        abstract hour: string option with get, set
        abstract day: string option with get, set
        abstract week: string option with get, set
        abstract month: string option with get, set
        abstract quarter: string option with get, set
        abstract year: string option with get, set

    type [<AllowNullLiteral>] DateAdapterOptions =
        abstract date: obj option with get, set

    type [<AllowNullLiteral>] TimeScale =
        inherit ChartScales
        abstract adapters: DateAdapterOptions option with get, set
        abstract displayFormats: TimeDisplayFormat option with get, set
        abstract isoWeekday: bool option with get, set
        abstract max: string option with get, set
        abstract min: string option with get, set
        abstract parser: U2<string, (obj option -> obj option)> option with get, set
        abstract round: TimeUnit option with get, set
        abstract tooltipFormat: string option with get, set
        abstract unit: TimeUnit option with get, set
        abstract unitStepSize: float option with get, set
        abstract stepSize: float option with get, set
        abstract minUnit: TimeUnit option with get, set

    type [<AllowNullLiteral>] RadialLinearScale =
        abstract animate: bool option with get, set
        abstract position: PositionType option with get, set
        abstract angleLines: AngleLineOptions option with get, set
        abstract pointLabels: PointLabelOptions option with get, set
        abstract ticks: LinearTickOptions option with get, set
        abstract display: bool option with get, set
        abstract gridLines: GridLineOptions option with get, set

    type [<AllowNullLiteral>] Point =
        abstract x: float with get, set
        abstract y: float with get, set

    type [<AllowNullLiteral>] PluginServiceGlobalRegistration =
        abstract id: string option with get, set

    type [<AllowNullLiteral>] PluginServiceRegistrationOptions =
        abstract beforeInit: chartInstance: Chart * ?options: obj -> unit
        abstract afterInit: chartInstance: Chart * ?options: obj -> unit
        abstract beforeUpdate: chartInstance: Chart * ?options: obj -> unit
        abstract afterUpdate: chartInstance: Chart * ?options: obj -> unit
        abstract beforeLayout: chartInstance: Chart * ?options: obj -> unit
        abstract afterLayout: chartInstance: Chart * ?options: obj -> unit
        abstract beforeDatasetsUpdate: chartInstance: Chart * ?options: obj -> unit
        abstract afterDatasetsUpdate: chartInstance: Chart * ?options: obj -> unit
        abstract beforeDatasetUpdate: chartInstance: Chart * ?options: obj -> unit
        abstract afterDatasetUpdate: chartInstance: Chart * ?options: obj -> unit
        abstract beforeRender: chartInstance: Chart * ?options: obj -> unit
        abstract afterRender: chartInstance: Chart * ?options: obj -> unit
        abstract beforeDraw: chartInstance: Chart * easing: Easing * ?options: obj -> unit
        abstract afterDraw: chartInstance: Chart * easing: Easing * ?options: obj -> unit
        abstract beforeDatasetsDraw: chartInstance: Chart * easing: Easing * ?options: obj -> unit
        abstract afterDatasetsDraw: chartInstance: Chart * easing: Easing * ?options: obj -> unit
        abstract beforeDatasetDraw: chartInstance: Chart * easing: Easing * ?options: obj -> unit
        abstract afterDatasetDraw: chartInstance: Chart * easing: Easing * ?options: obj -> unit
        abstract beforeTooltipDraw: chartInstance: Chart * ?tooltipData: obj * ?options: obj -> unit
        abstract afterTooltipDraw: chartInstance: Chart * ?tooltipData: obj * ?options: obj -> unit
        abstract beforeEvent: chartInstance: Chart * ``event``: Event * ?options: obj -> unit
        abstract afterEvent: chartInstance: Chart * ``event``: Event * ?options: obj -> unit
        abstract resize: chartInstance: Chart * newChartSize: ChartSize * ?options: obj -> unit
        abstract destroy: chartInstance: Chart -> unit
        /// <summary>Deprecated since version 2.5.0. Use <c>afterLayout</c> instead.</summary>
        abstract afterScaleUpdate: chartInstance: Chart * ?options: obj -> unit

    type [<AllowNullLiteral>] ChartUpdateProps =
        abstract duration: float option with get, set
        abstract ``lazy``: bool option with get, set
        abstract easing: Easing option with get, set

    type [<AllowNullLiteral>] ChartRenderProps =
        abstract duration: float option with get, set
        abstract ``lazy``: bool option with get, set
        abstract easing: Easing option with get, set

    type [<AllowNullLiteral>] DoughnutModel =
        abstract backgroundColor: ChartColor with get, set
        abstract borderAlign: BorderAlignment with get, set
        abstract borderColor: string with get, set
        abstract borderWidth: float with get, set
        abstract circumference: float with get, set
        abstract endAngle: float with get, set
        abstract innerRadius: float with get, set
        abstract outerRadius: float with get, set
        abstract startAngle: float with get, set
        abstract x: float with get, set
        abstract y: float with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ChartLegendItemLineCap =
        | Butt
        | Round
        | Square

    type [<StringEnum>] [<RequireQualifiedAccess>] ChartLegendItemLineJoin =
        | Bevel
        | Round
        | Miter

    type [<AllowNullLiteral>] ChartOptionsOnHoverArray =
        interface end

    type [<StringEnum>] [<RequireQualifiedAccess>] ChartLegendOptionsAlign =
        | Center
        | End
        | Start

    type [<StringEnum>] [<RequireQualifiedAccess>] ChartTooltipOptionsAxis =
        | X
        | Y
        | Xy

    type [<AllowNullLiteral>] ChartTooltipsStaticConfigurationPositioners =
        [<EmitIndexer>] abstract Item: mode: string -> ChartTooltipPositioner with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ChartLineOptionsCubicInterpolationMode =
        | Default
        | Monotone

    type [<StringEnum>] [<RequireQualifiedAccess>] NestedTickOptionsSource =
        | Auto
        | Data
        | Labels

    type [<StringEnum>] [<RequireQualifiedAccess>] ChartXAxeDistribution =
        | Linear
        | Series

type [<AllowNullLiteral>] ChartDestroy =
    interface end

type [<AllowNullLiteral>] ChartStaticDefaults =
    abstract ``global``: obj with get, set
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] ChartStaticControllers =
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] ChartStaticPlatform =
    abstract disableCSSInjection: bool with get, set

type [<AllowNullLiteral>] ChartStaticScaleService =
    abstract updateScaleDefaults: (Chart.ScaleType -> Chart.ChartScales -> unit) with get, set

type [<AllowNullLiteral>] ChartStaticInstances =
    [<EmitIndexer>] abstract Item: key: string -> Chart with get, set