open System

let increase a = a + 1 

let vowelCount s = 
  let mutable count: int = 0
  s |> String.iter (fun c -> if c = 'a' || c = 'o' || c = 'u' || c = 'e' || c = 'i' 
                             then count <- count + 1 else count <- count)
  count

vowelCount "Hello"