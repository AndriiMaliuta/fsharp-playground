open System

let oneYearLater = 
    DateTime.Now + new TimeSpan(365, 0,0,0,0)
printfn "%A" oneYearLater