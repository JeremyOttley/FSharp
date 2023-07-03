open System
open System.IO

let dir = Directory.GetCurrentDirectory()

let isImage (file: string) =
    match Path.GetExtension(file) with
    | ".jpg" | ".png" | ".bmp" | ".jpeg" -> true
    | _-> false

let shuffle (coll:seq<char>) =
    let random = System.Random()
    coll |> Seq.sortBy (fun _ -> random.Next(1, 52))

let ranStr n =
    let rand = System.Random()
    let chars = Array.concat([[|'a' .. 'z'|];[|'A' .. 'Z'|];[|'0' .. '9'|]])
    let sz = Array.length chars in
    String(Array.init n (fun _ -> chars.[rand.Next sz]))

Directory.GetFiles(dir)
  |> Seq.filter (fun x -> isImage x)
  |> Seq.map (fun x -> (x, x.Replace(x, ((ranStr 16) + Path.GetExtension(x)))))
  |> Seq.iter (fun (x,y) -> File.Move(x, y))
