open System

let getZodiac =
    query
    let sign = Console.ReadLine()
    match sign with
    | "aries" | "taurus" | "gemini" | "cancer" 
    | "leo" | "virgo"| "libra" | "scorpio" | "sagittarius" 
    | "capricorn" | "aquarius" | "pisces" -> getFortune(sign)
    | _ -> failwith "Not a traditional Zodiac sign"
