let isRegexMatch input pattern =
    System.Text.RegularExpressions.Regex.IsMatch(input, pattern)
    
// ["file.png"; "file.jpg"; "file.bmp"] |> List.filter (fun f -> isRegexMatch f ".jpg$")
