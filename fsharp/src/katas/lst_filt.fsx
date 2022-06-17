open System

let GetIntegersFromList (listOfItems: Object list) =
//   let lst = listOfItems |> List.filter (fun a -> Char.IsDigit a) listOfItems
    listOfItems |> List.filter (fun a -> Char.IsDigit (Convert.ToChar a) )