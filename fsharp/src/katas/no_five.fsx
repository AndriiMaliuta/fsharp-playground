let dontGiveMeFive startValue endValue = 
  let lst = [ startValue .. endValue ]
  let mutable count = 0
  for a in lst do
    let str = sprintf "%i" a
    let last = str |> Seq.last
    let b = last |> int
    printfn $"{b}"
    if b <> 5 then count <- count + 1
  count    

let res = dontGiveMeFive 1 9  
printfn $"{res}"