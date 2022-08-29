let interleave a b =
    List.zip a b |> List.collect (fun (a,b)-> [a;b])

interleave ["Jeremy"; "Mark"; "Ottley"] [" "; " "; " "] 
    |> List.reduce (+)
    |> printfn "%s"
