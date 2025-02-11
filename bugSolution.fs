let mutable x = 10
let mutable y = 20

let add x y = x + y

let mutable z = add x y

printf "%d\n" z

x <- 15

z <- add x y // Recalculate z with updated x

printf "%d\n" z // Now z will be 35