let rec fibonacci (n: int): float =
    match n with
    | n when (n < 2) -> (float n)
    | _ -> fibonacci(n - 1) + fibonacci(n - 2)
