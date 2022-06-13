let add x y = x + y
let result = add 6 7 |> add 4 |> add 5

printfn "%A" result