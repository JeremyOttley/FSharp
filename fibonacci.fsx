let rec fibonacci (n: int): int =
    match n with
    | n when (n < 2) -> n
    | _ -> fibonacci(n - 1) + fibonacci(n - 2)
