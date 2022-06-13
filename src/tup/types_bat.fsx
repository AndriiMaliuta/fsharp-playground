// Define an organization type.
type Organization = { chief: string; indians: string list }

// Create an instance of this type.
let wayneManor =
    { chief = "Batman";
    indians = ["Robin"; "Alfred"] }

// Access a field from this type.
printfn "wayneManor.chief = %s" wayneManor.chief