open System

let toString : seq<char> -> string = 
  Seq.map string >> String.concat ""
  
let reverseString (s: string): string =
    s |> Seq.rev |> toString

let isPalindrome (s: string): bool =
  s = (reverseString s)
