open System
open System.Text.RegularExpressions

let isUppercase (input: string) : bool =
    Regex.Match(input, "(?=^[^a-z]*$).*[A-Z]").Success

let isLowercase (input: string) : bool =
    Regex.Match(input, "(?=^[^A-Z]*$).*[a-z]").Success

let (|TitleCase|Uppercase|Lowercase|) (value: string) =
    if isUppercase value then Uppercase
    elif isLowercase value then Lowercase
    else TitleCase

let textCase (s: string) =
    match s with
    | Lowercase -> printfn "%s" (System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ToTitleCase s)
    | Uppercase -> printfn "%s" (System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(s.ToLower()))
    | TitleCase -> printfn "%s" s

let f () =
    printf "Enter Text: "
    let value: string = Console.ReadLine()
    textCase value

while true do
    f ()

Console.ReadKey() |> ignore
