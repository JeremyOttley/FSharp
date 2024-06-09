let x = Some 99
match x with
| Some i -> printfn "x is %A" i
| None -> () // what to do here?
