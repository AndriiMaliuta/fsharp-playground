
let add x y = x + y
let result1 = add 4 5
let result2 = add 6 7
let finalResult = add result1 result2

let add2 x y = x + y
let result =
    add2 (add2 4 5) (add2 6 7)