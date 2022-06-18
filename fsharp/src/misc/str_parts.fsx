let str = "Hello there"
let subStr = str.[2..5]

printfn $"{subStr}"

let getMiddle (str : string) =
    if str.Length % 2 <> 0 then str[ String.length str / 2 .. (String.length str / 2) + 1 ]
    elif str.Length % 2 = 0 then str.[ (str.Length / 2) - 1 .. (str.Length / 2) + 2 ]
    else ""

let mid = getMiddle "testing"
printfn $"{mid}"
