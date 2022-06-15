let result = List.map ((+) 1) [1; 2; 3]

printfn "List.map ((+) 1) [1; 2; 3] = %A" result

// ---

let doNothingToAnInt (x: int) = x
let intList = [1; 2; 3]
let (stringList: list<string>) = ["one"; "two"; "three"]