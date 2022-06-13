// Function
let halfWay a b = 
    let dif = b - a
    let mid = dif / 2
    mid + a

printfn "%i" (halfWay 10 20)