module Seq =
    let notEmpty (xs: seq<_>) : bool = 
        xs |> Seq.isEmpty |> not

printfn "%A" (Seq.notEmpty <| seq {1, 2, 3, 4})
printfn "%A" (Seq.notEmpty <| Seq.empty)
