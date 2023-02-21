open System
//open Argu
// open FSharp.Data

let [<Literal>] apiEndpoint: string = "https://www.astrology.com/horoscope/daily/"

// let Zodiac = HtmlProvider<url>

// let doc = HtmlDocument.Load(url)
// doc.Descendants

// let getZodiac: obj  =
//     query
//     let sign = Console.ReadLine()
//     match sign with
//     | "aries" | "taurus" | "gemini" | "cancer" 
//     | "leo" | "virgo"| "libra" | "scorpio" | "sagittarius" 
//     | "capricorn" | "aquarius" | "pisces" -> getFortune(sign)
//     | _ -> failwith "Not a traditional Zodiac sign"

// let signUrls: string[] = 
//     signs |> Array.map buildUrl

let buildUrl (sign: string): string =
    apiEndpoint + sign.ToLower() + ".html"
   
let signs: string[] =
    [| "aries"; "taurus"; "gemini"; "cancer";
    "leo"; "virgo"; "libra"; "scorpio";
    "sagittarius"; "capricorn"; "aquarius"; "pisces" |]

// let signUrls: string[] =
//     signs |> Array.map buildUrl

let getSign sign =
match sign with
  | "Aries" | "aries" -> buildUrl sign
  | "Taurus" | "taurus" -> buildUrl sign
  | "Gemini" | "gemini" -> buildUrl sign
  | "Cancer" | "cancer" -> buildUrl sign
  | "Leo" | "leo" -> buildUrl sign
  | "Virgo" | "virgo" -> buildUrl sign
  | "Libra" | "libra" -> buildUrl sign
  | "Scorpio" | "scorpio" -> buildUrl sign
  | "Sagittarius" | "sagittarius" -> buildUrl sign
  | "Capricorn" | "capricorn" -> buildUrl sign
  | "Aquarius" | "aquarius" -> buildUrl sign
  | "Pisces" | "pisces" -> buildUrl sign
  | _ -> failwith "Not a traditional Zodiac sign"

//[<EntryPoint>]
