open System
open FSharp.Data
//open Argu

type Fortune = string

type Sign =
  | Aries
  | Taurus
  | Gemini
  | Cancer
  | Leo
  | Virgo
  | Libra
  | Scorpio
  | Sagittarius
  | Capricorn
  | Aquarius
  | Pisces

type Horoscope = Sign * Fortune

// let x = Horoscope(Sign.Libra, "Good day")

let [<Literal>] apiEndpoint: string = "https://www.astrology.com/horoscope/daily/"

let buildUrl (sign: Sign): string =
    apiEndpoint + sign.ToString().ToLower() + ".html"

let getSign sign =
match sign with
  | "Aries" | "aries" -> Sign.Aries
  | "Taurus" | "taurus" -> Sign.Taurus
  | "Gemini" | "gemini" -> Sign.Gemini
  | "Cancer" | "cancer" -> Sign.Cancer
  | "Leo" | "leo" -> Sign.Leo
  | "Virgo" | "virgo" -> Sign.Virgo
  | "Libra" | "libra" -> Sign.Libra
  | "Scorpio" | "scorpio" -> Sign.Scorpio
  | "Sagittarius" | "sagittarius" -> Sign.Sagittarius
  | "Capricorn" | "capricorn" -> Sign.Capricorn
  | "Aquarius" | "aquarius" -> Sign.Aquarius
  | "Pisces" | "pisces" -> Sign.Pisces
  | _ -> failwith "Not a traditional Zodiac sign"

// Reach out and grab:
    // buildUrl ("libra" |> getSign)
// Return title and paragraph
// Print to console

// System.Uri(buildUrl ("libra" |> getSign))
    // attribute: AbsoluteUri

let genHoroscrope (sign: Sign): Horoscope =
    

// Http.RequestString (buildUrl Sign.Libra)

//string title = <h1 id="content-title">Scorpio Daily Horoscope</h1>
//string date = <h4 class="d-flex flex-items-center"><span id=content-date">Blah</span></h4>
//string horoscopeText = <div id="content"><p><span style="font-weight: 400">Blah</span></p></div>

//System.DateTime.TryParse("March 6, 2023")
let isDate (date: string) =
    Match System.DateTime.TryParse date with
    | true, result -> true
    | _ -> false

// let doc = HtmlDocument.Load((buildUrl Sign.Libra))
// let title = doc.Descendants [ "h1" ]
// let text = doc.Descendants [ "p" ]

//https://trustbit.tech/blog/2019/09/15/introduction-to-functional-programming-in-f-sharp-part-3

//https://fsprojects.github.io/FSharp.Data/library/HtmlParser.html

//https://www.codit.eu/blog/f-domain-model-validation-with-active-patterns/

//https://blog.scottlogic.com/2018/06/01/magical-domain-modelling-with-fsharp.html

//[<EntryPoint>]
