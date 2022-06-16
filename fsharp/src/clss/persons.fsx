type Person = { FirstName: string; LastName: string  }
let people = [
   { FirstName="Albert"; LastName= "Einstein" }
   { FirstName="Marie"; LastName="Curie" }
]
let nobelPrizeWinners = List.map (fun person -> person.FirstName + person.LastName) people 
printfn "%A" nobelPrizeWinners // ["Albert Einstein"; "Marie Curie"]