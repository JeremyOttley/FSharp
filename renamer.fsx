open System.IO

let path = @"C:\Users\jottley\rename-test"

let isImage (file: string) =
    let extension = Path.GetExtension(file)
    match extension with
    | ".jpg" | ".png" | ".bmp" | ".jpeg" -> true
    | _-> false


let images = 
    Directory.GetFiles(path, "*") 
        |> Array.map Path.GetFileName 
        |> Array.filter (fun f -> isImage(f))

let shuffle (coll:seq<char>) =
    let random = System.Random()
    coll |> Seq.sortBy (fun _ -> random.Next(1, 52))

let ranStr n =
    let rand = System.Random()
    let chars = Array.concat([[|'a' .. 'z'|];[|'A' .. 'Z'|];[|'0' .. '9'|]])
    let sz = Array.length chars in
    String(Array.init n (fun _ -> chars.[rand.Next sz]))
