// ts2fable 0.8.0
module rec D3
open System
open Browser.Types
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>
type Symbol = obj

let [<Import("*","d3")>] d3: D3.IExports = jsNative

module D3 =
    let [<Import("selection","d3")>] selection: Selection.IExports = jsNative
    let [<Import("transition","d3")>] transition: Transition.IExports = jsNative
    let [<Import("timer","d3")>] timer: Timer.IExports = jsNative
    let [<Import("random","d3")>] random: Random.IExports = jsNative
    let [<Import("ns","d3")>] ns: Ns.IExports = jsNative
    let [<Import("scale","d3")>] scale: Scale.IExports = jsNative
    let [<Import("time","d3")>] time: Time.IExports = jsNative
    let [<Import("behavior","d3")>] behavior: Behavior.IExports = jsNative
    let [<Import("geo","d3")>] geo: Geo.IExports = jsNative
    let [<Import("svg","d3")>] svg: Svg.IExports = jsNative
    let [<Import("layout","d3")>] layout: Layout.IExports = jsNative
    let [<Import("geom","d3")>] geom: Geom.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract version: string
        /// Find the first element that matches the given selector string.
        abstract select: selector: string -> Selection<obj option>
        /// Create a selection from the given node reference.
        abstract select: node: EventTarget -> Selection<obj option>
        /// Find all elements that match the given selector string.
        abstract selectAll: selector: string -> Selection<obj option>
        /// Create a selection from the given list of nodes.
        abstract selectAll: nodes: ResizeArray<EventTarget> -> Selection<obj option>
        /// Returns the root selection (as if by d3.select(document.documentElement)). This function may be used for 'instanceof' tests, and extending its prototype will add properties to all selections.
        abstract selection: unit -> Selection<obj option>
        abstract transition: unit -> Transition<obj option>
        [<Emit "$0.ease('linear')">] abstract ease_linear: unit -> (float -> float)
        [<Emit "$0.ease('linear-in')">] abstract ``ease_linear-in``: unit -> (float -> float)
        [<Emit "$0.ease('linear-out')">] abstract ``ease_linear-out``: unit -> (float -> float)
        [<Emit "$0.ease('linear-in-out')">] abstract ``ease_linear-in-out``: unit -> (float -> float)
        [<Emit "$0.ease('linear-out-in')">] abstract ``ease_linear-out-in``: unit -> (float -> float)
        [<Emit "$0.ease('poly',$1)">] abstract ease_poly: k: float -> (float -> float)
        [<Emit "$0.ease('poly-in',$1)">] abstract ``ease_poly-in``: k: float -> (float -> float)
        [<Emit "$0.ease('poly-out',$1)">] abstract ``ease_poly-out``: k: float -> (float -> float)
        [<Emit "$0.ease('poly-in-out',$1)">] abstract ``ease_poly-in-out``: k: float -> (float -> float)
        [<Emit "$0.ease('poly-out-in',$1)">] abstract ``ease_poly-out-in``: k: float -> (float -> float)
        [<Emit "$0.ease('quad')">] abstract ease_quad: unit -> (float -> float)
        [<Emit "$0.ease('quad-in')">] abstract ``ease_quad-in``: unit -> (float -> float)
        [<Emit "$0.ease('quad-out')">] abstract ``ease_quad-out``: unit -> (float -> float)
        [<Emit "$0.ease('quad-in-out')">] abstract ``ease_quad-in-out``: unit -> (float -> float)
        [<Emit "$0.ease('quad-out-in')">] abstract ``ease_quad-out-in``: unit -> (float -> float)
        [<Emit "$0.ease('cubic')">] abstract ease_cubic: unit -> (float -> float)
        [<Emit "$0.ease('cubic-in')">] abstract ``ease_cubic-in``: unit -> (float -> float)
        [<Emit "$0.ease('cubic-out')">] abstract ``ease_cubic-out``: unit -> (float -> float)
        [<Emit "$0.ease('cubic-in-out')">] abstract ``ease_cubic-in-out``: unit -> (float -> float)
        [<Emit "$0.ease('cubic-out-in')">] abstract ``ease_cubic-out-in``: unit -> (float -> float)
        [<Emit "$0.ease('sin')">] abstract ease_sin: unit -> (float -> float)
        [<Emit "$0.ease('sin-in')">] abstract ``ease_sin-in``: unit -> (float -> float)
        [<Emit "$0.ease('sin-out')">] abstract ``ease_sin-out``: unit -> (float -> float)
        [<Emit "$0.ease('sin-in-out')">] abstract ``ease_sin-in-out``: unit -> (float -> float)
        [<Emit "$0.ease('sin-out-in')">] abstract ``ease_sin-out-in``: unit -> (float -> float)
        [<Emit "$0.ease('circle')">] abstract ease_circle: unit -> (float -> float)
        [<Emit "$0.ease('circle-in')">] abstract ``ease_circle-in``: unit -> (float -> float)
        [<Emit "$0.ease('circle-out')">] abstract ``ease_circle-out``: unit -> (float -> float)
        [<Emit "$0.ease('circle-in-out')">] abstract ``ease_circle-in-out``: unit -> (float -> float)
        [<Emit "$0.ease('circle-out-in')">] abstract ``ease_circle-out-in``: unit -> (float -> float)
        [<Emit "$0.ease('elastic',$1,$2)">] abstract ease_elastic: ?a: float * ?b: float -> (float -> float)
        [<Emit "$0.ease('elastic-in',$1,$2)">] abstract ``ease_elastic-in``: ?a: float * ?b: float -> (float -> float)
        [<Emit "$0.ease('elastic-out',$1,$2)">] abstract ``ease_elastic-out``: ?a: float * ?b: float -> (float -> float)
        [<Emit "$0.ease('elastic-in-out',$1,$2)">] abstract ``ease_elastic-in-out``: ?a: float * ?b: float -> (float -> float)
        [<Emit "$0.ease('elastic-out-in',$1,$2)">] abstract ``ease_elastic-out-in``: ?a: float * ?b: float -> (float -> float)
        [<Emit "$0.ease('back',$1)">] abstract ease_back: s: float -> (float -> float)
        [<Emit "$0.ease('back-in',$1)">] abstract ``ease_back-in``: s: float -> (float -> float)
        [<Emit "$0.ease('back-out',$1)">] abstract ``ease_back-out``: s: float -> (float -> float)
        [<Emit "$0.ease('back-in-out',$1)">] abstract ``ease_back-in-out``: s: float -> (float -> float)
        [<Emit "$0.ease('back-out-in',$1)">] abstract ``ease_back-out-in``: s: float -> (float -> float)
        [<Emit "$0.ease('bounce')">] abstract ease_bounce: unit -> (float -> float)
        [<Emit "$0.ease('bounce-in')">] abstract ``ease_bounce-in``: unit -> (float -> float)
        [<Emit "$0.ease('bounce-out')">] abstract ``ease_bounce-out``: unit -> (float -> float)
        [<Emit "$0.ease('bounce-in-out')">] abstract ``ease_bounce-in-out``: unit -> (float -> float)
        [<Emit "$0.ease('bounce-out-in')">] abstract ``ease_bounce-out-in``: unit -> (float -> float)
        abstract ease: ``type``: string * [<ParamArray>] args: ResizeArray<obj option> -> (float -> float)
        abstract timer: func: (unit -> obj option) * ?delay: float * ?time: float -> unit
        abstract ``event``: U2<Event, BaseEvent>
        /// <summary>Returns the x and y coordinates of the mouse relative to the provided container element, using d3.event for the mouse's position on the page.</summary>
        /// <param name="container">the container element (e.g. an SVG <g> element)</param>
        abstract mouse: container: EventTarget -> float * float
        /// <summary>Given a container element and a touch identifier, determine the x and y coordinates of the touch.</summary>
        /// <param name="container">the container element (e.g., an SVG <svg> element)</param>
        abstract touch: container: EventTarget * identifer: float -> float * float
        /// <summary>Given a container element, a list of touches, and a touch identifier, determine the x and y coordinates of the touch.</summary>
        /// <param name="container">the container element (e.g., an SVG <svg> element)</param>
        abstract touch: container: EventTarget * touches: TouchList * identifer: float -> float * float
        /// <summary>Given a container element and an optional list of touches, return the position of every touch relative to the container.</summary>
        /// <param name="container">the container element</param>
        /// <param name="touches">an optional list of touches (defaults to d3.event.touches)</param>
        abstract touches: container: EventTarget * ?touches: TouchList -> Array<float * float>
        /// Compares two primitive values for sorting (in ascending order).
        abstract ascending: a: Primitive * b: Primitive -> float
        /// Compares two primitive values for sorting (in ascending order).
        abstract descending: a: Primitive * b: Primitive -> float
        /// Return the minimum value in the array using natural order.
        abstract min: array: ResizeArray<float> -> float
        /// Return the minimum value in the array using natural order.
        abstract min: array: ResizeArray<string> -> string
        /// Return the minimum value in the array using natural order.
        abstract min: array: ResizeArray<'T> -> 'T when 'T :> Numeric
        /// Return the minimum value in the array using natural order.
        abstract min: array: ResizeArray<'T> * accessor: ('T -> float -> float) -> float
        /// Return the minimum value in the array using natural order.
        abstract min: array: ResizeArray<'T> * accessor: ('T -> float -> string) -> string
        /// Return the minimum value in the array using natural order.
        abstract min: array: ResizeArray<'T> * accessor: ('T -> float -> 'U) -> 'U when 'U :> Numeric
        /// Return the maximum value in the array of numbers using natural order.
        abstract max: array: ResizeArray<float> -> float
        /// Return the maximum value in the array of strings using natural order.
        abstract max: array: ResizeArray<string> -> string
        /// Return the maximum value in the array of numbers using natural order.
        abstract max: array: ResizeArray<'T> -> 'T when 'T :> Numeric
        /// Return the maximum value in the array using natural order and a projection function to map values to numbers.
        abstract max: array: ResizeArray<'T> * accessor: ('T -> float -> float) -> float
        /// Return the maximum value in the array using natural order and a projection function to map values to strings.
        abstract max: array: ResizeArray<'T> * accessor: ('T -> float -> string) -> string
        /// Return the maximum value in the array using natural order and a projection function to map values to easily-sorted values.
        abstract max: array: ResizeArray<'T> * accessor: ('T -> float -> 'U) -> 'U when 'U :> Numeric
        /// Return the min and max simultaneously.
        abstract extent: array: ResizeArray<float> -> float * float
        /// Return the min and max simultaneously.
        abstract extent: array: ResizeArray<string> -> string * string
        /// Return the min and max simultaneously.
        abstract extent: array: ResizeArray<'T> -> 'T * 'T when 'T :> Numeric
        /// Return the min and max simultaneously.
        abstract extent: array: Array<U2<'T, Primitive>> -> U2<'T, Primitive> * U2<'T, Primitive> when 'T :> Numeric
        /// Return the min and max simultaneously.
        abstract extent: array: ResizeArray<'T> * accessor: ('T -> float -> float) -> float * float
        /// Return the min and max simultaneously.
        abstract extent: array: ResizeArray<'T> * accessor: ('T -> float -> string) -> string * string
        /// Return the min and max simultaneously.
        abstract extent: array: ResizeArray<'T> * accessor: ('T -> float -> DateTime) -> DateTime * DateTime
        /// Return the min and max simultaneously.
        abstract extent: array: ResizeArray<'T> * accessor: ('T -> float -> 'U) -> U2<'U, Primitive> * U2<'U, Primitive> when 'U :> Numeric
        /// Compute the sum of an array of numbers.
        abstract sum: array: ResizeArray<float> -> float
        /// Compute the sum of an array, using the given accessor to convert values to numbers.
        abstract sum: array: ResizeArray<'T> * accessor: ('T -> float -> float) -> float
        abstract mean: array: ResizeArray<float> -> float
        abstract mean: array: ResizeArray<'T> * accessor: ('T -> float -> float) -> float
        /// Compute the median of an array of numbers (the 0.5-quantile).
        abstract median: array: ResizeArray<float> -> float
        abstract median: datum: ResizeArray<'T> * accessor: ('T -> float -> float) -> float
        abstract quantile: array: ResizeArray<float> * p: float -> float
        abstract variance: array: ResizeArray<float> -> float
        abstract variance: array: ResizeArray<'T> * accessor: ('T -> float -> float) -> float
        abstract deviation: array: ResizeArray<float> -> float
        abstract deviation: array: ResizeArray<'T> * accessor: ('T -> float -> float) -> float
        abstract bisectLeft: array: ResizeArray<'T> * x: 'T * ?lo: float * ?hi: float -> float
        abstract bisect: obj
        abstract bisectRight: array: ResizeArray<'T> * x: 'T * ?lo: float * ?hi: float -> float
        abstract bisector: accessor: ('T -> 'U) -> BisectorReturn
        abstract bisector: comparator: ('T -> 'U -> float) -> BisectorReturn_
        abstract shuffle: array: ResizeArray<'T> * ?lo: float * ?hi: float -> ResizeArray<'T>
        /// <summary>Returns the enumerable property names of the specified object.</summary>
        /// <param name="object">a JavaScript object</param>
        abstract keys: ``object``: Object -> ResizeArray<string>
        /// Returns an array containing the property values of the specified object.
        abstract values: ``object``: ValuesObject -> ResizeArray<'T>
        /// Returns an array containing the property values of the specified object.
        abstract values: ``object``: ValuesObject_ -> ResizeArray<'T>
        /// Returns an array containing the property values of the specified object.
        abstract values: ``object``: Object -> ResizeArray<obj option>
        /// Returns an array of key-value pairs containing the property values of the specified object.
        abstract entries: ``object``: EntriesObject -> ResizeArray<IExportsEntries<'T>>
        /// Returns an array of key-value pairs containing the property values of the specified object.
        abstract entries: ``object``: EntriesObject_ -> ResizeArray<IExportsEntries<'T>>
        /// Returns an array of key-value pairs containing the property values of the specified object.
        abstract entries: ``object``: Object -> ResizeArray<IExportsEntries2>
        /// Constructs an initially empty map.
        abstract map: unit -> Map<'T>
        /// Construct a new map by copying keys and values from the given one.
        abstract map: ``object``: Map<'T> -> Map<'T>
        /// Construct a new map by copying enumerable properties and values from the given object.
        abstract map: ``object``: MapObject -> Map<'T>
        /// Construct a new map by copying enumerable properties and values from the given object.
        abstract map: ``object``: MapObject_ -> Map<'T>
        /// Construct a new map by copying elements from the array. The key function is used to identify each object.
        abstract map: array: ResizeArray<'T> * key: ('T -> float -> string) -> Map<'T>
        /// Construct a new map by copying enumerable properties and values from the given object.
        abstract map: ``object``: Object -> Map<obj option>
        /// Creates an initially-empty set.
        abstract set: unit -> Set
        /// Initializes a set from the given array of strings.
        abstract set: array: ResizeArray<string> -> Set
        /// Merges the specified arrays into a single array.
        abstract merge: arrays: ResizeArray<ResizeArray<'T>> -> ResizeArray<'T>
        /// Generates a 0-based numeric sequence. The output range does not include 'stop'.
        abstract range: stop: float -> ResizeArray<float>
        /// Generates a numeric sequence starting from the given start and stop values. 'step' defaults to 1. The output range does not include 'stop'.
        abstract range: start: float * stop: float * ?step: float -> ResizeArray<float>
        /// Given the specified array, return an array corresponding to the list of indices in 'keys'.
        abstract permute: array: PermuteArray * keys: ResizeArray<float> -> ResizeArray<'T>
        /// Given the specified object, return an array corresponding to the list of property names in 'keys'.
        abstract permute: ``object``: PermuteObject * keys: ResizeArray<string> -> ResizeArray<'T>
        abstract zip: [<ParamArray>] arrays: ResizeArray<ResizeArray<'T>> -> ResizeArray<ResizeArray<'T>>
        abstract transpose: matrix: ResizeArray<ResizeArray<'T>> -> ResizeArray<ResizeArray<'T>>
        /// For each adjacent pair of elements in the specified array, returns a new array of tuples of elements i and i - 1.
        /// Returns the empty array if the input array has fewer than two elements.
        abstract pairs: array: ResizeArray<'T> -> Array<'T * 'T>
        abstract nest: unit -> Nest<'T>
        abstract transform: transform: string -> Transform
        abstract format: specifier: string -> (float -> string)
        abstract formatPrefix: value: float * ?precision: float -> FormatPrefix
        abstract round: x: float * ?n: float -> float
        abstract requote: string: string -> string
        abstract rgb: IExportsRgb
        abstract hsl: IExportsHsl
        abstract hcl: IExportsHcl
        abstract lab: IExportsLab
        abstract color: IExportsColor
        abstract ``functor``: value: 'T -> 'T
        abstract rebind: target: RebindTarget * source: RebindSource * [<ParamArray>] names: ResizeArray<string> -> obj option
        abstract dispatch: [<ParamArray>] names: ResizeArray<string> -> Dispatch
        abstract interpolate: a: float * b: float -> (float -> float)
        abstract interpolate: a: string * b: string -> (float -> string)
        abstract interpolate: a: U2<string, Color> * b: Color -> (float -> string)
        abstract interpolate: a: Array<U2<string, Color>> * b: ResizeArray<Color> -> (float -> string)
        abstract interpolate: a: ResizeArray<'Range> * b: ResizeArray<'Output> -> (float -> ResizeArray<'Output>)
        abstract interpolate: a: ResizeArray<'Range> * b: ResizeArray<'Range> -> (float -> ResizeArray<'Output>)
        abstract interpolate: a: InterpolateA * b: InterpolateB -> (float -> IExportsInterpolate)
        abstract interpolate: a: InterpolateA_ * b: InterpolateB_ -> (float -> IExportsInterpolate2<'Output>)
        abstract interpolate: a: InterpolateA__ * b: InterpolateB__ -> (float -> IExportsInterpolate2<'Output>)
        abstract interpolateNumber: a: float * b: float -> (float -> float)
        abstract interpolateRound: a: float * b: float -> (float -> float)
        abstract interpolateString: a: string * b: string -> (float -> string)
        abstract interpolateRgb: a: U2<string, Color> * b: U2<string, Color> -> (float -> string)
        abstract interpolateHsl: a: U2<string, Color> * b: U2<string, Color> -> (float -> string)
        abstract interpolateLab: a: U2<string, Color> * b: U2<string, Color> -> (float -> string)
        abstract interpolateHcl: a: U2<string, Color> * b: U2<string, Color> -> (float -> string)
        abstract interpolateArray: a: Array<U2<string, Color>> * b: ResizeArray<Color> -> (float -> ResizeArray<string>)
        abstract interpolateArray: a: ResizeArray<'Range> * b: ResizeArray<'Range> -> (float -> ResizeArray<'Output>)
        abstract interpolateArray: a: ResizeArray<'Range> * b: ResizeArray<'Output> -> (float -> ResizeArray<'Output>)
        abstract interpolateObject: a: InterpolateObjectA * b: InterpolateObjectB -> (float -> IExportsInterpolate)
        abstract interpolateObject: a: InterpolateObjectA_ * b: InterpolateObjectB_ -> (float -> IExportsInterpolate2<'Output>)
        abstract interpolateObject: a: InterpolateObjectA__ * b: InterpolateObjectB__ -> (float -> IExportsInterpolate2<'Output>)
        abstract interpolateTransform: a: U2<string, Transform> * b: U2<string, Transform> -> (float -> string)
        abstract interpolateZoom: a: float * float * float * b: float * float * float -> InterpolateZoomReturn
        abstract interpolators: Array<(obj option -> obj option -> (float -> obj option))>
        abstract xhr: url: string * ?mimeType: string * ?callback: (obj option -> obj option -> unit) -> Xhr
        abstract xhr: url: string * callback: (obj option -> obj option -> unit) -> Xhr
        abstract text: url: string * ?mimeType: string * ?callback: (obj option -> string -> unit) -> Xhr
        abstract text: url: string * callback: (obj option -> string -> unit) -> Xhr
        abstract json: url: string * ?callback: (obj option -> obj option -> unit) -> Xhr
        abstract xml: url: string * ?mimeType: string * ?callback: (obj option -> obj option -> unit) -> Xhr
        abstract xml: url: string * callback: (obj option -> obj option -> unit) -> Xhr
        abstract html: url: string * ?callback: (obj option -> DocumentFragment -> unit) -> Xhr
        abstract csv: Dsv
        abstract tsv: Dsv
        abstract dsv: delimiter: string * mimeType: string -> Dsv
        abstract locale: definition: LocaleDefinition -> Locale

    type [<AllowNullLiteral>] BisectorReturn =
        abstract left: (ResizeArray<'T> -> 'U -> float -> float -> float) with get, set
        abstract right: (ResizeArray<'T> -> 'U -> float -> float -> float) with get, set

    type [<AllowNullLiteral>] BisectorReturn_ =
        abstract left: (ResizeArray<'T> -> 'U -> float -> float -> float) with get, set
        abstract right: (ResizeArray<'T> -> 'U -> float -> float -> float) with get, set

    type [<AllowNullLiteral>] ValuesObject =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'T with get, set

    type [<AllowNullLiteral>] ValuesObject_ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> 'T with get, set

    type [<AllowNullLiteral>] EntriesObject =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'T with get, set

    type [<AllowNullLiteral>] EntriesObject_ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> 'T with get, set

    type [<AllowNullLiteral>] MapObject =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'T with get, set

    type [<AllowNullLiteral>] MapObject_ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> 'T with get, set

    type [<AllowNullLiteral>] PermuteArray =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: float -> 'T with get, set

    type [<AllowNullLiteral>] PermuteObject =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'T with get, set

    type [<AllowNullLiteral>] RebindTarget =
        interface end

    type [<AllowNullLiteral>] RebindSource =
        interface end

    type [<AllowNullLiteral>] InterpolateA =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<string, Color> with get, set

    type [<AllowNullLiteral>] InterpolateB =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> Color with get, set

    type [<AllowNullLiteral>] InterpolateA_ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Range with get, set

    type [<AllowNullLiteral>] InterpolateB_ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Output with get, set

    type [<AllowNullLiteral>] InterpolateA__ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Range with get, set

    type [<AllowNullLiteral>] InterpolateB__ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Range with get, set

    type [<AllowNullLiteral>] InterpolateObjectA =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<string, Color> with get, set

    type [<AllowNullLiteral>] InterpolateObjectB =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> Color with get, set

    type [<AllowNullLiteral>] InterpolateObjectA_ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Range with get, set

    type [<AllowNullLiteral>] InterpolateObjectB_ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Output with get, set

    type [<AllowNullLiteral>] InterpolateObjectA__ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Range with get, set

    type [<AllowNullLiteral>] InterpolateObjectB__ =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Range with get, set

    type [<AllowNullLiteral>] InterpolateZoomReturn =
        [<Emit "$0($1...)">] abstract Invoke: t: float -> float * float * float
        abstract duration: float with get, set

    module Selection =

        type [<AllowNullLiteral>] IExports =
            abstract prototype: Selection<obj option>

        /// Selections are grouped into arrays of nodes, with the parent tracked in the 'parentNode' property.
        type [<AllowNullLiteral>] Group =
            inherit Array<EventTarget>
            abstract parentNode: EventTarget with get, set

        type [<AllowNullLiteral>] Update<'Datum> =
            /// Retrieve a grouped selection.
            [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> Group with get, set
            /// The number of groups in this selection.
            abstract length: float with get, set
            /// <summary>Retrieve the value of the given attribute for the first node in the selection.</summary>
            /// <param name="name">The attribute name to query. May be prefixed (see d3.ns.prefix).</param>
            abstract attr: name: string -> string
            /// <summary>For all nodes, set the attribute to the specified constant value. Use null to remove.</summary>
            /// <param name="name">The attribute name, optionally prefixed.</param>
            /// <param name="value">The attribute value to use. Note that this is coerced to a string automatically.</param>
            abstract attr: name: string * value: Primitive -> Update<'Datum>
            /// <summary>Derive an attribute value for each node in the selection based on bound data.</summary>
            /// <param name="name">The attribute name, optionally prefixed.</param>
            /// <param name="value">The function of the datum (the bound data item), index (the position in the subgrouping), and outer index (overall position in nested selections) which computes the attribute value. If the function returns null, the attribute is removed.</param>
            abstract attr: name: string * value: ('Datum -> float -> float -> Primitive) -> Update<'Datum>
            /// <summary>Set multiple properties at once using an Object. D3 iterates over all enumerable properties and either sets or computes the attribute's value based on the corresponding entry in the Object.</summary>
            /// <param name="obj">A key-value mapping corresponding to attributes and values. If the value is a simple string or number, it is taken as a constant. Otherwise, it is a function that derives the attribute value.</param>
            abstract attr: obj: UpdateAttrObj -> Update<'Datum>
            /// <summary>Returns true if the first node in this selection has the given class list. If multiple classes are specified (i.e., "foo bar"), then returns true only if all classes match.</summary>
            /// <param name="name">The class list to query.</param>
            abstract classed: name: string -> bool
            /// <summary>Adds (or removes) the given class list.</summary>
            /// <param name="name">The class list to toggle. Spaces separate class names: "foo bar" is a list of two classes.</param>
            /// <param name="value">If true, add the classes. If false, remove them.</param>
            abstract classed: name: string * value: bool -> Update<'Datum>
            /// <summary>Determine if the given class list should be toggled for each node in the selection.</summary>
            /// <param name="name">The class list. Spaces separate multiple class names.</param>
            /// <param name="value">The function to run for each node. Should return true to add the class to the node, or false to remove it.</param>
            abstract classed: name: string * value: ('Datum -> float -> float -> bool) -> Update<'Datum>
            /// <summary>Set or derive classes for multiple class lists at once.</summary>
            /// <param name="obj">An Object mapping class lists to values that are either plain booleans or functions that return booleans.</param>
            abstract classed: obj: UpdateClassedObj -> Update<'Datum>
            /// <summary>Retrieve the computed style value for the first node in the selection.</summary>
            /// <param name="name">The CSS property name to query</param>
            abstract style: name: string -> string
            /// <summary>Set a style property for all nodes in the selection.</summary>
            /// <param name="name">the CSS property name</param>
            /// <param name="value">the property value</param>
            /// <param name="priority">if specified, either null or the string "important" (no exclamation mark)</param>
            abstract style: name: string * value: Primitive * ?priority: string -> Update<'Datum>
            /// <summary>Derive a property value for each node in the selection.</summary>
            /// <param name="name">the CSS property name</param>
            /// <param name="value">the function to derive the value</param>
            /// <param name="priority">if specified, either null or the string "important" (no exclamation mark)</param>
            abstract style: name: string * value: ('Datum -> float -> float -> Primitive) * ?priority: string -> Update<'Datum>
            /// <summary>Set a large number of CSS properties from an object.</summary>
            /// <param name="obj">an Object whose keys correspond to CSS property names and values are either constants or functions that derive property values</param>
            /// <param name="priority">if specified, either null or the string "important" (no exclamation mark)</param>
            abstract style: obj: UpdateStyleObj * ?priority: string -> Update<'Datum>
            /// <summary>Retrieve an arbitrary node property such as the 'checked' property of checkboxes, or the 'value' of text boxes.</summary>
            /// <param name="name">the node's property to retrieve</param>
            abstract property: name: string -> obj option
            /// <summary>For each node, set the property value. Internally, this sets the node property directly (e.g., node[name] = value), so take care not to mutate special properties like __proto__.</summary>
            /// <param name="name">the property name</param>
            /// <param name="value">the property value</param>
            abstract property: name: string * value: obj option -> Update<'Datum>
            /// <summary>For each node, derive the property value. Internally, this sets the node property directly (e.g., node[name] = value), so take care not to mutate special properties like __proto__.</summary>
            /// <param name="name">the property name</param>
            /// <param name="value">the function used to derive the property's value</param>
            abstract property: name: string * value: ('Datum -> float -> float -> obj option) -> Update<'Datum>
            /// <summary>Set multiple node properties. Caveats apply: take care not to mutate special properties like __proto__.</summary>
            /// <param name="obj">an Object whose keys correspond to node properties and values are either constants or functions that will compute a value.</param>
            abstract property: obj: UpdatePropertyObj -> Update<'Datum>
            /// Retrieve the textContent of the first node in the selection.
            abstract text: unit -> string
            /// <summary>Set the textContent of each node in the selection.</summary>
            /// <param name="value">the text to use for all nodes</param>
            abstract text: value: Primitive -> Update<'Datum>
            /// <summary>Compute the textContent of each node in the selection.</summary>
            /// <param name="value">the function which will compute the text</param>
            abstract text: value: ('Datum -> float -> float -> Primitive) -> Update<'Datum>
            /// Retrieve the HTML content of the first node in the selection. Uses 'innerHTML' internally and will not work with SVG or other elements without a polyfill.
            abstract html: unit -> string
            /// <summary>Set the HTML content of every node in the selection. Uses 'innerHTML' internally and thus will not work with SVG or other elements without a polyfill.</summary>
            /// <param name="value">the HTML content to use.</param>
            abstract html: value: string -> Selection<'Datum>
            /// <summary>Compute the HTML content for each node in the selection. Uses 'innerHTML' internally and thus will not work with SVG or other elements without a polyfill.</summary>
            /// <param name="value">the function to compute HTML content</param>
            abstract html: value: ('Datum -> float -> float -> string) -> Selection<'Datum>
            /// <summary>Appends a new child to each node in the selection. This child will inherit the parent's data (if available). Returns a fresh selection consisting of the newly-appended children.</summary>
            /// <param name="name">the element name to append. May be prefixed (see d3.ns.prefix).</param>
            abstract append: name: string -> Selection<'Datum>
            /// <summary>Appends a new child to each node in the selection by computing a new node. This child will inherit the parent's data (if available). Returns a fresh selection consisting of the newly-appended children.</summary>
            /// <param name="name">the function to compute a new element</param>
            abstract append: name: ('Datum -> float -> float -> EventTarget) -> Update<'Datum>
            /// <summary>Inserts a new child to each node in the selection. This child will inherit its parent's data (if available). Returns a fresh selection consisting of the newly-inserted children.</summary>
            /// <param name="name">the element name to append. May be prefixed (see d3.ns.prefix).</param>
            /// <param name="before">the selector to determine position (e.g., ":first-child")</param>
            abstract insert: name: string * ?before: string -> Update<'Datum>
            /// <summary>Inserts a new child to each node in the selection. This child will inherit its parent's data (if available). Returns a fresh selection consisting of the newly-inserted children.</summary>
            /// <param name="name">the element name to append. May be prefixed (see d3.ns.prefix).</param>
            /// <param name="before">a function to determine the node to use as the next sibling</param>
            abstract insert: name: string * ?before: ('Datum -> float -> float -> EventTarget) -> Update<'Datum>
            /// <summary>Inserts a new child to the end of each node in the selection by computing a new node. This child will inherit its parent's data (if available). Returns a fresh selection consisting of the newly-inserted children.</summary>
            /// <param name="name">the function to compute a new child</param>
            /// <param name="before">the selector to determine position (e.g., ":first-child")</param>
            abstract insert: name: ('Datum -> float -> float -> EventTarget) * ?before: string -> Update<'Datum>
            /// <summary>Inserts a new child to the end of each node in the selection by computing a new node. This child will inherit its parent's data (if available). Returns a fresh selection consisting of the newly-inserted children.</summary>
            /// <param name="name">the function to compute a new child</param>
            /// <param name="before">a function to determine the node to use as the next sibling</param>
            abstract insert: name: ('Datum -> float -> float -> EventTarget) * ?before: ('Datum -> float -> float -> EventTarget) -> Update<'Datum>
            /// Removes the elements from the DOM. They are in a detached state and may be re-added (though there is currently no dedicated API for doing so).
            abstract remove: unit -> Update<'Datum>
            /// Retrieves the data bound to the first group in this selection.
            abstract data: unit -> ResizeArray<'Datum>
            /// <summary>Binds data to this selection.</summary>
            /// <param name="data">the array of data to bind to this selection</param>
            /// <param name="key">the optional function to determine the unique key for each piece of data. When unspecified, uses the index of the element.</param>
            abstract data: data: ResizeArray<'NewDatum> * ?key: ('NewDatum -> float -> float -> string) -> Update<'NewDatum>
            /// <summary>Derives data to bind to this selection.</summary>
            /// <param name="data">the function to derive data. Must return an array.</param>
            /// <param name="key">the optional function to determine the unique key for each data item. When unspecified, uses the index of the element.</param>
            abstract data: data: ('Datum -> float -> float -> ResizeArray<'NewDatum>) * ?key: ('NewDatum -> float -> float -> string) -> Update<'NewDatum>
            /// <summary>Filters the selection, returning only those nodes that match the given CSS selector.</summary>
            /// <param name="selector">the CSS selector</param>
            abstract filter: selector: string -> Update<'Datum>
            /// <summary>Filters the selection, returning only those nodes for which the given function returned true.</summary>
            /// <param name="selector">the filter function</param>
            abstract filter: selector: ('Datum -> float -> float -> bool) -> Update<'Datum>
            /// Return the data item bound to the first element in the selection.
            abstract datum: unit -> 'Datum
            /// <summary>Derive the data item for each node in the selection. Useful for situations such as the HTML5 'dataset' attribute.</summary>
            /// <param name="value">the function to compute data for each node</param>
            abstract datum: value: ('Datum -> float -> float -> 'NewDatum) -> Update<'NewDatum>
            /// <summary>Set the data item for each node in the selection.</summary>
            /// <param name="value">the constant element to use for each node</param>
            abstract datum: value: 'NewDatum -> Update<'NewDatum>
            /// <summary>Reorders nodes in the selection based on the given comparator. Nodes are re-inserted into the document once sorted.</summary>
            /// <param name="comparator">the comparison function, which defaults to d3.ascending</param>
            abstract sort: ?comparator: ('Datum -> 'Datum -> float) -> Update<'Datum>
            /// Reorders nodes in the document to match the selection order. More efficient than calling sort() if the selection is already ordered.
            abstract order: unit -> Update<'Datum>
            /// <summary>Returns the listener (if any) for the given event.</summary>
            /// <param name="type">the type of event to load the listener for. May have a namespace (e.g., ".foo") at the end.</param>
            abstract on: ``type``: string -> ('Datum -> float -> float -> obj option)
            /// <summary>Adds a listener for the specified event. If one was already registered, it is removed before the new listener is added. The return value of the listener function is ignored.</summary>
            /// <param name="type">the of event to listen to. May have a namespace (e.g., ".foo") at the end.</param>
            /// <param name="listener">an event listener function, or null to unregister</param>
            /// <param name="capture">sets the DOM useCapture flag</param>
            abstract on: ``type``: string * listener: ('Datum -> float -> float -> obj option) * ?capture: bool -> Update<'Datum>
            /// <summary>Begins a new transition. Interrupts any active transitions of the same name.</summary>
            /// <param name="name">the transition name (defaults to "")</param>
            abstract transition: ?name: string -> Transition<'Datum>
            /// <summary>Interrupts the active transition of the provided name. Does not cancel scheduled transitions.</summary>
            /// <param name="name">the transition name (defaults to "")</param>
            abstract interrupt: ?name: string -> Update<'Datum>
            /// <summary>Creates a subselection by finding the first descendent matching the selector string. Bound data is inherited.</summary>
            /// <param name="selector">the CSS selector to match against</param>
            abstract select: selector: string -> Update<'Datum>
            /// <summary>Creates a subselection by using a function to find descendent elements. Bound data is inherited.</summary>
            /// <param name="selector">the function to find matching descendants</param>
            abstract select: selector: ('Datum -> float -> float -> EventTarget) -> Update<'Datum>
            /// <summary>Creates a subselection by finding all descendents that match the given selector. Bound data is not inherited.</summary>
            /// <param name="selector">the CSS selector to match against</param>
            abstract selectAll: selector: string -> Update<'Datum>
            /// <summary>Creates a subselection by using a function to find descendent elements. Bound data is not inherited.</summary>
            /// <param name="selector">the function to find matching descendents</param>
            abstract selectAll: selector: ('Datum -> float -> float -> U2<Array<EventTarget>, NodeList>) -> Update<obj option>
            /// <summary>Invoke the given function for each element in the selection. The return value of the function is ignored.</summary>
            /// <param name="func">the function to invoke</param>
            abstract each: func: ('Datum -> float -> float -> obj option) -> Update<'Datum>
            /// <summary>Call a function on the selection. sel.call(foo) is equivalent to foo(sel).</summary>
            /// <param name="func">the function to call on the selection</param>
            /// <param name="args">any optional args</param>
            abstract call: func: (Update<'Datum> -> ResizeArray<obj option> -> obj option) * [<ParamArray>] args: ResizeArray<obj option> -> Update<'Datum>
            /// Returns true if the current selection is empty.
            abstract empty: unit -> bool
            /// Returns the first non-null element in the selection, or null otherwise.
            abstract node: unit -> Node
            /// Returns the total number of elements in the selection.
            abstract size: unit -> float
            /// Returns the placeholder nodes for each data element for which no corresponding DOM element was found.
            abstract enter: unit -> Enter<'Datum>
            /// Returns a selection for those DOM nodes for which no new data element was found.
            abstract exit: unit -> Selection<'Datum>

        type [<AllowNullLiteral>] UpdateAttrObj =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<Primitive, ('Datum -> float -> float -> Primitive)> with get, set

        type [<AllowNullLiteral>] UpdateClassedObj =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<bool, ('Datum -> float -> float -> bool)> with get, set

        type [<AllowNullLiteral>] UpdateStyleObj =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<Primitive, ('Datum -> float -> float -> Primitive)> with get, set

        type [<AllowNullLiteral>] UpdatePropertyObj =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<obj option, ('Datum -> float -> float -> obj option)> with get, set

        type [<AllowNullLiteral>] Enter<'Datum> =
            abstract append: name: string -> Selection<'Datum>
            abstract append: name: ('Datum -> float -> float -> EventTarget) -> Selection<'Datum>
            abstract insert: name: string * ?before: string -> Selection<'Datum>
            abstract insert: name: string * before: ('Datum -> float -> float -> EventTarget) -> Selection<'Datum>
            abstract insert: name: ('Datum -> float -> float -> EventTarget) * ?before: string -> Selection<'Datum>
            abstract insert: name: ('Datum -> float -> float -> EventTarget) * before: ('Datum -> float -> float -> EventTarget) -> Selection<'Datum>
            abstract select: name: ('Datum -> float -> float -> EventTarget) -> Selection<'Datum>
            abstract call: func: (Enter<'Datum> -> ResizeArray<obj option> -> obj option) * [<ParamArray>] args: ResizeArray<obj option> -> Enter<'Datum>
            abstract empty: unit -> bool
            abstract size: unit -> float

    type Primitive =
        U3<float, string, bool>

    /// Administrivia: anything with a valueOf(): number method is comparable, so we allow it in numeric operations
    type [<AllowNullLiteral>] Numeric =
        abstract valueOf: unit -> float

    /// A grouped array of nodes.
    type [<AllowNullLiteral>] Selection<'Datum> =
        /// Retrieve a grouped selection.
        [<Emit "$0[$1]{{=$2}}">] abstract Item: index: float -> Selection.Group with get, set
        /// The number of groups in this selection.
        abstract length: float with get, set
        /// <summary>Retrieve the value of the given attribute for the first node in the selection.</summary>
        /// <param name="name">The attribute name to query. May be prefixed (see d3.ns.prefix).</param>
        abstract attr: name: string -> string
        /// <summary>For all nodes, set the attribute to the specified constant value. Use null to remove.</summary>
        /// <param name="name">The attribute name, optionally prefixed.</param>
        /// <param name="value">The attribute value to use. Note that this is coerced to a string automatically.</param>
        abstract attr: name: string * value: Primitive -> Selection<'Datum>
        /// <summary>Derive an attribute value for each node in the selection based on bound data.</summary>
        /// <param name="name">The attribute name, optionally prefixed.</param>
        /// <param name="value">The function of the datum (the bound data item), index (the position in the subgrouping), and outer index (overall position in nested selections) which computes the attribute value. If the function returns null, the attribute is removed.</param>
        abstract attr: name: string * value: ('Datum -> float -> float -> Primitive) -> Selection<'Datum>
        /// <summary>Set multiple properties at once using an Object. D3 iterates over all enumerable properties and either sets or computes the attribute's value based on the corresponding entry in the Object.</summary>
        /// <param name="obj">A key-value mapping corresponding to attributes and values. If the value is a simple string or number, it is taken as a constant. Otherwise, it is a function that derives the attribute value.</param>
        abstract attr: obj: SelectionAttrObj -> Selection<'Datum>
        /// <summary>Returns true if the first node in this selection has the given class list. If multiple classes are specified (i.e., "foo bar"), then returns true only if all classes match.</summary>
        /// <param name="name">The class list to query.</param>
        abstract classed: name: string -> bool
        /// <summary>Adds (or removes) the given class list.</summary>
        /// <param name="name">The class list to toggle. Spaces separate class names: "foo bar" is a list of two classes.</param>
        /// <param name="value">If true, add the classes. If false, remove them.</param>
        abstract classed: name: string * value: bool -> Selection<'Datum>
        /// <summary>Determine if the given class list should be toggled for each node in the selection.</summary>
        /// <param name="name">The class list. Spaces separate multiple class names.</param>
        /// <param name="value">The function to run for each node. Should return true to add the class to the node, or false to remove it.</param>
        abstract classed: name: string * value: ('Datum -> float -> float -> bool) -> Selection<'Datum>
        /// <summary>Set or derive classes for multiple class lists at once.</summary>
        /// <param name="obj">An Object mapping class lists to values that are either plain booleans or functions that return booleans.</param>
        abstract classed: obj: SelectionClassedObj -> Selection<'Datum>
        /// <summary>Retrieve the computed style value for the first node in the selection.</summary>
        /// <param name="name">The CSS property name to query</param>
        abstract style: name: string -> string
        /// <summary>Set a style property for all nodes in the selection.</summary>
        /// <param name="name">the CSS property name</param>
        /// <param name="value">the property value</param>
        /// <param name="priority">if specified, either null or the string "important" (no exclamation mark)</param>
        abstract style: name: string * value: Primitive * ?priority: string -> Selection<'Datum>
        /// <summary>Derive a property value for each node in the selection.</summary>
        /// <param name="name">the CSS property name</param>
        /// <param name="value">the function to derive the value</param>
        /// <param name="priority">if specified, either null or the string "important" (no exclamation mark)</param>
        abstract style: name: string * value: ('Datum -> float -> float -> Primitive) * ?priority: string -> Selection<'Datum>
        /// <summary>Set a large number of CSS properties from an object.</summary>
        /// <param name="obj">an Object whose keys correspond to CSS property names and values are either constants or functions that derive property values</param>
        /// <param name="priority">if specified, either null or the string "important" (no exclamation mark)</param>
        abstract style: obj: SelectionStyleObj * ?priority: string -> Selection<'Datum>
        /// <summary>Retrieve an arbitrary node property such as the 'checked' property of checkboxes, or the 'value' of text boxes.</summary>
        /// <param name="name">the node's property to retrieve</param>
        abstract property: name: string -> obj option
        /// <summary>For each node, set the property value. Internally, this sets the node property directly (e.g., node[name] = value), so take care not to mutate special properties like __proto__.</summary>
        /// <param name="name">the property name</param>
        /// <param name="value">the property value</param>
        abstract property: name: string * value: obj option -> Selection<'Datum>
        /// <summary>For each node, derive the property value. Internally, this sets the node property directly (e.g., node[name] = value), so take care not to mutate special properties like __proto__.</summary>
        /// <param name="name">the property name</param>
        /// <param name="value">the function used to derive the property's value</param>
        abstract property: name: string * value: ('Datum -> float -> float -> obj option) -> Selection<'Datum>
        /// <summary>Set multiple node properties. Caveats apply: take care not to mutate special properties like __proto__.</summary>
        /// <param name="obj">an Object whose keys correspond to node properties and values are either constants or functions that will compute a value.</param>
        abstract property: obj: SelectionPropertyObj -> Selection<'Datum>
        /// Retrieve the textContent of the first node in the selection.
        abstract text: unit -> string
        /// <summary>Set the textContent of each node in the selection.</summary>
        /// <param name="value">the text to use for all nodes</param>
        abstract text: value: Primitive -> Selection<'Datum>
        /// <summary>Compute the textContent of each node in the selection.</summary>
        /// <param name="value">the function which will compute the text</param>
        abstract text: value: ('Datum -> float -> float -> Primitive) -> Selection<'Datum>
        /// Retrieve the HTML content of the first node in the selection. Uses 'innerHTML' internally and will not work with SVG or other elements without a polyfill.
        abstract html: unit -> string
        /// <summary>Set the HTML content of every node in the selection. Uses 'innerHTML' internally and thus will not work with SVG or other elements without a polyfill.</summary>
        /// <param name="value">the HTML content to use.</param>
        abstract html: value: string -> Selection<'Datum>
        /// <summary>Compute the HTML content for each node in the selection. Uses 'innerHTML' internally and thus will not work with SVG or other elements without a polyfill.</summary>
        /// <param name="value">the function to compute HTML content</param>
        abstract html: value: ('Datum -> float -> float -> string) -> Selection<'Datum>
        /// <summary>Appends a new child to each node in the selection. This child will inherit the parent's data (if available). Returns a fresh selection consisting of the newly-appended children.</summary>
        /// <param name="name">the element name to append. May be prefixed (see d3.ns.prefix).</param>
        abstract append: name: string -> Selection<'Datum>
        /// <summary>Appends a new child to each node in the selection by computing a new node. This child will inherit the parent's data (if available). Returns a fresh selection consisting of the newly-appended children.</summary>
        /// <param name="name">the function to compute a new element</param>
        abstract append: name: ('Datum -> float -> float -> EventTarget) -> Selection<'Datum>
        /// <summary>Inserts a new child to each node in the selection. This child will inherit its parent's data (if available). Returns a fresh selection consisting of the newly-inserted children.</summary>
        /// <param name="name">the element name to append. May be prefixed (see d3.ns.prefix).</param>
        /// <param name="before">the selector to determine position (e.g., ":first-child")</param>
        abstract insert: name: string * ?before: string -> Selection<'Datum>
        /// <summary>Inserts a new child to each node in the selection. This child will inherit its parent's data (if available). Returns a fresh selection consisting of the newly-inserted children.</summary>
        /// <param name="name">the element name to append. May be prefixed (see d3.ns.prefix).</param>
        /// <param name="before">a function to determine the node to use as the next sibling</param>
        abstract insert: name: string * ?before: ('Datum -> float -> float -> EventTarget) -> Selection<'Datum>
        /// <summary>Inserts a new child to the end of each node in the selection by computing a new node. This child will inherit its parent's data (if available). Returns a fresh selection consisting of the newly-inserted children.</summary>
        /// <param name="name">the function to compute a new child</param>
        /// <param name="before">the selector to determine position (e.g., ":first-child")</param>
        abstract insert: name: ('Datum -> float -> float -> EventTarget) * ?before: string -> Selection<'Datum>
        /// <summary>Inserts a new child to the end of each node in the selection by computing a new node. This child will inherit its parent's data (if available). Returns a fresh selection consisting of the newly-inserted children.</summary>
        /// <param name="name">the function to compute a new child</param>
        /// <param name="before">a function to determine the node to use as the next sibling</param>
        abstract insert: name: ('Datum -> float -> float -> EventTarget) * ?before: ('Datum -> float -> float -> EventTarget) -> Selection<'Datum>
        /// Removes the elements from the DOM. They are in a detached state and may be re-added (though there is currently no dedicated API for doing so).
        abstract remove: unit -> Selection<'Datum>
        /// Retrieves the data bound to the first group in this selection.
        abstract data: unit -> ResizeArray<'Datum>
        /// <summary>Binds data to this selection.</summary>
        /// <param name="data">the array of data to bind to this selection</param>
        /// <param name="key">the optional function to determine the unique key for each piece of data. When unspecified, uses the index of the element.</param>
        abstract data: data: ResizeArray<'NewDatum> * ?key: ('NewDatum -> float -> float -> string) -> Selection.Update<'NewDatum>
        /// <summary>Derives data to bind to this selection.</summary>
        /// <param name="data">the function to derive data. Must return an array.</param>
        /// <param name="key">the optional function to determine the unique key for each data item. When unspecified, uses the index of the element.</param>
        abstract data: data: ('Datum -> float -> float -> ResizeArray<'NewDatum>) * ?key: ('NewDatum -> float -> float -> string) -> Selection.Update<'NewDatum>
        /// <summary>Filters the selection, returning only those nodes that match the given CSS selector.</summary>
        /// <param name="selector">the CSS selector</param>
        abstract filter: selector: string -> Selection<'Datum>
        /// <summary>Filters the selection, returning only those nodes for which the given function returned true.</summary>
        /// <param name="selector">the filter function</param>
        abstract filter: selector: ('Datum -> float -> float -> bool) -> Selection<'Datum>
        /// Return the data item bound to the first element in the selection.
        abstract datum: unit -> 'Datum
        /// <summary>Derive the data item for each node in the selection. Useful for situations such as the HTML5 'dataset' attribute.</summary>
        /// <param name="value">the function to compute data for each node</param>
        abstract datum: value: ('Datum -> float -> float -> 'NewDatum) -> Selection<'NewDatum>
        /// <summary>Set the data item for each node in the selection.</summary>
        /// <param name="value">the constant element to use for each node</param>
        abstract datum: value: 'NewDatum -> Selection<'NewDatum>
        /// <summary>Reorders nodes in the selection based on the given comparator. Nodes are re-inserted into the document once sorted.</summary>
        /// <param name="comparator">the comparison function, which defaults to d3.ascending</param>
        abstract sort: ?comparator: ('Datum -> 'Datum -> float) -> Selection<'Datum>
        /// Reorders nodes in the document to match the selection order. More efficient than calling sort() if the selection is already ordered.
        abstract order: unit -> Selection<'Datum>
        /// <summary>Returns the listener (if any) for the given event.</summary>
        /// <param name="type">the type of event to load the listener for. May have a namespace (e.g., ".foo") at the end.</param>
        abstract on: ``type``: string -> ('Datum -> float -> float -> obj option)
        /// <summary>Adds a listener for the specified event. If one was already registered, it is removed before the new listener is added. The return value of the listener function is ignored.</summary>
        /// <param name="type">the of event to listen to. May have a namespace (e.g., ".foo") at the end.</param>
        /// <param name="listener">an event listener function, or null to unregister</param>
        /// <param name="capture">sets the DOM useCapture flag</param>
        abstract on: ``type``: string * listener: ('Datum -> float -> float -> obj option) * ?capture: bool -> Selection<'Datum>
        /// <summary>Begins a new transition. Interrupts any active transitions of the same name.</summary>
        /// <param name="name">the transition name (defaults to "")</param>
        abstract transition: ?name: string -> Transition<'Datum>
        /// <summary>Interrupts the active transition of the provided name. Does not cancel scheduled transitions.</summary>
        /// <param name="name">the transition name (defaults to "")</param>
        abstract interrupt: ?name: string -> Selection<'Datum>
        /// <summary>Creates a subselection by finding the first descendent matching the selector string. Bound data is inherited.</summary>
        /// <param name="selector">the CSS selector to match against</param>
        abstract select: selector: string -> Selection<'Datum>
        /// <summary>Creates a subselection by using a function to find descendent elements. Bound data is inherited.</summary>
        /// <param name="selector">the function to find matching descendants</param>
        abstract select: selector: ('Datum -> float -> float -> EventTarget) -> Selection<'Datum>
        /// <summary>Creates a subselection by finding all descendents that match the given selector. Bound data is not inherited.</summary>
        /// <param name="selector">the CSS selector to match against</param>
        abstract selectAll: selector: string -> Selection<obj option>
        /// Creates a subselection by finding all descendants that match the given selector. Bound data is not inherited.
        ///
        /// Use this overload when data-binding a subselection (that is, sel.selectAll('.foo').data(d => ...)). The type will carry over.
        abstract selectAll: selector: string -> Selection<'T>
        /// <summary>Creates a subselection by using a function to find descendent elements. Bound data is not inherited.</summary>
        /// <param name="selector">the function to find matching descendents</param>
        abstract selectAll: selector: ('Datum -> float -> float -> U2<Array<EventTarget>, NodeList>) -> Selection<obj option>
        /// <summary>Creates a subselection by using a function to find descendent elements. Bound data is not inherited.
        ///
        /// Use this overload when data-binding a subselection (that is, sel.selectAll('.foo').data(d => ...)). The type will carry over.</summary>
        /// <param name="selector">the function to find matching descendents</param>
        abstract selectAll: selector: ('Datum -> float -> float -> U2<Array<EventTarget>, NodeList>) -> Selection<'T>
        /// <summary>Invoke the given function for each element in the selection. The return value of the function is ignored.</summary>
        /// <param name="func">the function to invoke</param>
        abstract each: func: ('Datum -> float -> float -> obj option) -> Selection<'Datum>
        /// <summary>Call a function on the selection. sel.call(foo) is equivalent to foo(sel).</summary>
        /// <param name="func">the function to call on the selection</param>
        /// <param name="args">any optional args</param>
        abstract call: func: (Selection<'Datum> -> ResizeArray<obj option> -> obj option) * [<ParamArray>] args: ResizeArray<obj option> -> Selection<'Datum>
        /// Returns true if the current selection is empty.
        abstract empty: unit -> bool
        /// Returns the first non-null element in the selection, or null otherwise.
        abstract node: unit -> Node
        /// Returns the total number of elements in the selection.
        abstract size: unit -> float

    type [<AllowNullLiteral>] SelectionAttrObj =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<Primitive, ('Datum -> float -> float -> Primitive)> with get, set

    type [<AllowNullLiteral>] SelectionClassedObj =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<bool, ('Datum -> float -> float -> bool)> with get, set

    type [<AllowNullLiteral>] SelectionStyleObj =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<Primitive, ('Datum -> float -> float -> Primitive)> with get, set

    type [<AllowNullLiteral>] SelectionPropertyObj =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<obj option, ('Datum -> float -> float -> obj option)> with get, set

    module Transition =

        type [<AllowNullLiteral>] IExports =
            abstract prototype: Transition<obj option>

    type [<AllowNullLiteral>] Transition<'Datum> =
        abstract transition: unit -> Transition<'Datum>
        abstract delay: unit -> float
        abstract delay: delay: float -> Transition<'Datum>
        abstract delay: delay: ('Datum -> float -> float -> float) -> Transition<'Datum>
        abstract duration: unit -> float
        abstract duration: duration: float -> Transition<'Datum>
        abstract duration: duration: ('Datum -> float -> float -> float) -> Transition<'Datum>
        abstract ease: unit -> (float -> float)
        abstract ease: value: string * [<ParamArray>] args: ResizeArray<obj option> -> Transition<'Datum>
        abstract ease: value: (float -> float) -> Transition<'Datum>
        abstract attr: name: string * value: Primitive -> Transition<'Datum>
        abstract attr: name: string * value: ('Datum -> float -> float -> Primitive) -> Transition<'Datum>
        abstract attr: obj: TransitionAttrObj -> Transition<'Datum>
        abstract attrTween: name: string * tween: ('Datum -> float -> string -> (float -> Primitive)) -> Transition<'Datum>
        abstract style: name: string * value: Primitive * ?priority: string -> Transition<'Datum>
        abstract style: name: string * value: ('Datum -> float -> float -> Primitive) * ?priority: string -> Transition<'Datum>
        abstract style: obj: TransitionStyleObj * ?priority: string -> Transition<'Datum>
        abstract styleTween: name: string * tween: ('Datum -> float -> string -> (float -> Primitive)) * ?priority: string -> Transition<'Datum>
        abstract text: value: Primitive -> Transition<'Datum>
        abstract text: value: ('Datum -> float -> float -> Primitive) -> Transition<'Datum>
        abstract tween: name: string * factory: (unit -> (float -> obj option)) -> Transition<'Datum>
        abstract remove: unit -> Transition<'Datum>
        abstract select: selector: string -> Transition<'Datum>
        abstract select: selector: ('Datum -> float -> EventTarget) -> Transition<'Datum>
        abstract selectAll: selector: string -> Transition<obj option>
        abstract selectAll: selector: ('Datum -> float -> ResizeArray<EventTarget>) -> Transition<obj option>
        abstract filter: selector: string -> Transition<'Datum>
        abstract filter: selector: ('Datum -> float -> bool) -> Transition<'Datum>
        abstract each: ``type``: string * listener: ('Datum -> float -> obj option) -> Transition<'Datum>
        abstract each: listener: ('Datum -> float -> obj option) -> Transition<'Datum>
        abstract call: func: (Transition<'Datum> -> ResizeArray<obj option> -> obj option) * [<ParamArray>] args: ResizeArray<obj option> -> Transition<'Datum>
        abstract empty: unit -> bool
        abstract node: unit -> Node
        abstract size: unit -> float

    type [<AllowNullLiteral>] TransitionAttrObj =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<Primitive, ('Datum -> float -> float -> Primitive)> with get, set

    type [<AllowNullLiteral>] TransitionStyleObj =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> U2<Primitive, ('Datum -> float -> float -> Primitive)> with get, set

    module Timer =

        type [<AllowNullLiteral>] IExports =
            abstract flush: unit -> unit

    type [<AllowNullLiteral>] BaseEvent =
        abstract ``type``: string with get, set
        abstract sourceEvent: Event option with get, set

    /// Define a D3-specific ZoomEvent per https://github.com/mbostock/d3/wiki/Zoom-Behavior#event
    type [<AllowNullLiteral>] ZoomEvent =
        inherit BaseEvent
        abstract scale: float with get, set
        abstract translate: float * float with get, set

    /// Define a D3-specific DragEvent per https://github.com/mbostock/d3/wiki/Drag-Behavior#on
    type [<AllowNullLiteral>] DragEvent =
        inherit BaseEvent
        abstract x: float with get, set
        abstract y: float with get, set
        abstract dx: float with get, set
        abstract dy: float with get, set

    /// A shim for ES6 maps. The implementation uses a JavaScript object internally, and thus keys are limited to strings.
    type [<AllowNullLiteral>] Map<'T> =
        /// Does the map contain the given key?
        abstract has: key: string -> bool
        /// Retrieve the value for the given key. Returns undefined if there is no value stored.
        abstract get: key: string -> 'T
        /// Set the value for the given key. Returns the new value.
        abstract set: key: string * value: 'T -> 'T
        /// Remove the value for the given key. Returns true if there was a value and false otherwise.
        abstract remove: key: string -> bool
        /// Returns an array of all keys in arbitrary order.
        abstract keys: unit -> ResizeArray<string>
        /// Returns an array of all values in arbitrary order.
        abstract values: unit -> ResizeArray<'T>
        /// Returns an array of key-value objects in arbitrary order.
        abstract entries: unit -> ResizeArray<IExportsEntries<'T>>
        /// Calls the function for each key and value pair in the map. The 'this' context is the map itself.
        abstract forEach: func: (string -> 'T -> obj option) -> unit
        /// Is this map empty?
        abstract empty: unit -> bool
        /// Returns the number of elements stored in the map.
        abstract size: unit -> float

    /// A shim for ES6 sets. Is only able to store strings.
    type [<AllowNullLiteral>] Set =
        /// Is the given string stored in this set?
        abstract has: value: string -> bool
        /// Add the string to this set. Returns the value.
        abstract add: value: string -> string
        /// Remove the given value from the set. Returns true if it was stored, and false otherwise.
        abstract remove: value: string -> bool
        /// Returns an array of the strings stored in this set.
        abstract values: unit -> ResizeArray<string>
        /// Calls a given function for each value in the set. The return value of the function is ignored. The this context of the function is the set itself.
        abstract forEach: func: (string -> obj option) -> unit
        /// Is this set empty?
        abstract empty: unit -> bool
        /// Returns the number of values stored in this set.
        abstract size: unit -> float

    type [<AllowNullLiteral>] Nest<'T> =
        abstract key: func: ('T -> string) -> Nest<'T>
        abstract sortKeys: comparator: (string -> string -> float) -> Nest<'T>
        abstract sortValues: comparator: ('T -> 'T -> float) -> Nest<'T>
        abstract rollup: func: (ResizeArray<'T> -> 'U) -> Nest<'T>
        abstract map: array: ResizeArray<'T> -> NestMapReturn
        abstract map: array: ResizeArray<'T> * mapType: obj -> Map<obj option>
        abstract entries: array: ResizeArray<'T> -> ResizeArray<NestEntries>

    type [<AllowNullLiteral>] NestMapReturn =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj option with get, set

    module Random =

        type [<AllowNullLiteral>] IExports =
            abstract normal: ?mean: float * ?deviation: float -> (unit -> float)
            abstract logNormal: ?mean: float * ?deviation: float -> (unit -> float)
            abstract bates: count: float -> (unit -> float)
            abstract irwinHall: count: float -> (unit -> float)

    type [<AllowNullLiteral>] Transform =
        abstract rotate: float with get, set
        abstract translate: float * float with get, set
        abstract skew: float with get, set
        abstract scale: float * float with get, set
        abstract toString: unit -> string

    type [<AllowNullLiteral>] FormatPrefix =
        abstract symbol: string with get, set
        abstract scale: n: float -> float

    type [<AllowNullLiteral>] Rgb =
        inherit Color
        abstract r: float with get, set
        abstract g: float with get, set
        abstract b: float with get, set
        abstract brighter: ?k: float -> Rgb
        abstract darker: ?k: float -> Rgb
        abstract hsl: unit -> Hsl
        abstract toString: unit -> string

    type [<AllowNullLiteral>] Hsl =
        inherit Color
        abstract h: float with get, set
        abstract s: float with get, set
        abstract l: float with get, set
        abstract brighter: ?k: float -> Hsl
        abstract darker: ?k: float -> Hsl
        abstract rgb: unit -> Rgb
        abstract toString: unit -> string

    type [<AllowNullLiteral>] Hcl =
        inherit Color
        abstract h: float with get, set
        abstract c: float with get, set
        abstract l: float with get, set
        abstract brighter: ?k: float -> Hcl
        abstract darker: ?k: float -> Hcl

    type [<AllowNullLiteral>] Lab =
        inherit Color
        abstract l: float with get, set
        abstract a: float with get, set
        abstract b: float with get, set
        abstract brighter: ?k: float -> Lab
        abstract darker: ?k: float -> Lab
        abstract rgb: unit -> Rgb
        abstract toString: unit -> string

    type [<AllowNullLiteral>] Color =
        abstract rgb: unit -> Rgb

    module Ns =

        type [<AllowNullLiteral>] IExports =
            abstract prefix: IExportsPrefix
            abstract qualify: name: string -> U2<Qualified, string>

        type [<AllowNullLiteral>] Qualified =
            abstract space: string with get, set
            abstract local: string with get, set

        type [<AllowNullLiteral>] IExportsPrefix =
            [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

    type [<AllowNullLiteral>] Dispatch =
        abstract on: ``type``: string -> (ResizeArray<obj option> -> unit)
        abstract on: ``type``: string * listener: (ResizeArray<obj option> -> obj option) -> Dispatch
        [<Emit "$0[$1]{{=$2}}">] abstract Item: ``event``: string -> (ResizeArray<obj option> -> unit) with get, set

    module Scale =

        type [<AllowNullLiteral>] IExports =
            abstract identity: unit -> Identity
            abstract linear: unit -> Linear<float, float>
            abstract linear: unit -> Linear<'Output, 'Output>
            abstract linear: unit -> Linear<'Range, 'Output>
            abstract sqrt: unit -> Pow<float, float>
            abstract sqrt: unit -> Pow<'Output, 'Output>
            abstract sqrt: unit -> Pow<'Range, 'Output>
            abstract pow: unit -> Pow<float, float>
            abstract pow: unit -> Pow<'Output, 'Output>
            abstract pow: unit -> Pow<'Range, 'Output>
            abstract log: unit -> Log<float, float>
            abstract log: unit -> Log<'Output, 'Output>
            abstract log: unit -> Log<'Range, 'Output>
            abstract quantize: unit -> Quantize<'T>
            abstract quantile: unit -> Quantile<'T>
            abstract threshold: unit -> Threshold<float, 'Range>
            abstract threshold: unit -> Threshold<'Domain, 'Range>
            abstract ordinal: unit -> Ordinal<string, 'Range>
            abstract ordinal: unit -> Ordinal<'Domain, 'Range>
            abstract category10: unit -> Ordinal<string, string>
            abstract category10: unit -> Ordinal<'Domain, string>
            abstract category20: unit -> Ordinal<string, string>
            abstract category20: unit -> Ordinal<'Domain, string>
            abstract category20b: unit -> Ordinal<string, string>
            abstract category20b: unit -> Ordinal<'Domain, string>
            abstract category20c: unit -> Ordinal<string, string>
            abstract category20c: unit -> Ordinal<'Domain, string>

        type [<AllowNullLiteral>] Identity =
            [<Emit "$0($1...)">] abstract Invoke: n: float -> float
            abstract invert: n: float -> float
            abstract domain: unit -> ResizeArray<float>
            abstract domain: numbers: ResizeArray<float> -> Identity
            abstract range: unit -> ResizeArray<float>
            abstract range: numbers: ResizeArray<float> -> Identity
            abstract ticks: ?count: float -> ResizeArray<float>
            abstract tickFormat: ?count: float * ?format: string -> (float -> string)
            abstract copy: unit -> Identity

        type [<AllowNullLiteral>] Linear<'Range, 'Output> =
            [<Emit "$0($1...)">] abstract Invoke: x: float -> 'Output
            abstract invert: y: float -> float
            abstract domain: unit -> ResizeArray<float>
            abstract domain: numbers: ResizeArray<float> -> Linear<'Range, 'Output>
            abstract range: unit -> ResizeArray<'Range>
            abstract range: values: ResizeArray<'Range> -> Linear<'Range, 'Output>
            abstract rangeRound: values: ResizeArray<float> -> Linear<float, float>
            abstract interpolate: unit -> ('Range -> 'Range -> (float -> 'Output))
            abstract interpolate: factory: ('Range -> 'Range -> (float -> 'Output)) -> Linear<'Range, 'Output>
            abstract clamp: unit -> bool
            abstract clamp: clamp: bool -> Linear<'Range, 'Output>
            abstract nice: ?count: float -> Linear<'Range, 'Output>
            abstract ticks: ?count: float -> ResizeArray<float>
            abstract tickFormat: ?count: float * ?format: string -> (float -> string)
            abstract copy: unit -> Linear<'Range, 'Output>

        type [<AllowNullLiteral>] Pow<'Range, 'Output> =
            [<Emit "$0($1...)">] abstract Invoke: x: float -> 'Output
            abstract invert: y: float -> float
            abstract domain: unit -> ResizeArray<float>
            abstract domain: numbers: ResizeArray<float> -> Pow<'Range, 'Output>
            abstract range: unit -> ResizeArray<'Range>
            abstract range: values: ResizeArray<'Range> -> Pow<'Range, 'Output>
            abstract rangeRound: values: ResizeArray<float> -> Pow<float, float>
            abstract exponent: unit -> float
            abstract exponent: k: float -> Pow<'Range, 'Output>
            abstract interpolate: unit -> ('Range -> 'Range -> (float -> 'Output))
            abstract interpolate: factory: ('Range -> 'Range -> (float -> 'Output)) -> Pow<'Range, 'Output>
            abstract clamp: unit -> bool
            abstract clamp: clamp: bool -> Pow<'Range, 'Output>
            abstract nice: ?m: float -> Pow<'Range, 'Output>
            abstract ticks: ?count: float -> ResizeArray<float>
            abstract tickFormat: ?count: float * ?format: string -> (float -> string)
            abstract copy: unit -> Pow<'Range, 'Output>

        type [<AllowNullLiteral>] Log<'Range, 'Output> =
            [<Emit "$0($1...)">] abstract Invoke: x: float -> 'Output
            abstract invert: y: float -> float
            abstract domain: unit -> ResizeArray<float>
            abstract domain: numbers: ResizeArray<float> -> Log<'Range, 'Output>
            abstract range: unit -> ResizeArray<'Range>
            abstract range: values: ResizeArray<'Range> -> Log<'Range, 'Output>
            abstract rangeRound: values: ResizeArray<float> -> Log<float, float>
            abstract ``base``: unit -> float
            abstract ``base``: ``base``: float -> Log<'Range, 'Output>
            abstract interpolate: unit -> ('Range -> 'Range -> (float -> 'Output))
            abstract interpolate: factory: ('Range -> 'Range -> (float -> 'Output)) -> Log<'Range, 'Output>
            abstract clamp: unit -> bool
            abstract clamp: clamp: bool -> Log<'Range, 'Output>
            abstract nice: unit -> Log<'Range, 'Output>
            abstract ticks: unit -> ResizeArray<float>
            abstract tickFormat: ?count: float * ?format: string -> (float -> string)
            abstract copy: unit -> Log<'Range, 'Output>

        type [<AllowNullLiteral>] Quantize<'T> =
            [<Emit "$0($1...)">] abstract Invoke: x: float -> 'T
            abstract invertExtent: y: 'T -> float * float
            abstract domain: unit -> ResizeArray<float>
            abstract domain: numbers: ResizeArray<float> -> Quantize<'T>
            abstract range: unit -> ResizeArray<'T>
            abstract range: values: ResizeArray<'T> -> Quantize<'T>
            abstract copy: unit -> Quantize<'T>

        type [<AllowNullLiteral>] Quantile<'T> =
            [<Emit "$0($1...)">] abstract Invoke: x: float -> 'T
            abstract invertExtent: y: 'T -> float * float
            abstract domain: unit -> ResizeArray<float>
            abstract domain: numbers: ResizeArray<float> -> Quantile<'T>
            abstract range: unit -> ResizeArray<'T>
            abstract range: values: ResizeArray<'T> -> Quantile<'T>
            abstract quantiles: unit -> ResizeArray<float>
            abstract copy: unit -> Quantile<'T>

        type [<AllowNullLiteral>] Threshold<'Domain, 'Range> =
            [<Emit "$0($1...)">] abstract Invoke: x: float -> 'Range
            abstract invertExtent: y: 'Range -> 'Domain * 'Domain
            abstract domain: unit -> ResizeArray<'Domain>
            abstract domain: domain: ResizeArray<'Domain> -> Threshold<'Domain, 'Range>
            abstract range: unit -> ResizeArray<'Range>
            abstract range: values: ResizeArray<'Range> -> Threshold<'Domain, 'Range>
            abstract copy: unit -> Threshold<'Domain, 'Range>

        type [<AllowNullLiteral>] Ordinal<'Domain, 'Range> =
            [<Emit "$0($1...)">] abstract Invoke: x: 'Domain -> 'Range
            abstract domain: unit -> ResizeArray<'Domain>
            abstract domain: values: ResizeArray<'Domain> -> Ordinal<'Domain, 'Range>
            abstract range: unit -> ResizeArray<'Range>
            abstract range: values: ResizeArray<'Range> -> Ordinal<'Domain, 'Range>
            abstract rangePoints: interval: float * float * ?padding: float -> Ordinal<'Domain, float>
            abstract rangeRoundPoints: interval: float * float * ?padding: float -> Ordinal<'Domain, float>
            abstract rangeBands: interval: float * float * ?padding: float * ?outerPadding: float -> Ordinal<'Domain, float>
            abstract rangeRoundBands: interval: float * float * ?padding: float * ?outerPadding: float -> Ordinal<'Domain, float>
            abstract rangeBand: unit -> float
            abstract rangeExtent: unit -> float * float
            abstract copy: unit -> Ordinal<'Domain, 'Range>

    module Time =
        let [<Import("format","d3/time")>] format: Format.IExports = jsNative
        let [<Import("scale","d3/time")>] scale: Scale.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract second: Interval
            abstract minute: Interval
            abstract hour: Interval
            abstract day: Interval
            abstract week: Interval
            abstract sunday: Interval
            abstract monday: Interval
            abstract tuesday: Interval
            abstract wednesday: Interval
            abstract thursday: Interval
            abstract friday: Interval
            abstract saturday: Interval
            abstract month: Interval
            abstract year: Interval
            abstract seconds: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract minutes: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract hours: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract days: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract weeks: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract sundays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract mondays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract tuesdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract wednesdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract thursdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract fridays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract saturdays: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract months: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract years: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract dayOfYear: d: DateTime -> float
            abstract weekOfYear: d: DateTime -> float
            abstract sundayOfYear: d: DateTime -> float
            abstract mondayOfYear: d: DateTime -> float
            abstract tuesdayOfYear: d: DateTime -> float
            abstract wednesdayOfYear: d: DateTime -> float
            abstract fridayOfYear: d: DateTime -> float
            abstract saturdayOfYear: d: DateTime -> float
            abstract format: specifier: string -> Format
            abstract scale: unit -> Scale<float, float>
            abstract scale: unit -> Scale<'Output, 'Output>
            abstract scale: unit -> Scale<'Range, 'Output>

        type [<AllowNullLiteral>] Interval =
            [<Emit "$0($1...)">] abstract Invoke: d: DateTime -> DateTime
            abstract floor: d: DateTime -> DateTime
            abstract round: d: DateTime -> DateTime
            abstract ceil: d: DateTime -> DateTime
            abstract range: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract offset: date: DateTime * step: float -> DateTime
            abstract utc: IntervalUtc with get, set

        module Format =
            let [<Import("utc","d3/time/format")>] utc: Utc.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract multi: formats: Array<string * (DateTime -> U2<bool, float>)> -> Format
                abstract utc: specifier: string -> Format
                abstract iso: Format

            module Utc =

                type [<AllowNullLiteral>] IExports =
                    abstract multi: formats: Array<string * (DateTime -> U2<bool, float>)> -> Format

        type [<AllowNullLiteral>] Format =
            [<Emit "$0($1...)">] abstract Invoke: d: DateTime -> string
            abstract parse: input: string -> DateTime

        module Scale =

            type [<AllowNullLiteral>] IExports =
                abstract utc: unit -> Scale<float, float>
                abstract utc: unit -> Scale<'Output, 'Output>
                abstract utc: unit -> Scale<'Range, 'Output>

        type [<AllowNullLiteral>] Scale<'Range, 'Output> =
            [<Emit "$0($1...)">] abstract Invoke: x: DateTime -> 'Output
            abstract invert: y: float -> DateTime
            abstract domain: unit -> ResizeArray<DateTime>
            abstract domain: dates: ResizeArray<float> -> Scale<'Range, 'Output>
            abstract domain: dates: ResizeArray<DateTime> -> Scale<'Range, 'Output>
            abstract nice: unit -> Scale<'Range, 'Output>
            abstract nice: interval: Interval * ?step: float -> Scale<'Range, 'Output>
            abstract range: unit -> ResizeArray<'Range>
            abstract range: values: ResizeArray<'Range> -> Scale<'Range, 'Output>
            abstract rangeRound: values: ResizeArray<float> -> Scale<float, float>
            abstract interpolate: unit -> ('Range -> 'Range -> (float -> 'Output))
            abstract interpolate: factory: ('Range -> 'Range -> (float -> 'Output)) -> Scale<'Range, 'Output>
            abstract clamp: unit -> bool
            abstract clamp: clamp: bool -> Scale<'Range, 'Output>
            abstract ticks: unit -> ResizeArray<DateTime>
            abstract ticks: interval: Interval * ?step: float -> ResizeArray<DateTime>
            abstract ticks: count: float -> ResizeArray<DateTime>
            abstract tickFormat: count: float -> (DateTime -> string)
            abstract copy: unit -> Scale<'Range, 'Output>

        type [<AllowNullLiteral>] IntervalUtc =
            [<Emit "$0($1...)">] abstract Invoke: d: DateTime -> DateTime
            abstract floor: d: DateTime -> DateTime
            abstract round: d: DateTime -> DateTime
            abstract ceil: d: DateTime -> DateTime
            abstract range: start: DateTime * stop: DateTime * ?step: float -> ResizeArray<DateTime>
            abstract offset: date: DateTime * step: float -> DateTime

    module Behavior =

        type [<AllowNullLiteral>] IExports =
            abstract drag: unit -> Drag<'Datum>
            abstract zoom: unit -> Zoom<'Datum>

        type [<AllowNullLiteral>] Drag<'Datum> =
            [<Emit "$0($1...)">] abstract Invoke: selection: Selection<'Datum> -> unit
            abstract on: ``type``: string -> ('Datum -> float -> obj option)
            abstract on: ``type``: string * listener: ('Datum -> float -> obj option) -> Drag<'Datum>
            abstract origin: unit -> ('Datum -> float -> DragOrigin)
            abstract origin: accessor: ('Datum -> float -> DragOrigin) -> Drag<'Datum>

        module Zoom =

            type [<AllowNullLiteral>] Scale =
                abstract domain: unit -> ResizeArray<float>
                abstract domain: values: ResizeArray<float> -> Scale
                abstract invert: y: float -> float
                abstract range: values: ResizeArray<float> -> Scale
                abstract range: unit -> ResizeArray<float>

        type [<AllowNullLiteral>] Zoom<'Datum> =
            [<Emit "$0($1...)">] abstract Invoke: selection: Selection<'Datum> -> unit
            abstract translate: unit -> float * float
            abstract translate: translate: float * float -> Zoom<'Datum>
            abstract scale: unit -> float
            abstract scale: scale: float -> Zoom<'Datum>
            abstract scaleExtent: unit -> float * float
            abstract scaleExtent: extent: float * float -> Zoom<'Datum>
            abstract center: unit -> float * float
            abstract center: center: float * float -> Zoom<'Datum>
            abstract size: unit -> float * float
            abstract size: size: float * float -> Zoom<'Datum>
            abstract x: unit -> Zoom.Scale
            abstract x: x: Zoom.Scale -> Zoom<'Datum>
            abstract y: unit -> Zoom.Scale
            abstract y: y: Zoom.Scale -> Zoom<'Datum>
            abstract on: ``type``: string -> ('Datum -> float -> obj option)
            abstract on: ``type``: string * listener: ('Datum -> float -> obj option) -> Zoom<'Datum>
            abstract ``event``: selection: Selection<'Datum> -> unit
            abstract ``event``: transition: Transition<'Datum> -> unit

        type [<AllowNullLiteral>] DragOrigin =
            abstract x: float with get, set
            abstract y: float with get, set

    module Geo =
        let [<Import("azimuthalEqualArea","d3/geo")>] azimuthalEqualArea: AzimuthalEqualArea.IExports = jsNative
        let [<Import("azimuthalEquidistant","d3/geo")>] azimuthalEquidistant: AzimuthalEquidistant.IExports = jsNative
        let [<Import("conicConformal","d3/geo")>] conicConformal: ConicConformal.IExports = jsNative
        let [<Import("conicEqualArea","d3/geo")>] conicEqualArea: ConicEqualArea.IExports = jsNative
        let [<Import("conicEquidistant","d3/geo")>] conicEquidistant: ConicEquidistant.IExports = jsNative
        let [<Import("equirectangular","d3/geo")>] equirectangular: Equirectangular.IExports = jsNative
        let [<Import("gnomonic","d3/geo")>] gnomonic: Gnomonic.IExports = jsNative
        let [<Import("mercator","d3/geo")>] mercator: Mercator.IExports = jsNative
        let [<Import("orthographic","d3/geo")>] orthographic: Orthographic.IExports = jsNative
        let [<Import("stereographic","d3/geo")>] stereographic: Stereographic.IExports = jsNative
        let [<Import("transverseMercator","d3/geo")>] transverseMercator: TransverseMercator.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract path: unit -> Path
            abstract graticule: unit -> Graticule
            abstract circle: unit -> Circle
            abstract area: feature: obj option -> float
            abstract centroid: feature: obj option -> float * float
            abstract bounds: feature: obj option -> float * float * float * float
            abstract distance: a: float * float * b: float * float -> float
            abstract length: feature: obj option -> float
            abstract interpolate: a: float * float * b: float * float -> (float -> float * float)
            abstract rotation: rotate: U2<float * float, float * float * float> -> Rotation
            abstract stream: ``object``: obj option * listener: Listener -> unit
            abstract transform: methods: TransformMethods -> Transform
            abstract clipExtent: unit -> ClipExtent
            abstract projection: raw: RawInvertibleProjection -> InvertibleProjection
            abstract projection: raw: RawProjection -> Projection
            abstract projectionMutator: factory: (ResizeArray<obj option> -> RawInvertibleProjection) -> (ResizeArray<obj option> -> InvertibleProjection)
            abstract projectionMutator: factory: (ResizeArray<obj option> -> RawProjection) -> (ResizeArray<obj option> -> Projection)
            abstract albers: unit -> ConicProjection
            abstract albersUsa: unit -> ConicProjection
            abstract azimuthalEqualArea: unit -> InvertibleProjection
            abstract azimuthalEquidistant: unit -> InvertibleProjection
            abstract conicConformal: unit -> ConicProjection
            abstract conicEqualArea: unit -> ConicProjection
            abstract conicEquidistant: unit -> ConicProjection
            abstract equirectangular: unit -> InvertibleProjection
            abstract gnomonic: unit -> InvertibleProjection
            abstract mercator: unit -> InvertibleProjection
            abstract orthographic: unit -> InvertibleProjection
            abstract stereographic: unit -> InvertibleProjection
            abstract transverseMercator: unit -> InvertibleProjection

        type [<AllowNullLiteral>] Path =
            [<Emit "$0($1...)">] abstract Invoke: feature: obj option * ?index: float -> string
            abstract area: feature: obj option -> float
            abstract centroid: feature: obj option -> float * float
            abstract bounds: feature: obj option -> float * float * float * float
            abstract projection: unit -> U2<Transform, (float * float -> float * float)>
            abstract projection: stream: Transform -> Path
            abstract projection: projection: (float * float -> float * float) -> Path
            abstract pointRadius: unit -> U2<float, (obj option -> float -> float)>
            abstract pointRadius: radius: float -> Path
            abstract pointRadius: radius: (obj option -> float -> float) -> Path
            abstract context: unit -> CanvasRenderingContext2D
            abstract context: context: CanvasRenderingContext2D -> Path

        type [<AllowNullLiteral>] Graticule =
            [<Emit "$0($1...)">] abstract Invoke: unit -> obj option
            abstract lines: unit -> ResizeArray<obj option>
            abstract outline: unit -> obj option
            abstract extent: unit -> float * float * float * float
            abstract extent: extent: float * float * float * float -> Graticule
            abstract majorExtent: unit -> float * float * float * float
            abstract majorExtent: extent: float * float * float * float -> Graticule
            abstract minorExtent: unit -> float * float * float * float
            abstract minorExtent: extent: float * float * float * float -> Graticule
            abstract step: unit -> float * float
            abstract step: step: float * float -> Graticule
            abstract majorStep: unit -> float * float
            abstract majorStep: step: float * float -> Graticule
            abstract minorStep: unit -> float * float
            abstract minorStep: step: float * float -> Graticule
            abstract precision: unit -> float
            abstract precision: precision: float -> Graticule

        type [<AllowNullLiteral>] Circle =
            [<Emit "$0($1...)">] abstract Invoke: [<ParamArray>] args: ResizeArray<obj option> -> obj option
            abstract origin: unit -> U2<float * float, (ResizeArray<obj option> -> float * float)>
            abstract origin: origin: float * float -> Circle
            abstract origin: origin: (ResizeArray<obj option> -> float * float) -> Circle
            abstract angle: unit -> float
            abstract angle: angle: float -> Circle
            abstract precision: unit -> float
            abstract precision: precision: float -> Circle

        type [<AllowNullLiteral>] Rotation =
            [<Emit "$0($1...)">] abstract Invoke: location: float * float -> float * float
            abstract invert: location: float * float -> float * float

        type [<AllowNullLiteral>] Listener =
            abstract point: x: float * y: float * z: float -> unit
            abstract lineStart: unit -> unit
            abstract lineEnd: unit -> unit
            abstract polygonStart: unit -> unit
            abstract polygonEnd: unit -> unit
            abstract sphere: unit -> unit

        type [<AllowNullLiteral>] TransformMethods =
            abstract point: x: float * y: float * z: float -> unit
            abstract lineStart: unit -> unit
            abstract lineEnd: unit -> unit
            abstract polygonStart: unit -> unit
            abstract polygonEnd: unit -> unit
            abstract sphere: unit -> unit

        type [<AllowNullLiteral>] Transform =
            abstract stream: stream: Listener -> Listener

        type [<AllowNullLiteral>] ClipExtent =
            inherit Transform
            abstract extent: unit -> float * float * float * float
            abstract extent: extent: float * float * float * float -> ClipExtent

        module AzimuthalEqualArea =
            let [<Import("raw","d3/geo/azimuthalEqualArea")>] raw: Raw.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract raw: lambda: float * phi: float -> float * float

            module Raw =

                type [<AllowNullLiteral>] IExports =
                    abstract invert: x: float * y: float -> float * float

        module AzimuthalEquidistant =
            let [<Import("raw","d3/geo/azimuthalEquidistant")>] raw: Raw.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract raw: lambda: float * phi: float -> float * float

            module Raw =

                type [<AllowNullLiteral>] IExports =
                    abstract invert: x: float * y: float -> float * float

        module ConicConformal =

            type [<AllowNullLiteral>] IExports =
                abstract raw: phi0: float * phi1: float -> RawInvertibleProjection

        module ConicEqualArea =

            type [<AllowNullLiteral>] IExports =
                abstract raw: phi0: float * phi1: float -> RawInvertibleProjection

        module ConicEquidistant =

            type [<AllowNullLiteral>] IExports =
                abstract raw: phi0: float * phi1: float -> RawInvertibleProjection

        module Equirectangular =
            let [<Import("raw","d3/geo/equirectangular")>] raw: Raw.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract raw: lambda: float * phi: float -> float * float

            module Raw =

                type [<AllowNullLiteral>] IExports =
                    abstract invert: x: float * y: float -> float * float

        module Gnomonic =
            let [<Import("raw","d3/geo/gnomonic")>] raw: Raw.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract raw: lambda: float * phi: float -> float * float

            module Raw =

                type [<AllowNullLiteral>] IExports =
                    abstract invert: x: float * y: float -> float * float

        module Mercator =
            let [<Import("raw","d3/geo/mercator")>] raw: Raw.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract raw: lambda: float * phi: float -> float * float

            module Raw =

                type [<AllowNullLiteral>] IExports =
                    abstract invert: x: float * y: float -> float * float

        module Orthographic =
            let [<Import("raw","d3/geo/orthographic")>] raw: Raw.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract raw: lambda: float * phi: float -> float * float

            module Raw =

                type [<AllowNullLiteral>] IExports =
                    abstract invert: x: float * y: float -> float * float

        module Stereographic =
            let [<Import("raw","d3/geo/stereographic")>] raw: Raw.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract raw: lambda: float * phi: float -> float * float

            module Raw =

                type [<AllowNullLiteral>] IExports =
                    abstract invert: x: float * y: float -> float * float

        module TransverseMercator =
            let [<Import("raw","d3/geo/transverseMercator")>] raw: Raw.IExports = jsNative

            type [<AllowNullLiteral>] IExports =
                abstract raw: lambda: float * phi: float -> float * float

            module Raw =

                type [<AllowNullLiteral>] IExports =
                    abstract invert: x: float * y: float -> float * float

        type [<AllowNullLiteral>] Projection =
            [<Emit "$0($1...)">] abstract Invoke: location: float * float -> float * float
            abstract rotate: unit -> float * float * float
            abstract rotate: rotation: float * float * float -> Projection
            abstract center: unit -> float * float
            abstract center: location: float * float -> Projection
            abstract translate: unit -> float * float
            abstract translate: point: float * float -> Projection
            abstract scale: unit -> float
            abstract scale: scale: float -> Projection
            abstract clipAngle: unit -> float
            abstract clipAngle: angle: float -> Projection
            abstract clipExtent: unit -> float * float * float * float
            abstract clipExtent: extent: float * float * float * float -> Projection
            abstract precision: unit -> float
            abstract precision: precision: float -> Projection
            abstract stream: listener: Listener -> Listener

        type [<AllowNullLiteral>] InvertibleProjection =
            inherit Projection
            abstract invert: point: float * float -> float * float

        type [<AllowNullLiteral>] ConicProjection =
            inherit InvertibleProjection
            abstract parallels: unit -> float * float
            abstract parallels: parallels: float * float -> ConicProjection
            abstract rotate: unit -> float * float * float
            abstract rotate: rotation: float * float * float -> ConicProjection
            abstract center: unit -> float * float
            abstract center: location: float * float -> ConicProjection
            abstract translate: unit -> float * float
            abstract translate: point: float * float -> ConicProjection
            abstract scale: unit -> float
            abstract scale: scale: float -> ConicProjection
            abstract clipAngle: unit -> float
            abstract clipAngle: angle: float -> ConicProjection
            abstract clipExtent: unit -> float * float * float * float
            abstract clipExtent: extent: float * float * float * float -> ConicProjection
            abstract precision: unit -> float
            abstract precision: precision: float -> ConicProjection

        type [<AllowNullLiteral>] RawProjection =
            [<Emit "$0($1...)">] abstract Invoke: lambda: float * phi: float -> float * float

        type [<AllowNullLiteral>] RawInvertibleProjection =
            inherit RawProjection
            abstract invert: x: float * y: float -> float * float

    module Svg =
        let [<Import("line","d3/svg")>] line: Line.IExports = jsNative
        let [<Import("area","d3/svg")>] area: Area.IExports = jsNative
        let [<Import("diagonal","d3/svg")>] diagonal: Diagonal.IExports = jsNative

        type [<AllowNullLiteral>] IExports =
            abstract line: unit -> Line<float * float>
            abstract line: unit -> Line<'T>
            abstract area: unit -> Area<float * float>
            abstract area: unit -> Area<'T>
            abstract arc: unit -> Arc<Arc.Arc>
            abstract arc: unit -> Arc<'T>
            abstract symbol: unit -> Symbol<IExportsSymbolSymbol>
            abstract symbol: unit -> Symbol<'T>
            abstract symbolTypes: ResizeArray<string>
            abstract chord: unit -> Chord<Chord.Link<Chord.Node>, Chord.Node>
            abstract chord: unit -> Chord<Chord.Link<'Node>, 'Node>
            abstract chord: unit -> Chord<'Link, 'Node>
            abstract diagonal: unit -> Diagonal<Diagonal.Link<Diagonal.Node>, Diagonal.Node>
            abstract diagonal: unit -> Diagonal<Diagonal.Link<'Node>, 'Node>
            abstract diagonal: unit -> Diagonal<'Link, 'Node>
            abstract axis: unit -> Axis
            abstract brush: unit -> Brush<obj option, float, float>
            abstract brush: unit -> Brush<'T, float, float>
            abstract brush: unit -> Brush<'T, 'X, 'X>
            abstract brush: unit -> Brush<'T, 'X, 'Y>

        type [<AllowNullLiteral>] Line<'T> =
            [<Emit "$0($1...)">] abstract Invoke: data: ResizeArray<'T> -> string
            abstract x: unit -> U2<float, ('T -> float -> float)>
            abstract x: x: float -> Line<'T>
            abstract x: x: ('T -> float -> float) -> Line<'T>
            abstract y: unit -> U2<float, ('T -> float -> float)>
            abstract y: x: float -> Line<'T>
            abstract y: y: ('T -> float -> float) -> Line<'T>
            abstract interpolate: unit -> U2<string, (Array<float * float> -> string)>
            [<Emit "$0.interpolate('linear')">] abstract interpolate_linear: unit -> Line<'T>
            [<Emit "$0.interpolate('linear-closed')">] abstract ``interpolate_linear-closed``: unit -> Line<'T>
            [<Emit "$0.interpolate('step')">] abstract interpolate_step: unit -> Line<'T>
            [<Emit "$0.interpolate('step-before')">] abstract ``interpolate_step-before``: unit -> Line<'T>
            [<Emit "$0.interpolate('step-after')">] abstract ``interpolate_step-after``: unit -> Line<'T>
            [<Emit "$0.interpolate('basis')">] abstract interpolate_basis: unit -> Line<'T>
            [<Emit "$0.interpolate('basis-open')">] abstract ``interpolate_basis-open``: unit -> Line<'T>
            [<Emit "$0.interpolate('basis-closed')">] abstract ``interpolate_basis-closed``: unit -> Line<'T>
            [<Emit "$0.interpolate('bundle')">] abstract interpolate_bundle: unit -> Line<'T>
            [<Emit "$0.interpolate('cardinal')">] abstract interpolate_cardinal: unit -> Line<'T>
            [<Emit "$0.interpolate('cardinal-open')">] abstract ``interpolate_cardinal-open``: unit -> Line<'T>
            [<Emit "$0.interpolate('cardinal-closed')">] abstract ``interpolate_cardinal-closed``: unit -> Line<'T>
            [<Emit "$0.interpolate('monotone')">] abstract interpolate_monotone: unit -> Line<'T>
            abstract interpolate: interpolate: U2<string, (Array<float * float> -> string)> -> Line<'T>
            abstract tension: unit -> float
            abstract tension: tension: float -> Line<'T>
            abstract defined: unit -> ('T -> float -> bool)
            abstract defined: defined: ('T -> float -> bool) -> Line<'T>

        module Line =

            type [<AllowNullLiteral>] IExports =
                abstract radial: unit -> Radial<float * float>
                abstract radial: unit -> Radial<'T>

            type [<AllowNullLiteral>] Radial<'T> =
                [<Emit "$0($1...)">] abstract Invoke: data: ResizeArray<'T> -> string
                abstract radius: unit -> U2<float, ('T -> float -> float)>
                abstract radius: radius: float -> Radial<'T>
                abstract radius: radius: ('T -> float -> float) -> Radial<'T>
                abstract angle: unit -> U2<float, ('T -> float -> float)>
                abstract angle: angle: float -> Radial<'T>
                abstract angle: angle: ('T -> float -> float) -> Radial<'T>
                abstract interpolate: unit -> U2<string, (Array<float * float> -> string)>
                [<Emit "$0.interpolate('linear')">] abstract interpolate_linear: unit -> Radial<'T>
                [<Emit "$0.interpolate('linear-closed')">] abstract ``interpolate_linear-closed``: unit -> Radial<'T>
                [<Emit "$0.interpolate('step')">] abstract interpolate_step: unit -> Radial<'T>
                [<Emit "$0.interpolate('step-before')">] abstract ``interpolate_step-before``: unit -> Radial<'T>
                [<Emit "$0.interpolate('step-after')">] abstract ``interpolate_step-after``: unit -> Radial<'T>
                [<Emit "$0.interpolate('basis')">] abstract interpolate_basis: unit -> Radial<'T>
                [<Emit "$0.interpolate('basis-open')">] abstract ``interpolate_basis-open``: unit -> Radial<'T>
                [<Emit "$0.interpolate('basis-closed')">] abstract ``interpolate_basis-closed``: unit -> Radial<'T>
                [<Emit "$0.interpolate('bundle')">] abstract interpolate_bundle: unit -> Radial<'T>
                [<Emit "$0.interpolate('cardinal')">] abstract interpolate_cardinal: unit -> Radial<'T>
                [<Emit "$0.interpolate('cardinal-open')">] abstract ``interpolate_cardinal-open``: unit -> Radial<'T>
                [<Emit "$0.interpolate('cardinal-closed')">] abstract ``interpolate_cardinal-closed``: unit -> Radial<'T>
                [<Emit "$0.interpolate('monotone')">] abstract interpolate_monotone: unit -> Radial<'T>
                abstract interpolate: interpolate: U2<string, (Array<float * float> -> string)> -> Radial<'T>
                abstract tension: unit -> float
                abstract tension: tension: float -> Radial<'T>
                abstract defined: unit -> ('T -> float -> bool)
                abstract defined: defined: ('T -> float -> bool) -> Radial<'T>

        type [<AllowNullLiteral>] Area<'T> =
            [<Emit "$0($1...)">] abstract Invoke: data: ResizeArray<'T> -> string
            abstract x: unit -> U2<float, ('T -> float -> float)>
            abstract x: x: float -> Area<'T>
            abstract x: x: ('T -> float -> float) -> Area<'T>
            abstract x0: unit -> U2<float, ('T -> float -> float)>
            abstract x0: x0: float -> Area<'T>
            abstract x0: x0: ('T -> float -> float) -> Area<'T>
            abstract x1: unit -> U2<float, ('T -> float -> float)>
            abstract x1: x1: float -> Area<'T>
            abstract x1: x1: ('T -> float -> float) -> Area<'T>
            abstract y: unit -> U2<float, ('T -> float -> float)>
            abstract y: y: float -> Area<'T>
            abstract y: y: ('T -> float -> float) -> Area<'T>
            abstract y0: unit -> U2<float, ('T -> float -> float)>
            abstract y0: y0: float -> Area<'T>
            abstract y0: y0: ('T -> float -> float) -> Area<'T>
            abstract y1: unit -> U2<float, ('T -> float -> float)>
            abstract y1: y1: float -> Area<'T>
            abstract y1: y1: ('T -> float -> float) -> Area<'T>
            abstract interpolate: unit -> U2<string, (Array<float * float> -> string)>
            [<Emit "$0.interpolate('linear')">] abstract interpolate_linear: unit -> Area<'T>
            [<Emit "$0.interpolate('step')">] abstract interpolate_step: unit -> Area<'T>
            [<Emit "$0.interpolate('step-before')">] abstract ``interpolate_step-before``: unit -> Area<'T>
            [<Emit "$0.interpolate('step-after')">] abstract ``interpolate_step-after``: unit -> Area<'T>
            [<Emit "$0.interpolate('basis')">] abstract interpolate_basis: unit -> Area<'T>
            [<Emit "$0.interpolate('basis-open')">] abstract ``interpolate_basis-open``: unit -> Area<'T>
            [<Emit "$0.interpolate('cardinal')">] abstract interpolate_cardinal: unit -> Area<'T>
            [<Emit "$0.interpolate('cardinal-open')">] abstract ``interpolate_cardinal-open``: unit -> Area<'T>
            [<Emit "$0.interpolate('monotone')">] abstract interpolate_monotone: unit -> Area<'T>
            abstract interpolate: interpolate: U2<string, (Array<float * float> -> string)> -> Area<'T>
            abstract tension: unit -> float
            abstract tension: tension: float -> Area<'T>
            abstract defined: unit -> ('T -> float -> bool)
            abstract defined: defined: ('T -> float -> bool) -> Area<'T>

        module Area =

            type [<AllowNullLiteral>] IExports =
                abstract radial: unit -> Radial<float * float>
                abstract radial: unit -> Radial<'T>

            type [<AllowNullLiteral>] Radial<'T> =
                [<Emit "$0($1...)">] abstract Invoke: data: ResizeArray<'T> -> string
                abstract radius: unit -> U2<float, ('T -> float -> float)>
                abstract radius: radius: float -> Radial<'T>
                abstract radius: radius: ('T -> float -> float) -> Radial<'T>
                abstract innerRadius: unit -> U2<float, ('T -> float -> float)>
                abstract innerRadius: innerRadius: float -> Radial<'T>
                abstract innerRadius: innerRadius: ('T -> float -> float) -> Radial<'T>
                abstract outerRadius: unit -> U2<float, ('T -> float -> float)>
                abstract outerRadius: outerRadius: float -> Radial<'T>
                abstract outerRadius: outerRadius: ('T -> float -> float) -> Radial<'T>
                abstract angle: unit -> U2<float, ('T -> float -> float)>
                abstract angle: angle: float -> Radial<'T>
                abstract angle: angle: ('T -> float -> float) -> Radial<'T>
                abstract startAngle: unit -> U2<float, ('T -> float -> float)>
                abstract startAngle: startAngle: float -> Radial<'T>
                abstract startAngle: startAngle: ('T -> float -> float) -> Radial<'T>
                abstract endAngle: unit -> U2<float, ('T -> float -> float)>
                abstract endAngle: endAngle: float -> Radial<'T>
                abstract endAngle: endAngle: ('T -> float -> float) -> Radial<'T>
                abstract interpolate: unit -> U2<string, (Array<float * float> -> string)>
                [<Emit "$0.interpolate('linear')">] abstract interpolate_linear: unit -> Radial<'T>
                [<Emit "$0.interpolate('step')">] abstract interpolate_step: unit -> Radial<'T>
                [<Emit "$0.interpolate('step-before')">] abstract ``interpolate_step-before``: unit -> Radial<'T>
                [<Emit "$0.interpolate('step-after')">] abstract ``interpolate_step-after``: unit -> Radial<'T>
                [<Emit "$0.interpolate('basis')">] abstract interpolate_basis: unit -> Radial<'T>
                [<Emit "$0.interpolate('basis-open')">] abstract ``interpolate_basis-open``: unit -> Radial<'T>
                [<Emit "$0.interpolate('cardinal')">] abstract interpolate_cardinal: unit -> Radial<'T>
                [<Emit "$0.interpolate('cardinal-open')">] abstract ``interpolate_cardinal-open``: unit -> Radial<'T>
                [<Emit "$0.interpolate('monotone')">] abstract interpolate_monotone: unit -> Radial<'T>
                abstract interpolate: interpolate: U2<string, (Array<float * float> -> string)> -> Radial<'T>
                abstract tension: unit -> float
                abstract tension: tension: float -> Radial<'T>
                abstract defined: unit -> ('T -> float -> bool)
                abstract defined: defined: ('T -> float -> bool) -> Radial<'T>

        module Arc =

            type [<AllowNullLiteral>] Arc =
                abstract innerRadius: float with get, set
                abstract outerRadius: float with get, set
                abstract startAngle: float with get, set
                abstract endAngle: float with get, set
                abstract padAngle: float with get, set

        type [<AllowNullLiteral>] Arc<'T> =
            [<Emit "$0($1...)">] abstract Invoke: d: 'T * ?i: float -> string
            abstract innerRadius: unit -> ('T -> float -> float)
            abstract innerRadius: radius: float -> Arc<'T>
            abstract innerRadius: radius: ('T -> float -> float) -> Arc<'T>
            abstract outerRadius: unit -> ('T -> float -> float)
            abstract outerRadius: radius: float -> Arc<'T>
            abstract outerRadius: radius: ('T -> float -> float) -> Arc<'T>
            abstract cornerRadius: unit -> ('T -> float -> float)
            abstract cornerRadius: radius: float -> Arc<'T>
            abstract cornerRadius: radius: ('T -> float -> float) -> Arc<'T>
            abstract padRadius: unit -> U2<string, ('T -> float -> float)>
            [<Emit "$0.padRadius('auto')">] abstract padRadius_auto: unit -> Arc<'T>
            abstract padRadius: radius: string -> Arc<'T>
            abstract padRadius: radius: ('T -> float -> float) -> Arc<'T>
            abstract startAngle: unit -> ('T -> float -> float)
            abstract startAngle: angle: float -> Arc<'T>
            abstract startAngle: angle: ('T -> float -> float) -> Arc<'T>
            abstract endAngle: unit -> ('T -> float -> float)
            abstract endAngle: angle: float -> Arc<'T>
            abstract endAngle: angle: ('T -> float -> float) -> Arc<'T>
            abstract padAngle: unit -> ('T -> float -> float)
            abstract padAngle: angle: float -> Arc<'T>
            abstract padAngle: angle: ('T -> float -> float) -> Arc<'T>
            abstract centroid: d: 'T * ?i: float -> float * float

        type [<AllowNullLiteral>] Symbol<'T> =
            [<Emit "$0($1...)">] abstract Invoke: d: 'T * ?i: float -> string
            abstract ``type``: unit -> ('T -> float -> string)
            abstract ``type``: ``type``: string -> Symbol<'T>
            abstract ``type``: ``type``: ('T -> float -> string) -> Symbol<'T>
            abstract size: unit -> ('T -> string -> float)
            abstract size: size: float -> Symbol<'T>
            abstract size: size: ('T -> float -> float) -> Symbol<'T>

        module Chord =

            type [<AllowNullLiteral>] Link<'Node> =
                abstract source: 'Node with get, set
                abstract target: 'Node with get, set

            type [<AllowNullLiteral>] Node =
                abstract radius: float with get, set
                abstract startAngle: float with get, set
                abstract endAngle: float with get, set

        type [<AllowNullLiteral>] Chord<'Link, 'Node> =
            [<Emit "$0($1...)">] abstract Invoke: d: 'Link * i: float -> string
            abstract source: unit -> ('Link -> float -> 'Node)
            abstract source: source: 'Node -> Chord<'Link, 'Node>
            abstract source: source: ('Link -> float -> 'Node) -> Chord<'Link, 'Node>
            abstract target: unit -> ('Link -> float -> 'Node)
            abstract target: target: 'Node -> Chord<'Link, 'Node>
            abstract target: target: ('Link -> float -> 'Node) -> Chord<'Link, 'Node>
            abstract radius: unit -> ('Node -> float -> float)
            abstract radius: radius: float -> Chord<'Link, 'Node>
            abstract radius: radius: ('Node -> float -> float) -> Chord<'Link, 'Node>
            abstract startAngle: unit -> ('Node -> float -> float)
            abstract startAngle: angle: float -> Chord<'Link, 'Node>
            abstract startAngle: angle: ('Node -> float -> float) -> Chord<'Link, 'Node>
            abstract endAngle: unit -> ('Node -> float -> float)
            abstract endAngle: angle: float -> Chord<'Link, 'Node>
            abstract endAngle: angle: ('Node -> float -> float) -> Chord<'Link, 'Node>

        module Diagonal =

            type [<AllowNullLiteral>] IExports =
                abstract radial: unit -> Radial<Link<Node>, Node>
                abstract radial: unit -> Radial<Link<'Node>, 'Node>
                abstract radial: unit -> Radial<'Link, 'Node>

            type [<AllowNullLiteral>] Link<'Node> =
                abstract source: 'Node with get, set
                abstract target: 'Node with get, set

            type [<AllowNullLiteral>] Node =
                abstract x: float with get, set
                abstract y: float with get, set

            type [<AllowNullLiteral>] Radial<'Link, 'Node> =
                [<Emit "$0($1...)">] abstract Invoke: d: 'Link * i: float -> string
                abstract source: unit -> ('Link -> float -> 'Node)
                abstract source: source: 'Node -> Radial<'Link, 'Node>
                abstract source: source: ('Link -> float -> 'Node) -> Radial<'Link, 'Node>
                abstract target: unit -> ('Link -> float -> 'Node)
                abstract target: target: 'Node -> Radial<'Link, 'Node>
                abstract target: target: ('Link -> float -> 'Node) -> Radial<'Link, 'Node>
                abstract projection: unit -> ('Node -> float -> float * float)
                abstract projection: projection: ('Node -> float -> float * float) -> Radial<'Link, 'Node>

        type [<AllowNullLiteral>] Diagonal<'Link, 'Node> =
            [<Emit "$0($1...)">] abstract Invoke: d: 'Link * ?i: float -> string
            abstract source: unit -> ('Link -> float -> 'Node)
            abstract source: source: 'Node -> Diagonal<'Link, 'Node>
            abstract source: source: ('Link -> float -> DiagonalSource) -> Diagonal<'Link, 'Node>
            abstract target: unit -> ('Link -> float -> 'Node)
            abstract target: target: 'Node -> Diagonal<'Link, 'Node>
            abstract target: target: ('Link -> float -> DiagonalSource) -> Diagonal<'Link, 'Node>
            abstract projection: unit -> ('Node -> float -> float * float)
            abstract projection: projection: ('Node -> float -> float * float) -> Diagonal<'Link, 'Node>

        type [<AllowNullLiteral>] Axis =
            [<Emit "$0($1...)">] abstract Invoke: selection: Selection<obj option> -> unit
            [<Emit "$0($1...)">] abstract Invoke: selection: Transition<obj option> -> unit
            abstract scale: unit -> obj option
            abstract scale: scale: obj option -> Axis
            abstract orient: unit -> string
            abstract orient: orientation: string -> Axis
            abstract ticks: unit -> ResizeArray<obj option>
            abstract ticks: [<ParamArray>] args: ResizeArray<obj option> -> Axis
            abstract tickValues: unit -> ResizeArray<obj option>
            abstract tickValues: values: ResizeArray<obj option> -> Axis
            abstract tickSize: unit -> float
            abstract tickSize: size: float -> Axis
            abstract tickSize: inner: float * outer: float -> Axis
            abstract innerTickSize: unit -> float
            abstract innerTickSize: size: float -> Axis
            abstract outerTickSize: unit -> float
            abstract outerTickSize: size: float -> Axis
            abstract tickPadding: unit -> float
            abstract tickPadding: padding: float -> Axis
            abstract tickFormat: unit -> (obj option -> float -> string)
            abstract tickFormat: format: (obj option -> float -> string) -> Axis
            abstract tickFormat: format: string -> Axis

        module Brush =

            type [<AllowNullLiteral>] Scale<'S> =
                abstract domain: unit -> ResizeArray<'S>
                abstract domain: domain: ResizeArray<'S> -> Scale<'S>
                abstract range: unit -> ResizeArray<'S>
                abstract range: range: ResizeArray<float> -> Scale<'S>
                abstract invert: y: float -> 'S

        type [<AllowNullLiteral>] Brush<'T, 'X, 'Y> =
            [<Emit "$0($1...)">] abstract Invoke: selection: Selection<'T> -> unit
            [<Emit "$0($1...)">] abstract Invoke: selection: Transition<'T> -> unit
            abstract ``event``: selection: Selection<'T> -> unit
            abstract ``event``: selection: Transition<'T> -> unit
            abstract x: unit -> Brush.Scale<'X>
            abstract x: x: Brush.Scale<'X> -> Brush<'T, 'X, 'Y>
            abstract x: x: U2<D3.Scale.Ordinal<'A, 'B>, D3.Time.Scale<'A, 'B>> -> Brush<'T, 'X, 'Y> when 'B :> 'X
            abstract y: unit -> Brush.Scale<'Y>
            abstract y: y: Brush.Scale<'Y> -> Brush<'T, 'X, 'Y>
            abstract y: x: U2<D3.Scale.Ordinal<'A, 'B>, D3.Time.Scale<'A, 'B>> -> Brush<'T, 'X, 'Y> when 'B :> 'Y
            abstract extent: unit -> U3<'X * 'X, 'Y * 'Y, 'X * 'Y * 'X * 'Y> option
            abstract extent: extent: U3<'X * 'X, 'Y * 'Y, 'X * 'Y * 'X * 'Y> -> Brush<'T, 'X, 'Y>
            abstract clamp: unit -> U2<bool, bool * bool>
            abstract clamp: clamp: U2<bool, bool * bool> -> Brush<'T, 'X, 'Y>
            abstract clear: unit -> unit
            abstract empty: unit -> bool
            [<Emit "$0.on('brushstart')">] abstract on_brushstart: unit -> ('T -> float -> unit)
            [<Emit "$0.on('brush')">] abstract on_brush: unit -> ('T -> float -> unit)
            [<Emit "$0.on('brushend')">] abstract on_brushend: unit -> ('T -> float -> unit)
            abstract on: ``type``: string -> ('T -> float -> unit)
            [<Emit "$0.on('brushstart',$1)">] abstract on_brushstart: listener: ('T -> float -> unit) -> Brush<'T, 'X, 'Y>
            [<Emit "$0.on('brush',$1)">] abstract on_brush: listener: ('T -> float -> unit) -> Brush<'T, 'X, 'Y>
            [<Emit "$0.on('brushend',$1)">] abstract on_brushend: listener: ('T -> float -> unit) -> Brush<'T, 'X, 'Y>
            abstract on: ``type``: string * listener: ('T -> float -> unit) -> Brush<'T, 'X, 'Y>

        type [<AllowNullLiteral>] IExportsSymbolSymbol =
            interface end

        type [<AllowNullLiteral>] DiagonalSource =
            abstract x: float with get, set
            abstract y: float with get, set

    type [<AllowNullLiteral>] Xhr =
        abstract header: name: string -> string
        abstract header: name: string * value: string -> Xhr
        abstract mimeType: unit -> string
        abstract mimeType: ``type``: string -> Xhr
        abstract responseType: unit -> string
        abstract responseType: ``type``: string -> Xhr
        abstract response: unit -> (XMLHttpRequest -> obj option)
        abstract response: value: (XMLHttpRequest -> obj option) -> Xhr
        abstract get: ?callback: (obj option -> obj option -> unit) -> Xhr
        abstract post: ?data: obj * ?callback: (obj option -> obj option -> unit) -> Xhr
        abstract post: callback: (obj option -> obj option -> unit) -> Xhr
        abstract send: ``method``: string * ?data: obj * ?callback: (obj option -> obj option -> unit) -> Xhr
        abstract send: ``method``: string * callback: (obj option -> obj option -> unit) -> Xhr
        abstract abort: unit -> Xhr
        [<Emit "$0.on('beforesend')">] abstract on_beforesend: unit -> (XMLHttpRequest -> unit)
        [<Emit "$0.on('progress')">] abstract on_progress: unit -> (XMLHttpRequest -> unit)
        [<Emit "$0.on('load')">] abstract on_load: unit -> (obj option -> unit)
        [<Emit "$0.on('error')">] abstract on_error: unit -> (obj option -> unit)
        abstract on: ``type``: string -> (ResizeArray<obj option> -> unit)
        [<Emit "$0.on('beforesend',$1)">] abstract on_beforesend: listener: (XMLHttpRequest -> unit) -> Xhr
        [<Emit "$0.on('progress',$1)">] abstract on_progress: listener: (XMLHttpRequest -> unit) -> Xhr
        [<Emit "$0.on('load',$1)">] abstract on_load: listener: (obj option -> unit) -> Xhr
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (obj option -> unit) -> Xhr
        abstract on: ``type``: string * listener: (ResizeArray<obj option> -> unit) -> Xhr

    type [<AllowNullLiteral>] Dsv =
        [<Emit "$0($1...)">] abstract Invoke: url: string * callback: (ResizeArray<IExportsInterpolate> -> unit) -> DsvXhr<IExportsInterpolate>
        [<Emit "$0($1...)">] abstract Invoke: url: string * callback: (obj option -> ResizeArray<IExportsInterpolate> -> unit) -> DsvXhr<IExportsInterpolate>
        [<Emit "$0($1...)">] abstract Invoke: url: string -> DsvXhr<IExportsInterpolate>
        [<Emit "$0($1...)">] abstract Invoke: url: string * accessor: (IExportsInterpolate -> 'T) * callback: (ResizeArray<'T> -> unit) -> DsvXhr<'T>
        [<Emit "$0($1...)">] abstract Invoke: url: string * accessor: (IExportsInterpolate -> 'T) * callback: (obj option -> ResizeArray<'T> -> unit) -> DsvXhr<'T>
        [<Emit "$0($1...)">] abstract Invoke: url: string * accessor: (IExportsInterpolate -> 'T) -> DsvXhr<'T>
        abstract parse: string: string -> ResizeArray<IExportsInterpolate>
        abstract parse: string: string * accessor: (IExportsInterpolate -> float -> 'T) -> ResizeArray<'T>
        abstract parseRows: string: string -> ResizeArray<ResizeArray<string>>
        abstract parseRows: string: string * accessor: (ResizeArray<string> -> float -> 'T) -> ResizeArray<'T>
        abstract format: rows: ResizeArray<Object> -> string
        abstract formatRows: rows: ResizeArray<ResizeArray<string>> -> string

    type [<AllowNullLiteral>] DsvXhr<'T> =
        inherit Xhr
        abstract row: unit -> (IExportsInterpolate -> 'T)
        abstract row: accessor: (IExportsInterpolate -> 'U) -> DsvXhr<'U>
        abstract header: name: string -> string
        abstract header: name: string * value: string -> DsvXhr<'T>
        abstract mimeType: unit -> string
        abstract mimeType: ``type``: string -> DsvXhr<'T>
        abstract responseType: unit -> string
        abstract responseType: ``type``: string -> DsvXhr<'T>
        abstract response: unit -> (XMLHttpRequest -> obj option)
        abstract response: value: (XMLHttpRequest -> obj option) -> DsvXhr<'T>
        abstract get: ?callback: (XMLHttpRequest -> ResizeArray<'T> -> unit) -> DsvXhr<'T>
        abstract post: ?data: obj * ?callback: (XMLHttpRequest -> ResizeArray<'T> -> unit) -> DsvXhr<'T>
        abstract post: callback: (XMLHttpRequest -> ResizeArray<'T> -> unit) -> DsvXhr<'T>
        abstract send: ``method``: string * ?data: obj * ?callback: (XMLHttpRequest -> ResizeArray<'T> -> unit) -> DsvXhr<'T>
        abstract send: ``method``: string * callback: (XMLHttpRequest -> ResizeArray<'T> -> unit) -> DsvXhr<'T>
        abstract abort: unit -> DsvXhr<'T>
        [<Emit "$0.on('beforesend')">] abstract on_beforesend: unit -> (XMLHttpRequest -> unit)
        [<Emit "$0.on('progress')">] abstract on_progress: unit -> (XMLHttpRequest -> unit)
        [<Emit "$0.on('load')">] abstract on_load: unit -> (ResizeArray<'T> -> unit)
        [<Emit "$0.on('error')">] abstract on_error: unit -> (obj option -> unit)
        abstract on: ``type``: string -> (ResizeArray<obj option> -> unit)
        [<Emit "$0.on('beforesend',$1)">] abstract on_beforesend: listener: (XMLHttpRequest -> unit) -> DsvXhr<'T>
        [<Emit "$0.on('progress',$1)">] abstract on_progress: listener: (XMLHttpRequest -> unit) -> DsvXhr<'T>
        [<Emit "$0.on('load',$1)">] abstract on_load: listener: (ResizeArray<'T> -> unit) -> DsvXhr<'T>
        [<Emit "$0.on('error',$1)">] abstract on_error: listener: (obj option -> unit) -> DsvXhr<'T>
        abstract on: ``type``: string * listener: (ResizeArray<obj option> -> unit) -> DsvXhr<'T>

    type [<AllowNullLiteral>] LocaleDefinition =
        abstract decimal: string with get, set
        abstract thousands: string with get, set
        abstract grouping: ResizeArray<float> with get, set
        abstract currency: string * string with get, set
        abstract dateTime: string with get, set
        abstract date: string with get, set
        abstract time: string with get, set
        abstract periods: string * string with get, set
        abstract days: string * string * string * string * string * string * string with get, set
        abstract shortDays: string * string * string * string * string * string * string with get, set
        abstract months: string * string * string * string * string * string * string * string * string * string * string * string with get, set
        abstract shortMonths: string * string * string * string * string * string * string * string * string * string * string * string with get, set

    type [<AllowNullLiteral>] Locale =
        abstract numberFormat: specifier: string -> (float -> string)
        abstract timeFormat: LocaleTimeFormat with get, set

    module Layout =

        type [<AllowNullLiteral>] IExports =
            abstract bundle: unit -> Bundle<Bundle.Node>
            abstract bundle: unit -> Bundle<'T> when 'T :> Bundle.Node
            abstract chord: unit -> Chord
            abstract cluster: unit -> Cluster<Cluster.Result>
            abstract cluster: unit -> Cluster<'T> when 'T :> Cluster.Result
            //abstract force: unit -> Force<Force.Link<Force.Node>, Force.Node>
            abstract force: unit -> Force<Force.Link<'Node>, 'Node> when 'Node :> Force.Node
            abstract force: unit -> Force<'Link, 'Node> when 'Link :> Force.Link<Force.Node> and 'Node :> Force.Node
            abstract hierarchy: unit -> Hierarchy<Hierarchy.Result>
            abstract hierarchy: unit -> Hierarchy<'T> when 'T :> Hierarchy.Result
            abstract histogram: unit -> Histogram<float>
            abstract histogram: unit -> Histogram<'T>
            abstract pack: unit -> Pack<Pack.Node>
            abstract pack: unit -> Pack<'T> when 'T :> Pack.Node
            abstract partition: unit -> Partition<Partition.Node>
            abstract partition: unit -> Partition<'T> when 'T :> Partition.Node
            abstract pie: unit -> Pie<float>
            abstract pie: unit -> Pie<'T>
            abstract stack: unit -> Stack<ResizeArray<Stack.Value>, Stack.Value>
            abstract stack: unit -> Stack<ResizeArray<'Value>, 'Value>
            abstract stack: unit -> Stack<'Series, 'Value>
            abstract tree: unit -> Tree<Tree.Node>
            abstract tree: unit -> Tree<'T> when 'T :> Tree.Node
            abstract treemap: unit -> Treemap<Treemap.Node>
            abstract treemap: unit -> Treemap<'T> when 'T :> Treemap.Node

        module Bundle =

            type [<AllowNullLiteral>] Node =
                abstract parent: Node with get, set

            type [<AllowNullLiteral>] Link<'T when 'T :> Node> =
                abstract source: 'T with get, set
                abstract target: 'T with get, set

        type [<AllowNullLiteral>] Bundle<'T when 'T :> Bundle.Node> =
            [<Emit "$0($1...)">] abstract Invoke: links: ResizeArray<Bundle.Link<'T>> -> ResizeArray<ResizeArray<'T>>

        module Chord =

            type [<AllowNullLiteral>] Link =
                abstract source: Node with get, set
                abstract target: Node with get, set

            type [<AllowNullLiteral>] Node =
                abstract index: float with get, set
                abstract subindex: float with get, set
                abstract startAngle: float with get, set
                abstract endAngle: float with get, set
                abstract value: float with get, set

            type [<AllowNullLiteral>] Group =
                abstract index: float with get, set
                abstract startAngle: float with get, set
                abstract endAngle: float with get, set
                abstract value: float with get, set

        type [<AllowNullLiteral>] Chord =
            abstract matrix: unit -> ResizeArray<ResizeArray<float>>
            abstract matrix: matrix: ResizeArray<ResizeArray<float>> -> Chord
            abstract padding: unit -> float
            abstract padding: padding: float -> Chord
            abstract sortGroups: unit -> (float -> float -> float)
            abstract sortGroups: comparator: (float -> float -> float) -> Chord
            abstract sortSubgroups: unit -> (float -> float -> float)
            abstract sortSubgroups: comparator: (float -> float -> float) -> Chord
            abstract sortChords: unit -> (float -> float -> float)
            abstract sortChords: comparator: (float -> float -> float) -> Chord
            abstract chords: unit -> ResizeArray<Chord.Link>
            abstract groups: unit -> ResizeArray<Chord.Group>

        module Cluster =

            type [<AllowNullLiteral>] Result =
                abstract parent: Result option with get, set
                abstract children: ResizeArray<Result> option with get, set
                abstract depth: float option with get, set
                abstract x: float option with get, set
                abstract y: float option with get, set

            type [<AllowNullLiteral>] Link<'T when 'T :> Result> =
                abstract source: 'T with get, set
                abstract target: 'T with get, set

        type [<AllowNullLiteral>] Cluster<'T when 'T :> Cluster.Result> =
            [<Emit "$0($1...)">] abstract Invoke: root: 'T -> ResizeArray<'T>
            abstract nodes: root: 'T -> ResizeArray<'T>
            abstract links: nodes: ResizeArray<'T> -> ResizeArray<Cluster.Link<'T>>
            abstract children: unit -> ('T -> ResizeArray<'T>)
            abstract children: accessor: ('T -> ResizeArray<'T>) -> Cluster<'T>
            abstract sort: unit -> ('T -> 'T -> float)
            abstract sort: comparator: ('T -> 'T -> float) -> Cluster<'T>
            abstract separation: unit -> ('T -> 'T -> float)
            abstract separation: separation: ('T -> 'T -> float) -> Cluster<'T>
            abstract size: unit -> float * float
            abstract size: size: float * float -> Cluster<'T>
            abstract nodeSize: unit -> float * float
            abstract nodeSize: nodeSize: float * float -> Cluster<'T>
            abstract value: unit -> ('T -> float)
            abstract value: value: ('T -> float) -> Cluster<'T>

        module Force =

            type [<AllowNullLiteral>] Link<'T when 'T :> Node> =
                abstract source: U2<'T, float> with get, set
                abstract target: U2<'T, float> with get, set

            type [<AllowNullLiteral>] Node =
                abstract index: float option with get, set
                abstract x: float option with get, set
                abstract y: float option with get, set
                abstract px: float option with get, set
                abstract py: float option with get, set
                abstract ``fixed``: bool option with get, set
                abstract weight: float option with get, set

            type [<AllowNullLiteral>] Event =
                abstract ``type``: string with get, set
                abstract alpha: float with get, set

        type [<AllowNullLiteral>] Force<'Link, 'Node when 'Link :> Force.Link<Force.Node> and 'Node :> Force.Node> =
            abstract size: unit -> float * float
            abstract size: size: float * float -> Force<'Link, 'Node>
            abstract linkDistance: unit -> U2<float, ('Link -> float -> float)>
            abstract linkDistance: distance: float -> Force<'Link, 'Node>
            abstract linkDistance: distance: ('Link -> float -> float) -> Force<'Link, 'Node>
            abstract linkStrength: unit -> U2<float, ('Link -> float -> float)>
            abstract linkStrength: strength: float -> Force<'Link, 'Node>
            abstract linkStrength: strength: ('Link -> float -> float) -> Force<'Link, 'Node>
            abstract friction: unit -> float
            abstract friction: friction: float -> Force<'Link, 'Node>
            abstract charge: unit -> U2<float, ('Node -> float -> float)>
            abstract charge: charge: float -> Force<'Link, 'Node>
            abstract charge: charge: ('Node -> float -> float) -> Force<'Link, 'Node>
            abstract chargeDistance: unit -> float
            abstract chargeDistance: distance: float -> Force<'Link, 'Node>
            abstract theta: unit -> float
            abstract theta: theta: float -> Force<'Link, 'Node>
            abstract gravity: unit -> float
            abstract gravity: gravity: float -> Force<'Link, 'Node>
            abstract nodes: unit -> ResizeArray<'Node>
            abstract nodes: nodes: ResizeArray<'Node> -> Force<'Link, 'Node>
            abstract links: unit -> ResizeArray<'Link>
            abstract links: links: ResizeArray<ForceLinks> -> Force<'Link, 'Node>
            abstract links: links: ResizeArray<'Link> -> Force<'Link, 'Node>
            abstract start: unit -> Force<'Link, 'Node>
            abstract tick: unit -> Force<'Link, 'Node>
            abstract alpha: unit -> float
            abstract alpha: value: float -> Force<'Link, 'Node>
            abstract resume: unit -> Force<'Link, 'Node>
            abstract stop: unit -> Force<'Link, 'Node>
            abstract on: ``type``: string -> (Force.Event -> unit)
            abstract on: ``type``: string * listener: (Force.Event -> unit) -> Force<'Link, 'Node>
            abstract drag: unit -> Behavior.Drag<'Node>
            abstract drag: selection: Selection<'Node> -> unit

        module Hierarchy =

            type [<AllowNullLiteral>] Result =
                abstract parent: Result option with get, set
                abstract children: ResizeArray<Result> option with get, set
                abstract value: float option with get, set
                abstract depth: float option with get, set

        type [<AllowNullLiteral>] Hierarchy<'T when 'T :> Hierarchy.Result> =
            [<Emit "$0($1...)">] abstract Invoke: root: 'T -> ResizeArray<'T>
            abstract children: unit -> ('T -> ResizeArray<'T>)
            abstract children: accessor: ('T -> ResizeArray<'T>) -> Hierarchy<'T>
            abstract sort: unit -> ('T -> 'T -> float)
            abstract sort: comparator: ('T -> 'T -> float) -> Hierarchy<'T>
            abstract value: unit -> ('T -> float)
            abstract value: accessor: ('T -> float) -> Hierarchy<'T>
            abstract revalue: root: 'T -> ResizeArray<'T>

        module Histogram =

            type [<AllowNullLiteral>] Bin<'T> =
                inherit Array<'T>
                abstract x: float with get, set
                abstract dx: float with get, set
                abstract y: float with get, set

        type [<AllowNullLiteral>] Histogram<'T> =
            [<Emit "$0($1...)">] abstract Invoke: values: ResizeArray<'T> * ?index: float -> ResizeArray<Histogram.Bin<'T>>
            abstract value: unit -> ('T -> float -> float)
            abstract value: value: ('T -> float -> float) -> Histogram<'T>
            abstract range: unit -> (ResizeArray<'T> -> float -> float * float)
            abstract range: range: (ResizeArray<'T> -> float -> float * float) -> Histogram<'T>
            abstract range: range: float * float -> Histogram<'T>
            abstract bins: unit -> (float * float -> ResizeArray<'T> -> float -> ResizeArray<float>)
            abstract bins: count: float -> Histogram<'T>
            abstract bins: thresholds: ResizeArray<float> -> Histogram<'T>
            abstract bins: func: (float * float -> ResizeArray<'T> -> float -> ResizeArray<float>) -> Histogram<'T>
            abstract frequency: unit -> bool
            abstract frequency: frequency: bool -> Histogram<'T>

        module Pack =

            type [<AllowNullLiteral>] Node =
                abstract parent: Node option with get, set
                abstract children: ResizeArray<Node> option with get, set
                abstract value: float option with get, set
                abstract depth: float option with get, set
                abstract x: float option with get, set
                abstract y: float option with get, set
                abstract r: float option with get, set

            type [<AllowNullLiteral>] Link<'T when 'T :> Node> =
                abstract source: Node with get, set
                abstract target: Node with get, set

        type [<AllowNullLiteral>] Pack<'T when 'T :> Pack.Node> =
            [<Emit "$0($1...)">] abstract Invoke: root: 'T -> ResizeArray<'T>
            abstract nodes: root: 'T -> ResizeArray<'T>
            abstract links: nodes: ResizeArray<'T> -> ResizeArray<Pack.Link<'T>>
            abstract children: unit -> ('T -> float -> ResizeArray<'T>)
            abstract children: children: ('T -> float -> ResizeArray<'T>) -> Pack<'T>
            abstract sort: unit -> ('T -> 'T -> float)
            abstract sort: comparator: ('T -> 'T -> float) -> Pack<'T>
            abstract value: unit -> ('T -> float)
            abstract value: value: ('T -> float) -> Pack<'T>
            abstract size: unit -> float * float
            abstract size: size: float * float -> Pack<'T>
            abstract radius: unit -> U2<float, ('T -> float)>
            abstract radius: radius: float -> Pack<'T>
            abstract radius: radius: ('T -> float) -> Pack<'T>
            abstract padding: unit -> float
            abstract padding: padding: float -> Pack<'T>

        module Partition =

            type [<AllowNullLiteral>] Link<'T when 'T :> Node> =
                abstract source: 'T with get, set
                abstract target: 'T with get, set

            type [<AllowNullLiteral>] Node =
                abstract parent: Node option with get, set
                abstract children: ResizeArray<Node> option with get, set
                abstract value: float option with get, set
                abstract depth: float option with get, set
                abstract x: float option with get, set
                abstract y: float option with get, set
                abstract dx: float option with get, set
                abstract dy: float option with get, set

        type [<AllowNullLiteral>] Partition<'T when 'T :> Partition.Node> =
            [<Emit "$0($1...)">] abstract Invoke: root: 'T -> ResizeArray<'T>
            abstract nodes: root: 'T -> ResizeArray<'T>
            abstract links: nodes: ResizeArray<'T> -> ResizeArray<Partition.Link<'T>>
            abstract children: unit -> ('T -> float -> ResizeArray<'T>)
            abstract children: children: ('T -> float -> ResizeArray<'T>) -> Partition<'T>
            abstract sort: unit -> ('T -> 'T -> float)
            abstract sort: comparator: ('T -> 'T -> float) -> Partition<'T>
            abstract value: unit -> ('T -> float)
            abstract value: value: ('T -> float) -> Partition<'T>
            abstract size: unit -> float * float
            abstract size: size: float * float -> Partition<'T>

        module Pie =

            type [<AllowNullLiteral>] Arc<'T> =
                abstract value: float with get, set
                abstract startAngle: float with get, set
                abstract endAngle: float with get, set
                abstract padAngle: float with get, set
                abstract data: 'T with get, set

        type [<AllowNullLiteral>] Pie<'T> =
            [<Emit "$0($1...)">] abstract Invoke: data: ResizeArray<'T> * ?index: float -> ResizeArray<Pie.Arc<'T>>
            abstract value: unit -> ('T -> float -> float)
            abstract value: accessor: ('T -> float -> float) -> Pie<'T>
            abstract sort: unit -> ('T -> 'T -> float)
            abstract sort: comparator: ('T -> 'T -> float) -> Pie<'T>
            abstract startAngle: unit -> U2<float, (ResizeArray<'T> -> float -> float)>
            abstract startAngle: angle: float -> Pie<'T>
            abstract startAngle: angle: (ResizeArray<'T> -> float -> float) -> Pie<'T>
            abstract endAngle: unit -> U2<float, (ResizeArray<'T> -> float -> float)>
            abstract endAngle: angle: float -> Pie<'T>
            abstract endAngle: angle: (ResizeArray<'T> -> float -> float) -> Pie<'T>
            abstract padAngle: unit -> U2<float, (ResizeArray<'T> -> float -> float)>
            abstract padAngle: angle: float -> Pie<'T>
            abstract padAngle: angle: (ResizeArray<'T> -> float -> float) -> Pie<'T>

        module Stack =

            type [<AllowNullLiteral>] Value =
                abstract x: float with get, set
                abstract y: float with get, set
                abstract y0: float option with get, set

        type [<AllowNullLiteral>] Stack<'Series, 'Value> =
            [<Emit "$0($1...)">] abstract Invoke: layers: ResizeArray<'Series> * ?index: float -> ResizeArray<'Series>
            abstract values: unit -> ('Series -> float -> ResizeArray<'Value>)
            abstract values: accessor: ('Series -> float -> ResizeArray<'Value>) -> Stack<'Series, 'Value>
            abstract offset: unit -> (Array<float * float> -> ResizeArray<float>)
            [<Emit "$0.offset('silhouette')">] abstract offset_silhouette: unit -> Stack<'Series, 'Value>
            [<Emit "$0.offset('wiggle')">] abstract offset_wiggle: unit -> Stack<'Series, 'Value>
            [<Emit "$0.offset('expand')">] abstract offset_expand: unit -> Stack<'Series, 'Value>
            [<Emit "$0.offset('zero')">] abstract offset_zero: unit -> Stack<'Series, 'Value>
            abstract offset: offset: string -> Stack<'Series, 'Value>
            abstract offset: offset: (Array<float * float> -> ResizeArray<float>) -> Stack<'Series, 'Value>
            abstract order: unit -> (Array<float * float> -> ResizeArray<float>)
            [<Emit "$0.order('inside-out')">] abstract ``order_inside-out``: unit -> Stack<'Series, 'Value>
            [<Emit "$0.order('reverse')">] abstract order_reverse: unit -> Stack<'Series, 'Value>
            [<Emit "$0.order('default')">] abstract order_default: unit -> Stack<'Series, 'Value>
            abstract order: order: string -> Stack<'Series, 'Value>
            abstract order: order: (Array<float * float> -> ResizeArray<float>) -> Stack<'Series, 'Value>
            abstract x: unit -> ('Value -> float -> float)
            abstract x: accessor: ('Value -> float -> float) -> Stack<'Series, 'Value>
            abstract y: unit -> ('Value -> float -> float)
            abstract y: accesor: ('Value -> float -> float) -> Stack<'Series, 'Value>
            abstract out: unit -> ('Value -> float -> float -> unit)
            abstract out: setter: ('Value -> float -> float -> unit) -> Stack<'Series, 'Value>

        module Tree =

            type [<AllowNullLiteral>] Link<'T when 'T :> Node> =
                abstract source: 'T with get, set
                abstract target: 'T with get, set

            type [<AllowNullLiteral>] Node =
                abstract parent: Node option with get, set
                abstract children: ResizeArray<Node> option with get, set
                abstract depth: float option with get, set
                abstract x: float option with get, set
                abstract y: float option with get, set

        type [<AllowNullLiteral>] Tree<'T> when 'T :> Tree.Node =
            [<Emit "$0($1...)">] abstract Invoke: root: 'T * ?index: float -> ResizeArray<'T>
            abstract nodes: root: 'T * ?index: float -> ResizeArray<'T>
            abstract links: nodes: ResizeArray<'T> -> ResizeArray<Tree.Link<'T>>
            abstract children: unit -> ('T -> float -> ResizeArray<'T>)
            abstract children: children: ('T -> float -> ResizeArray<'T>) -> Tree<'T>
            abstract separation: unit -> ('T -> 'T -> float)
            abstract separation: separation: ('T -> 'T -> float) -> Tree<'T>
            abstract size: unit -> float * float
            abstract size: size: float * float -> Tree<'T>
            abstract nodeSize: unit -> float * float
            abstract nodeSize: size: float * float -> Tree<'T>
            abstract sort: unit -> ('T -> 'T -> float)
            abstract sort: comparator: ('T -> 'T -> float) -> Tree<'T>
            abstract value: unit -> ('T -> float -> float)
            abstract value: value: ('T -> float -> float) -> Tree<'T>

        module Treemap =

            type [<AllowNullLiteral>] Node =
                abstract parent: Node option with get, set
                abstract children: ResizeArray<Node> option with get, set
                abstract value: float option with get, set
                abstract depth: float option with get, set
                abstract x: float option with get, set
                abstract y: float option with get, set
                abstract dx: float option with get, set
                abstract dy: float option with get, set

            type [<AllowNullLiteral>] Link<'T when 'T :> Node> =
                abstract source: 'T with get, set
                abstract target: 'T with get, set

            type Padding =
                U2<float, float * float * float * float>

        type [<AllowNullLiteral>] Treemap<'T when 'T :> Treemap.Node> =
            [<Emit "$0($1...)">] abstract Invoke: root: 'T * ?index: float -> ResizeArray<'T>
            abstract nodes: root: 'T * ?index: float -> ResizeArray<'T>
            abstract links: nodes: ResizeArray<'T> -> ResizeArray<Treemap.Link<'T>>
            abstract children: unit -> ('T -> float -> ResizeArray<'T>)
            abstract children: children: ('T -> float -> ResizeArray<'T>) -> Treemap<'T>
            abstract sort: unit -> ('T -> 'T -> float)
            abstract sort: comparator: ('T -> 'T -> float) -> Treemap<'T>
            abstract value: unit -> ('T -> float -> float)
            abstract value: value: ('T -> float -> float) -> Treemap<'T>
            abstract size: unit -> float * float
            abstract size: size: float * float -> Treemap<'T>
            abstract padding: unit -> ('T -> float -> Treemap.Padding)
            abstract padding: padding: Treemap.Padding -> Treemap<'T>
            abstract padding: padding: ('T -> float -> Treemap.Padding) -> Treemap<'T>
            abstract round: unit -> bool
            abstract round: round: bool -> Treemap<'T>
            abstract sticky: unit -> bool
            abstract sticky: sticky: bool -> Treemap<'T>
            abstract mode: unit -> string
            [<Emit "$0.mode('squarify')">] abstract mode_squarify: unit -> Treemap<'T>
            [<Emit "$0.mode('slice')">] abstract mode_slice: unit -> Treemap<'T>
            [<Emit "$0.mode('dice')">] abstract mode_dice: unit -> Treemap<'T>
            [<Emit "$0.mode('slice-dice')">] abstract ``mode_slice-dice``: unit -> Treemap<'T>
            abstract mode: mode: string -> Treemap<'T>
            abstract ratio: unit -> float
            abstract ratio: ratio: float -> Treemap<'T>

        type [<AllowNullLiteral>] ForceLinks =
            abstract source: float with get, set
            abstract target: float with get, set

    module Geom =

        type [<AllowNullLiteral>] IExports =
            abstract voronoi: unit -> Voronoi<float * float>
            abstract voronoi: unit -> Voronoi<'T>
            abstract delaunay: vertices: Array<float * float> -> Array<float * float * float * float * float * float>
            abstract quadtree: unit -> Quadtree<float * float>
            abstract quadtree: nodes: ResizeArray<'T> * ?x1: float * ?y1: float * ?x2: float * ?y2: float -> Quadtree.Quadtree<'T>
            abstract hull: vertices: Array<float * float> -> Array<float * float>
            abstract hull: unit -> Hull<float * float>
            abstract hull: unit -> Hull<'T>
            abstract polygon: vertices: Array<float * float> -> Polygon

        module Voronoi =

            type [<AllowNullLiteral>] Link<'T> =
                abstract source: 'T with get, set
                abstract target: 'T with get, set

        type [<AllowNullLiteral>] Voronoi<'T> =
            [<Emit "$0($1...)">] abstract Invoke: data: ResizeArray<'T> -> Array<float * float>
            abstract x: unit -> ('T -> float)
            abstract x: x: ('T -> float) -> Voronoi<'T>
            abstract y: unit -> ('T -> float)
            abstract y: y: ('T -> float) -> Voronoi<'T>
            abstract clipExtent: unit -> float * float * float * float
            abstract clipExtent: extent: float * float * float * float -> Voronoi<'T>
            abstract links: data: ResizeArray<'T> -> ResizeArray<Voronoi.Link<'T>>
            abstract triangles: data: ResizeArray<'T> -> Array<'T * 'T * 'T>

        module Quadtree =

            type [<AllowNullLiteral>] Node<'T> =
                abstract nodes: Node<'T> * Node<'T> * Node<'T> * Node<'T> with get, set
                abstract leaf: bool with get, set
                abstract point: 'T with get, set
                abstract x: float with get, set
                abstract y: float with get, set

            type [<AllowNullLiteral>] Quadtree<'T> =
                inherit Node<'T>
                abstract add: point: 'T -> unit
                abstract visit: callback: (Node<'T> -> float -> float -> float -> float -> U2<bool, unit>) -> unit
                abstract find: point: float * float -> 'T

        type [<AllowNullLiteral>] Quadtree<'T> =
            [<Emit "$0($1...)">] abstract Invoke: points: ResizeArray<'T> -> Quadtree.Quadtree<'T>
            abstract x: unit -> ('T -> float -> float)
            abstract x: x: float -> Quadtree<'T>
            abstract x: x: ('T -> float -> float) -> Quadtree<'T>
            abstract y: unit -> ('T -> float -> float)
            abstract y: y: float -> Quadtree<'T>
            abstract y: y: ('T -> float -> float) -> Quadtree<'T>
            abstract extent: unit -> float * float * float * float
            abstract extent: extent: float * float * float * float -> Quadtree<'T>

        type [<AllowNullLiteral>] Hull<'T> =
            [<Emit "$0($1...)">] abstract Invoke: vertices: ResizeArray<'T> -> Array<float * float>
            abstract x: unit -> ('T -> float)
            abstract x: x: ('T -> float) -> Hull<'T>
            abstract y: unit -> ('T -> float)
            abstract y: y: ('T -> float) -> Hull<'T>

        type [<AllowNullLiteral>] Polygon =
            abstract area: unit -> float
            abstract centroid: unit -> float * float
            abstract clip: subject: Array<float * float> -> Array<float * float>

    type [<AllowNullLiteral>] IExportsEntries<'T> =
        abstract key: string with get, set
        abstract value: 'T with get, set

    type [<AllowNullLiteral>] IExportsEntries2 =
        abstract key: string with get, set
        abstract value: obj option with get, set

    type [<AllowNullLiteral>] IExportsRgb =
        [<Emit "new $0($1...)">] abstract Create: r: float * g: float * b: float -> obj
        [<Emit "new $0($1...)">] abstract Create: color: string -> obj
        [<Emit "$0($1...)">] abstract Invoke: r: float * g: float * b: float -> Rgb
        [<Emit "$0($1...)">] abstract Invoke: color: string -> Rgb

    type [<AllowNullLiteral>] IExportsHsl =
        [<Emit "new $0($1...)">] abstract Create: h: float * s: float * l: float -> obj
        [<Emit "new $0($1...)">] abstract Create: color: string -> obj
        [<Emit "$0($1...)">] abstract Invoke: h: float * s: float * l: float -> Hsl
        [<Emit "$0($1...)">] abstract Invoke: color: string -> Hsl

    type [<AllowNullLiteral>] IExportsHcl =
        [<Emit "new $0($1...)">] abstract Create: h: float * c: float * l: float -> obj
        [<Emit "new $0($1...)">] abstract Create: color: string -> obj
        [<Emit "$0($1...)">] abstract Invoke: h: float * c: float * l: float -> Hcl
        [<Emit "$0($1...)">] abstract Invoke: color: string -> Hcl

    type [<AllowNullLiteral>] IExportsLab =
        [<Emit "new $0($1...)">] abstract Create: l: float * a: float * b: float -> obj
        [<Emit "new $0($1...)">] abstract Create: color: string -> obj
        [<Emit "$0($1...)">] abstract Invoke: l: float * a: float * b: float -> Lab
        [<Emit "$0($1...)">] abstract Invoke: color: string -> Lab

    type [<AllowNullLiteral>] IExportsColor =
        [<Emit "$0($1...)">] abstract Invoke: unit -> Color
        [<Emit "new $0($1...)">] abstract Create: unit -> obj

    type [<AllowNullLiteral>] IExportsInterpolate =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> string with get, set

    type [<AllowNullLiteral>] IExportsInterpolate2<'Output> =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> 'Output with get, set

    type [<AllowNullLiteral>] NestEntries =
        abstract key: string with get, set
        abstract values: obj option with get, set

    type [<AllowNullLiteral>] LocaleTimeFormat =
        [<Emit "$0($1...)">] abstract Invoke: specifier: string -> Time.Format
        abstract utc: specifier: string -> Time.Format
        abstract multi: formats: Array<string * (DateTime -> U2<bool, float>)> -> Time.Format

type [<AllowNullLiteral>] TouchList =
    interface end