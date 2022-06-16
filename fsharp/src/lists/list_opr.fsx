let cats = [
    "Murz"
    "Pukh"
    "Simba"
]

let cats2 = 
    cats |> List.append ["Pumba"]

printf $"{cats}"
printf $"{cats2}"

// ====== Filter
let cards = [ 1 .. 5 ]
let filteredList = List.filter(fun i-> i % 2 = 0) cards
List.iter(fun i -> printfn "item %i" i) filteredList // item 2 item 4

// =========== SORT
let list = [2; 1; 5; 3]
let sortedList = List.sort list // 1 2 3 5

// ==== 
let fruits = ["Banana"; "Apple"; "Pineapple"]
let sortedFruits = List.sortBy (fun (fruit : string) -> fruit.Length) fruits // Apple, Banana, Pineapple

// ========= sortWith

// assume a type like so
type MagicCreature = { Name : string; Level: int; Attack: int }
let creatures = [
   { Name="Dragon"; Level=2; Attack=20 }
   { Name="Orc"; Level=1; Attack=5 }
   { Name="Demon"; Level=2; Attack=10 } 
]

// comparison function, -1 = less than, 1 = larger than, 0 = equal
let compareCreatures c1 c2 =
     if c1.Level < c2.Level then -1
     else if c1.Level > c2.Level then 1
     else if c1.Attack < c2.Attack then -1
     else if c1.Attack > c2.Attack then 1
     else 0

let sorted = List.sortWith compareCreatures creatures // { Name="Orc"; Level=1; Attack=5 }, { Name="Demon"; Level=2; Attack=10 }, { Name="Dragon"; Level=2; Attack=20 }

// === =================== find
let list2 = [1; 2; 3; 4]
let found = List.find( fun x -> x % 2 = 0) list2 // 2 - Only the first element that matches the condition is returned.

// ============= find 2

let findValue aValue aList =
     let found = aList |> List.tryFind(fun item -> item = aValue)

     match found with
     | Some value -> printfn "%i" value
     | None -> printfn "Not found"

findValue 1 list // 1
findValue 5 list // Not found

// =========== Arithmetic operations

let sum2 = List.sum [1 .. 5] // sum = 15

type OrderItem = { Name: string; Cost:int }

let orderItems = [
       { Name="XBox"; Cost=500 }
       { Name="Book"; Cost=10 }
       { Name="Movie ticket"; Cost=7 }
     ]
     
// ---
let sum = List.sumBy(fun item -> item.Cost) orderItems
printfn "%i" sum // 517