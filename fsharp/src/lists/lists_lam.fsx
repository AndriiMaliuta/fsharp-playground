let dogs = ["Shar";"Kollo";"Buba"]

let count number list = 
    List.exists (fun elem -> elem = number) dogs

let list0to3 = [0 .. 3]
printfn "For list %A, contains zero is %b" list0to3 (count "" list0to3)

