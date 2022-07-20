open System
open System.IO

let currentDir = Directory.GetFiles(path, "*")
  |> Array.map Path.GetFileName
  |> Array.filter (fun f -> Path.GetExtension(f) = ext)

let getImages (path:string ext:string) = 
  Directory.GetFiles(path, "*")
    |> Array.map Path.GetFileName
    |> Array.filter (fun f -> Path.GetExtension(f) = ext)

let jpgs = Directory.GetFiles("*", "*.jpg")
let bmps =
let pngs =
let jpegs =

let randomString =

//let filename = Path.ChangeExtension(path, "txt")