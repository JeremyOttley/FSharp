open System
open System.Text.RegularExpressions
open TextCopy

let isUppercase (input: string) : bool =
    Regex.Match(input, "(?=^[^a-z]*$).*[A-Z]").Success

let isLowercase (input: string) : bool =
    Regex.Match(input, "(?=^[^A-Z]*$).*[a-z]").Success

let (|TitleCase|Uppercase|Lowercase|) (value: string) =
    if isUppercase value then Uppercase
    elif isLowercase value then Lowercase
    else TitleCase

let textCase (s: string) : string =
    match s with
    | Lowercase -> (System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ToTitleCase s)
    | Uppercase ->  (System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(s.ToLower()))
    | TitleCase ->  s

let main () =
    printf "Enter Text: "
    let value: string = Console.ReadLine()
    ClipboardService.SetText(textCase value)


while true do
    main ()

Console.ReadKey() |> ignore
