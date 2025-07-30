// Creating Results
let successResult = Ok 42
let errorResult = Error "Something went wrong"

// Pattern matching
let handleResult result =
    match result with
    | Ok value -> printfn "Success: %i" value
    | Error msg -> printfn "Error: %s" msg

// Usage
handleResult successResult // Prints: Success: 42
handleResult errorResult   // Prints: Error: Something went wrong
