/// Square the odd values of the input and add one, using F# pipe operators.
let squareAndAddOdd values =
    values
    |> List.filter (fun x -> x % 2 <> 0)
    |> List.map (fun x -> x * x + 1)

let numbers = [ 1; 2; 3; 4; 5 ]

let result = squareAndAddOdd numbers