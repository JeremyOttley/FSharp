open System
open FSharp.Data

let [<Literal>] apiEndpoint: string = "" //zodiac link

let getZodiac =
    query
    let sign = Console.ReadLine()
    match sign with
    | "aries" | "taurus" | "gemini" | "cancer" 
    | "leo" | "virgo"| "libra" | "scorpio" | "sagittarius" 
    | "capricorn" | "aquarius" | "pisces" -> getFortune(sign)
    | _ -> failwith "Not a traditional Zodiac sign"

let buildUrl (sign: string): string =
    apiEndpoint + sign + ".html"
    
let signs: string[] = [| "aries"; "taurus"; "gemini"; "cancer";
   "leo"; "virgo"; "libra"; "scorpio"; 
   "sagittarius"; "capricorn"; "aquarius"; "pisces" |]

let signUrls: string[] = signs |> Array.map buildUrl

