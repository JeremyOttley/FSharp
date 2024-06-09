let tryParseInt (s: string): int option =
    let success, result = Int32.TryParse s
    match success with 
    | true -> Some result 
    | false -> None

// let output = tryParseInt "324"
// printfn "%d" result.Value
