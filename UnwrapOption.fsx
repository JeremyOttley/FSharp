let x = Some 99
match x with
| Some i -> printfn "x is %i" i
| None -> () // what to do here?
