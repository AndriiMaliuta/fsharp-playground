// Some strings.
let message = "Hello
World\r\n\t!"

let dir = @"c:\projects"

// A byte array.
let bytes = "bytesbytesbytes"B

// Some numeric types.
let xA = 0xFFy
let xB = 0o7777un
let xC = 0b10010UL

let name = "Petro"
printfn "%s" name[0..2]

let printChar (str : string) (index : int) =
    printfn "First character: %c" (str.Chars(index))

printChar "Vasylko" 3    