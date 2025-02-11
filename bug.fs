let mutable x = 10
let mutable y = 20

let add x y = x + y

let mutable z = add x y

printf "%d\n" z

x <- 15

printf "%d\n" z  // z will still be 30, not 35
