//https://www.codewars.com/kata/62a611067274990047f431a8/train/fsharp

let opposite n firstValue secondValue =
  if n = 0 then []
  else
    let arr = [ for a in 1 .. n -> if a % 2 <> 0 then firstValue else secondValue ]
    arr

//

let rec opposite2 n firstValue secondValue =
  if n = 0 then [] else
  firstValue :: opposite (n-1) secondValue firstValue


// List option = List.init n (fun i -> if i % 2 = 0 then firstValue else secondValue)