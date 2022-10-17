#r "nuget: FSharpPlus"
open FSharpPlus

let parseIP (ipaddress: string) =
    ipaddress.Split ':'
        |> (fun [| x; y |] -> {| IP = x; Host = y |})
        
let homeServer = parseIP "192.168.0.1:8080"

// homeServer.IP
// homeServer.Host
