open System.IO

let readAllIn fls = 
    let strs = File.ReadAllLines("abc.txt")
    strs |> Array.iter ( printfn "%s") 

readAllIn "abc.txt"    