open System.Text

let multiply text times = String.replicate times text

// ========

let multiply2 (text: string) times =
    let sb = new StringBuilder()
    for i in 1..times do
        sb.Append(text) |> ignore
    sb.ToString()

let multiply3 n (text: string) = 
  (StringBuilder(), {1..n})
  ||> Seq.fold(fun b _ -> b.Append(text))
  |> sprintf "%O"    