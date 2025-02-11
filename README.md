# F# Mutable Variable Bug

This example demonstrates a common pitfall in F# when working with mutable variables and functions.  The key issue is the lack of automatic updates in function results when mutable variables referenced by the function are changed after the function's initial call.  The solution shows how to properly update the value for correct behavior.  Note this behaviour is different than imperative languages like C# or Java.

## Bug
The `bug.fs` file shows a scenario where a mutable variable `z` is calculated using a function `add`, but updating the variables `x` used in the function's initial call does not update `z`. 

## Solution
The `bugSolution.fs` file demonstrates a correct way to handle this situation if a recalculation of z based on the new value of x is required.  If the result of the function is intended to remain unchanged after the function call, this example is the expected behavior.