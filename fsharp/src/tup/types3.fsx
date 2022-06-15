type Organization1 = { boss: string; lackeys: string list }

let rainbow =
    { boss = "Jeffrey";
    lackeys = ["Zippy"; "George"; "Bungle"] }

// Define two organizations with overlapping fields.
type Organization2 = { chief: string; underlings: string list }
type Organization3 = { chief: string; indians: string list }

// Create an instance of Organization2.
let (thePlayers: Organization2) =
    { chief = "Peter Quince";
      underlings = ["Francis Flute"; "Robin Starveling";
                    "Tom Snout"; "Snug"; "Nick Bottom"] }

// Create an instance of Organization3.
let (wayneManor: Organization3) =
    { chief = "Batman";
    indians = ["Robin"; "Alfred"] }

