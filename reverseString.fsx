open System

let toString : char seq -> string = 
  Seq.map string >> String.concat ""
  
let reverseString (s: string): string =
    s |> Seq.rev |> toString
