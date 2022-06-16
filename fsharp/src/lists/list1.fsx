let listOfList = [[2; 3; 5]; [7; 11; 13]; [17; 19; 23; 29]]

let rec concatList l =
    match l with
    | head :: tail -> head @ (concatList tail)
    | [] -> []

// Call the function.
let primes = concatList listOfList

// Print the results.
printfn "%A" primes


// Function that attempts to find various sequences.
let rec findSequence l =
    match l with
    // Match a list containing exactly 3 numbers.
    | [x; y; z] ->
        printfn "Last 3 numbers in the list were %i %i %i"
            x y z
    // Match a list of 1, 2, 3 in a row.
    | 1 :: 2 :: 3 :: tail ->
        printfn "Found sequence 1, 2, 3 within the list"
        findSequence tail
    // If neither case matches and items remain,
    // recursively call the function.
    | head :: tail -> findSequence tail
    // If no items remain, terminate.
    | [] -> ()

// Some test data.
let testSequence = [1; 2; 3; 4; 5; 6; 7; 8; 9; 8; 7; 6; 5; 4; 3; 2; 1]
// Call the function.
findSequence testSequence