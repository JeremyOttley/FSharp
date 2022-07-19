open System.IO

Directory.GetFiles("C:\\Users\\jottley\\FSharp\\", "*.fsx")
  |> Array.map Path.GetFileName
  |> Array.iter (printfn "%s")
