namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS

module Moment =
    type MomentComparable = obj

    and [<AllowNullLiteral>] MomentDateObject =
        abstract years: float option with get, set
        abstract months: float option with get, set
        abstract date: float option with get, set
        abstract hours: float option with get, set
        abstract minutes: float option with get, set
        abstract seconds: float option with get, set
        abstract milliseconds: float option with get, set

    and [<AllowNullLiteral>] MomentInput =
        abstract years: float option with get, set
        abstract year: float option with get, set
        abstract y: float option with get, set
        abstract months: float option with get, set
        abstract month: float option with get, set
        abstract M: float option with get, set
        abstract weeks: float option with get, set
        abstract week: float option with get, set
        abstract w: float option with get, set
        abstract days: float option with get, set
        abstract day: float option with get, set
        abstract date: float option with get, set
        abstract d: float option with get, set
        abstract hours: float option with get, set
        abstract hour: float option with get, set
        abstract h: float option with get, set
        abstract minutes: float option with get, set
        abstract minute: float option with get, set
        abstract m: float option with get, set
        abstract seconds: float option with get, set
        abstract second: float option with get, set
        abstract s: float option with get, set
        abstract milliseconds: float option with get, set
        abstract millisecond: float option with get, set
        abstract ms: float option with get, set

    and [<AllowNullLiteral>] Duration =
        abstract humanize: ?withSuffix: bool -> string
        abstract ``as``: units: string -> float
        abstract milliseconds: unit -> float
        abstract asMilliseconds: unit -> float
        abstract seconds: unit -> float
        abstract asSeconds: unit -> float
        abstract minutes: unit -> float
        abstract asMinutes: unit -> float
        abstract hours: unit -> float
        abstract asHours: unit -> float
        abstract days: unit -> float
        abstract asDays: unit -> float
        abstract weeks: unit -> float
        abstract asWeeks: unit -> float
        abstract months: unit -> float
        abstract asMonths: unit -> float
        abstract years: unit -> float
        abstract asYears: unit -> float
        abstract add: n: float * p: string -> Duration
        abstract add: n: float -> Duration
        abstract add: d: Duration -> Duration
        abstract subtract: n: float * p: string -> Duration
        abstract subtract: n: float -> Duration
        abstract subtract: d: Duration -> Duration
        abstract toISOString: unit -> string
        abstract toJSON: unit -> string

    and [<AllowNullLiteral>] MomentLocale =
        abstract ordinal: n: float -> string

    and [<AllowNullLiteral>] MomentCreationData =
        abstract input: string option with get, set
        abstract format: string option with get, set
        abstract locale: MomentLocale with get, set
        abstract isUTC: bool with get, set
        abstract strict: bool option with get, set

    and [<AllowNullLiteral>] Moment =
        abstract format: format: string -> string
        abstract format: unit -> string
        abstract fromNow: ?withoutSuffix: bool -> string
        abstract startOf: unitOfTime: string -> Moment
        abstract endOf: unitOfTime: string -> Moment
        abstract add: unitOfTime: string * amount: float -> Moment
        abstract add: amount: float * unitOfTime: string -> Moment
        abstract add: amount: string * unitOfTime: string -> Moment
        abstract add: objectLiteral: MomentInput -> Moment
        abstract add: duration: Duration -> Moment
        abstract subtract: unitOfTime: string * amount: float -> Moment
        abstract subtract: amount: float * unitOfTime: string -> Moment
        abstract subtract: amount: string * unitOfTime: string -> Moment
        abstract subtract: objectLiteral: MomentInput -> Moment
        abstract subtract: duration: Duration -> Moment
        abstract calendar: unit -> string
        abstract calendar: start: Moment -> string
        abstract calendar: start: Moment * formats: MomentCalendar -> string
        abstract clone: unit -> Moment
        abstract valueOf: unit -> float
        abstract local: unit -> Moment
        abstract utc: unit -> Moment
        abstract isValid: unit -> bool
        abstract invalidAt: unit -> float
        abstract year: y: float -> Moment
        abstract year: unit -> float
        abstract quarter: unit -> float
        abstract quarter: q: float -> Moment
        abstract month: M: float -> Moment
        abstract month: M: string -> Moment
        abstract month: unit -> float
        abstract day: d: float -> Moment
        abstract day: d: string -> Moment
        abstract day: unit -> float
        abstract date: d: float -> Moment
        abstract date: unit -> float
        abstract hour: h: float -> Moment
        abstract hour: unit -> float
        abstract hours: h: float -> Moment
        abstract hours: unit -> float
        abstract minute: m: float -> Moment
        abstract minute: unit -> float
        abstract minutes: m: float -> Moment
        abstract minutes: unit -> float
        abstract second: s: float -> Moment
        abstract second: unit -> float
        abstract seconds: s: float -> Moment
        abstract seconds: unit -> float
        abstract millisecond: ms: float -> Moment
        abstract millisecond: unit -> float
        abstract milliseconds: ms: float -> Moment
        abstract milliseconds: unit -> float
        abstract weekday: unit -> float
        abstract weekday: d: float -> Moment
        abstract isoWeekday: unit -> float
        abstract isoWeekday: d: float -> Moment
        abstract weekYear: unit -> float
        abstract weekYear: d: float -> Moment
        abstract isoWeekYear: unit -> float
        abstract isoWeekYear: d: float -> Moment
        abstract week: unit -> float
        abstract week: d: float -> Moment
        abstract weeks: unit -> float
        abstract weeks: d: float -> Moment
        abstract isoWeek: unit -> float
        abstract isoWeek: d: float -> Moment
        abstract isoWeeks: unit -> float
        abstract isoWeeks: d: float -> Moment
        abstract weeksInYear: unit -> float
        abstract isoWeeksInYear: unit -> float
        abstract dayOfYear: unit -> float
        abstract dayOfYear: d: float -> Moment
        abstract from: f: MomentComparable * ?suffix: bool -> string
        abstract ``to``: f: MomentComparable * ?suffix: bool -> string
        abstract toNow: ?withoutPrefix: bool -> string
        abstract diff: b: MomentComparable -> float
        abstract diff: b: MomentComparable * unitOfTime: string -> float
        abstract diff: b: MomentComparable * unitOfTime: string * round: bool -> float
        abstract toArray: unit -> ResizeArray<float>
        abstract toDate: unit -> DateTime
        abstract toISOString: unit -> string
        abstract toJSON: unit -> string
        abstract unix: unit -> float
        abstract isLeapYear: unit -> bool
        abstract zone: unit -> float
        abstract zone: b: float -> Moment
        abstract zone: b: string -> Moment
        abstract utcOffset: unit -> float
        abstract utcOffset: b: float -> Moment
        abstract utcOffset: b: string -> Moment
        abstract daysInMonth: unit -> float
        abstract isDST: unit -> bool
        abstract isBefore: unit -> bool
        abstract isBefore: b: MomentComparable * ?granularity: string -> bool
        abstract isAfter: unit -> bool
        abstract isAfter: b: MomentComparable * ?granularity: string -> bool
        abstract isSame: b: MomentComparable * ?granularity: string -> bool
        abstract isBetween: a: MomentComparable * b: MomentComparable * ?granularity: string * ?inclusivity: string -> bool
        abstract isSameOrBefore: b: MomentComparable * ?granularity: string -> bool
        abstract isSameOrAfter: b: MomentComparable * ?granularity: string -> bool
        abstract lang: language: string -> Moment
        abstract lang: reset: bool -> Moment
        abstract lang: unit -> MomentLanguage
        abstract locale: language: string -> Moment
        abstract locale: reset: bool -> Moment
        abstract locale: unit -> string
        abstract locales: unit -> ResizeArray<string>
        abstract localeData: language: string -> Moment
        abstract localeData: reset: bool -> Moment
        abstract localeData: unit -> MomentLanguage
        abstract max: date: obj -> Moment
        abstract max: date: string * format: string -> Moment
        abstract min: date: obj -> Moment
        abstract min: date: string * format: string -> Moment
        abstract get: unit: string -> float
        abstract set: unit: string * value: float -> Moment
        abstract set: objectLiteral: MomentInput -> Moment
        abstract toObject: unit -> MomentDateObject
        abstract creationData: unit -> MomentCreationData

    and formatFunction = Func<string>

    and [<AllowNullLiteral>] MomentCalendar =
        abstract lastDay: U2<string, formatFunction> option with get, set
        abstract sameDay: U2<string, formatFunction> option with get, set
        abstract nextDay: U2<string, formatFunction> option with get, set
        abstract lastWeek: U2<string, formatFunction> option with get, set
        abstract nextWeek: U2<string, formatFunction> option with get, set
        abstract sameElse: U2<string, formatFunction> option with get, set

    and [<AllowNullLiteral>] BaseMomentLanguage =
        abstract months: obj option with get, set
        abstract monthsShort: obj option with get, set
        abstract weekdays: obj option with get, set
        abstract weekdaysShort: obj option with get, set
        abstract weekdaysMin: obj option with get, set
        abstract relativeTime: MomentRelativeTime option with get, set
        abstract meridiem: Func<float, float, bool, string> option with get, set
        abstract calendar: MomentCalendar option with get, set
        abstract ordinal: Func<float, string> option with get, set
        abstract week: MomentLanguageWeek option with get, set

    and [<AllowNullLiteral>] MomentLanguage =
        inherit BaseMomentLanguage
        abstract longDateFormat: MomentLongDateFormat option with get, set

    and [<AllowNullLiteral>] MomentLanguageWeek =
        abstract dow: float option with get, set
        abstract doy: float option with get, set

    and [<AllowNullLiteral>] MomentLanguageData =
        abstract months: aMoment: Moment -> string
        abstract monthsShort: aMoment: Moment -> string
        abstract monthsParse: longOrShortMonthString: string -> float
        abstract weekdays: aMoment: Moment -> string
        abstract weekdaysShort: aMoment: Moment -> string
        abstract weekdaysMin: aMoment: Moment -> string
        abstract weekdaysParse: longOrShortMonthString: string -> float
        abstract longDateFormat: dateFormat: string -> string
        abstract isPM: amPmString: string -> bool
        abstract meridiem: hour: float * minute: float * isLowercase: bool -> string
        abstract calendar: key: string * aMoment: Moment -> string
        abstract relativeTime: number: float * withoutSuffix: bool * key: string * isFuture: bool -> string
        abstract pastFuture: diff: float * relTime: string -> string
        abstract ordinal: number: float -> string
        abstract preparse: str: string -> string
        abstract postformat: str: string -> string
        abstract week: aMoment: Moment -> float
        abstract invalidDate: unit -> string
        abstract firstDayOfWeek: unit -> float
        abstract firstDayOfYear: unit -> float

    and [<AllowNullLiteral>] MomentLongDateFormat =
        abstract L: string with get, set
        abstract LL: string with get, set
        abstract LLL: string with get, set
        abstract LLLL: string with get, set
        abstract LT: string with get, set
        abstract LTS: string with get, set
        abstract l: string option with get, set
        abstract ll: string option with get, set
        abstract lll: string option with get, set
        abstract llll: string option with get, set
        abstract lt: string option with get, set
        abstract lts: string option with get, set

    and [<AllowNullLiteral>] MomentRelativeTime =
        abstract future: obj with get, set
        abstract past: obj with get, set
        abstract s: obj with get, set
        abstract m: obj with get, set
        abstract mm: obj with get, set
        abstract h: obj with get, set
        abstract hh: obj with get, set
        abstract d: obj with get, set
        abstract dd: obj with get, set
        abstract M: obj with get, set
        abstract MM: obj with get, set
        abstract y: obj with get, set
        abstract yy: obj with get, set

    and [<AllowNullLiteral>] MomentBuiltinFormat =
        abstract ___momentBuiltinFormatBrand: obj with get, set

    and MomentFormatSpecification = U3<string, MomentBuiltinFormat, ResizeArray<U2<string, MomentBuiltinFormat>>>

    and [<AllowNullLiteral>] MomentStatic =
        abstract version: string with get, set
        abstract fn: Moment with get, set
        abstract longDateFormat: obj with get, set
        abstract relativeTime: obj with get, set
        abstract meridiem: Func<float, float, bool, string> with get, set
        abstract calendar: obj with get, set
        abstract ordinal: Func<float, string> with get, set
        abstract ISO_8601: MomentBuiltinFormat with get, set
        abstract defaultFormat: string with get, set
        [<Emit("$0($1...)")>] abstract Invoke: unit -> Moment
        [<Emit("$0($1...)")>] abstract Invoke: date: float -> Moment
        [<Emit("$0($1...)")>] abstract Invoke: date: ResizeArray<float> -> Moment
        [<Emit("$0($1...)")>] abstract Invoke: date: string * ?format: MomentFormatSpecification * ?strict: bool -> Moment
        [<Emit("$0($1...)")>] abstract Invoke: date: string * ?format: MomentFormatSpecification * ?language: string * ?strict: bool -> Moment
        [<Emit("$0($1...)")>] abstract Invoke: date: DateTime -> Moment
        [<Emit("$0($1...)")>] abstract Invoke: date: Moment -> Moment
        [<Emit("$0($1...)")>] abstract Invoke: date: obj -> Moment
        abstract utc: unit -> Moment
        abstract utc: date: float -> Moment
        abstract utc: date: ResizeArray<float> -> Moment
        abstract utc: date: string * ?format: string * ?strict: bool -> Moment
        abstract utc: date: string * ?format: string * ?language: string * ?strict: bool -> Moment
        abstract utc: date: string * formats: ResizeArray<string> * ?strict: bool -> Moment
        abstract utc: date: string * formats: ResizeArray<string> * ?language: string * ?strict: bool -> Moment
        abstract utc: date: DateTime -> Moment
        abstract utc: date: Moment -> Moment
        abstract utc: date: obj -> Moment
        abstract unix: timestamp: float -> Moment
        abstract invalid: ?parsingFlags: obj -> Moment
        abstract isMoment: unit -> bool
        abstract isMoment: m: obj -> obj
        abstract isDate: m: obj -> obj
        abstract isDuration: unit -> bool
        abstract isDuration: d: obj -> obj
        abstract lang: ?language: string -> string
        abstract lang: ?language: string * ?definition: MomentLanguage -> string
        abstract locale: ?language: string -> string
        abstract locale: ?language: ResizeArray<string> -> string
        abstract locale: ?language: string * ?definition: MomentLanguage -> string
        abstract localeData: ?language: string -> MomentLanguageData
        abstract duration: milliseconds: float -> Duration
        abstract duration: num: float * unitOfTime: string -> Duration
        abstract duration: input: MomentInput -> Duration
        abstract duration: ``object``: obj -> Duration
        abstract duration: unit -> Duration
        abstract parseZone: date: string -> Moment
        abstract months: unit -> ResizeArray<string>
        abstract months: index: float -> string
        abstract months: format: string -> ResizeArray<string>
        abstract months: format: string * index: float -> string
        abstract monthsShort: unit -> ResizeArray<string>
        abstract monthsShort: index: float -> string
        abstract monthsShort: format: string -> ResizeArray<string>
        abstract monthsShort: format: string * index: float -> string
        abstract weekdays: unit -> ResizeArray<string>
        abstract weekdays: index: float -> string
        abstract weekdays: format: string -> ResizeArray<string>
        abstract weekdays: format: string * index: float -> string
        abstract weekdaysShort: unit -> ResizeArray<string>
        abstract weekdaysShort: index: float -> string
        abstract weekdaysShort: format: string -> ResizeArray<string>
        abstract weekdaysShort: format: string * index: float -> string
        abstract weekdaysMin: unit -> ResizeArray<string>
        abstract weekdaysMin: index: float -> string
        abstract weekdaysMin: format: string -> ResizeArray<string>
        abstract weekdaysMin: format: string * index: float -> string
        abstract min: [<ParamArray>] moments: Moment[] -> Moment
        abstract max: [<ParamArray>] moments: Moment[] -> Moment
        abstract normalizeUnits: unit: string -> string
        abstract relativeTimeThreshold: threshold: string -> U2<float, bool>
        abstract relativeTimeThreshold: threshold: string * limit: float -> bool
        abstract now: unit -> float

    let [<Import("*","moment")>] Global: MomentStatic = failwith "JS only"

