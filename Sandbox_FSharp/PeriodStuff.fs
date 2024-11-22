module Sandbox_FSharp.PeriodStuff

open System

let MinDateTimeOffset (date1: DateTimeOffset) (date2: DateTimeOffset) = 
    if date1 < date2 then date1 else date2
    
let MaxDateTimeOffset (date1: DateTimeOffset) (date2: DateTimeOffset) =
    if date1 > date2 then date1 else date2

type Period = { Start: DateTimeOffset; End: DateTimeOffset }

let IsPeriodValid (period: Period) =
    period.Start < period.End
    
let HasOverlap (period1: Period) (period2: Period) =
    period1.Start < period2.End && period1.End > period2.Start
    
let OverlappingPeriod (period1: Period) (period2: Period) =
    if HasOverlap period1 period2 then
        Some { Start = MaxDateTimeOffset period1.Start period2.Start; End = MinDateTimeOffset period1.End period2.End }
    else
        None
        
let period1 = { Start = DateTimeOffset(2020, 1, 1, 0, 0, 0, TimeSpan.Zero); End = DateTimeOffset(2020, 1, 31, 0, 0, 0, TimeSpan.Zero) }
let period2 = { Start = DateTimeOffset(2020, 1, 15, 0, 0, 0, TimeSpan.Zero); End = DateTimeOffset(2020, 2, 15, 0, 0, 0, TimeSpan.Zero) }
let period3 = { Start = DateTimeOffset(2020, 2, 17, 0, 0, 0, TimeSpan.Zero); End = DateTimeOffset(2020, 2, 28, 0, 0, 0, TimeSpan.Zero) }

let x = OverlappingPeriod period1