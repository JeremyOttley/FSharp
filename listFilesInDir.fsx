open System.IO

// find all files in dir but only keep the ones with the extension ".xml"  
let xmlArray (path:string) =
  Directory.GetFiles(path, "*")
    |> Array.map Path.GetFileName
    |> Array.filter (fun f -> Path.GetExtension(f) = ".xml")
