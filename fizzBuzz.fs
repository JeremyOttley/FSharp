module FizzBuzz_Match =

    let fizzBuzz i =
        match i with
        | _ when i % 15 = 0 ->
            printf "FizzBuzz"
        | _ when i % 3 = 0 ->
            printf "Fizz"
        | _ when i % 5 = 0 ->
            printf "Buzz"
        | _ ->
            printf "%i" i

        printf "; "

    // do the fizzbuzz
    [1..100] |> List.iter fizzBuzz
