namespace widgetts

module Widgg = 
    let squares =
    seq {
        for i in 1..10 -> i * i
    }

    for sq in squares do
        printfn $"%d{sq}"

    //

    let squares2 =
        seq {
            for i in 1..10 do
                yield i * i
        }

    for sq in squares2 do
        printfn $"%d{sq}"



    let weekdays includeWeekend =
        seq {
            "Monday"
            "Tuesday"
            "Wednesday"
            "Thursday"
            "Friday"
            if includeWeekend then
                "Saturday"
                "Sunday"
        }    

    let cubes =
        seq {
            for i in 1..3 -> i * i * i
        }

    let squaresAndCubes =
        seq {
            yield! squares
            yield! cubes
        }   
        
         