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

// Chaining operations
let divide x y =
    if y = 0 then Error "Division by zero"
    else Ok (x / y)

let calculate result =
    result
    |> Result.bind (fun x -> divide x 2)
    |> Result.map (fun x -> x * 3)

// Usage
let result1 = Ok 10
let result2 = Error "Invalid input"

let finalResult1 = calculate result1 // Ok 15
let finalResult2 = calculate result2 // Error "Invalid input"
