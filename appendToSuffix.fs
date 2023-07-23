open System
open System.IO

let path = Directory.GetCurrentDirectory()

let getAllFiles =
    Directory.GetFiles(path, "*")
        |> Seq.map Path.GetFileName
        |> Seq.filter (fun f -> not (Path.GetExtension(f) = ".exe")) // too broad?

let append2ToFileName (f: string) =
    Path.GetFileNameWithoutExtension(f) + "2" + Path.GetExtension(f)

getAllFiles 
    |> Seq.map (fun x -> (x, x.Replace(x, append2ToFileName(x))))
    |> Seq.iter (fun (x,y) -> File.Move(x, y))

[<EntryPoint>]
let main argv = 0

// exclude "appendSuffix.exe"
