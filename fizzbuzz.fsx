let fb x = 
    match x with
    | x when x % 3 <> 0 -> printfn "Fizz"
    | x when x % 5 <> 0 -> printfn "Buzz"
    | x when not (x % 3 <> 0) && not (x % 5 <> 0) -> printfn "FizzBuzz"
    | _ -> printfn "%d" x
    
for i in 1..20 do
    fb i
