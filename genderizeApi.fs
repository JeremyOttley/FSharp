open FSharp.Data

[<Literal>]
let sample = "https://api.genderize.io?name=jeremy"
let apiUrl = "https://api.genderize.io?name="

type Gender = JsonProvider<sample>

let name = Gender.Load(apiUrl + "Jeremy")

//name.Count
//name.Name
//name.Gender
//name.Probability

printfn "%s is a %s" name.Name name.Gender
