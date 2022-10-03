namespace Muse

module Text =

let titleCase (s:string): string =
    s.ToLower() |> System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase
