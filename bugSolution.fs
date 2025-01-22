let xRef = ref 1
let yRef = ref 2
let z = { xRef.Value + yRef.Value }
printf "%d\n" z.Value
xRef := 3
printf "%d\n" z.Value // z will correctly print 5 because the closure now refers to the ref cells