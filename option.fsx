let div x y =
   match y with
   | 0 -> None
   | _ -> Some(x/y)

let res : int option = div 20 4
printfn "%A" res // Some 5
printfn "%A" res.Value // 5
