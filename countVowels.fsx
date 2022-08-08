open System

module countVowels =
    let count (word: string) =
        let isVowel (c: char) =
            match c with
            | 'a' | 'e' | 'i' |'o' |'u'
            | 'A' | 'E' | 'I' | 'O' | 'U' -> true
            |_ -> false

        word
            |> Seq.filter (fun c -> isVowel c)
            |> Seq.length

Environment.GetCommandLineArgs()[2]
    |> countVowels.count
    |> printfn "%d"
