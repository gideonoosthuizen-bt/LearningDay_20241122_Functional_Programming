module Sandbox_FSharp.Program

open Sandbox_FSharp.PeriodStuff

printfn "Period 1: %A" period1
printfn "Period 2: %A" period2
printfn "Period 3: %A" period3

printfn "Is period 1 valid: %b" (IsPeriodValid period1)
printfn "Is period 2 valid: %b" (IsPeriodValid period2)
printfn "Is period 3 valid: %b" (IsPeriodValid period3)

printfn "Period 1 overlaps period 2: %b" (HasOverlap period1 period2)
printfn "Period 1 overlaps period 3: %b" (HasOverlap period1 period3)
printfn "Period 2 overlaps period 3: %b" (HasOverlap period2 period3)

printfn "Overlapping period 1 and 2: %A" (OverlappingPeriod period1 period2)
printfn "Overlapping period 1 and 3: %A" (OverlappingPeriod period1 period3)
printfn "Overlapping period 2 and 3: %A" (OverlappingPeriod period2 period3)

printfn "What is x: %A" x
printfn "x -> period 1: %A" (x period1)
printfn "x -> period 2: %A" (x period2)
printfn "x -> period 3: %A" (x period3)

printfn "Press any key to exit..."