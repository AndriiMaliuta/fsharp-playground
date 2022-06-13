// Define an organization type.
type Organization = { chief: string; indians: string list }

// Create an instance of this type.
let wayneManor =
    { chief = "Batman";
    indians = ["Robin"; "Alfred"] }

// Create a modified instance of this type.
let wayneManor' =
    { wayneManor with indians = [ "Alfred" ] }

// Print out the two organizations.
printfn "wayneManor = %A" wayneManor
printfn "wayneManor' = %A" wayneManor'