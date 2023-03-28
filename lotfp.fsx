open System.Net.Http
open FSharp.Data

type Character = JsonProvider<"https://character.totalpartykill.ca/basic/json/">

type GenCharacter() =
    member this.Generate() =
        let url = "https://character.totalpartykill.ca/basic/json/"
        let httpClient = new HttpClient()
        let response = httpClient.GetAsync(url).Result
        response.Content.ReadAsStringAsync().Result |> Character.Parse

let characterGenerator = GenCharacter()
let character = characterGenerator.Generate()

printfn "Your character's hitpoints: %d" character.Hp
