open System

let fileSeq ((path: string), (ext: string)) =
    Directory.EnumerateFiles(path)
        |> Seq.map Path.GetFileName
        |> Seq.filter (fun f -> f.EndsWith(ext))
        
fileSeq(Environment.GetCommandLineArgs()[2], Environment.GetCommandLineArgs()[3]) 
    |> printfn "%A"
