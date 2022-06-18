#load "FSharpChart.fsx"

open System
open MSDN.FSharp.Charting

let dateInApril day = new DateTime(2012, 03, day)

let data = [ dateInApril 6, 4; dateInApril 7, 8;
             dateInApril 8, 2; dateInApril 9, 3 ]

FSharpChart.Column data