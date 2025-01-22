# Unexpected Behavior with Mutable Variables in F# Closures

This example demonstrates a common issue in F# when dealing with mutable variables within closures.  The variable `z` calculates a sum but does not reflect changes to `x` or `y` after the initial assignment.  The solution shows how to use ref cells to achieve the desired behavior.