open System.IO

// .NET version
val readLines: filePath: string -> seq<string>
let readLines (filePath: string) =
    seq {
        use sr = new StreamReader(filePath)

        while not sr.EndOfStream do
            yield sr.ReadLine()
    }

// Optimized version
val readLines: filePath: string -> Collections.Generic.IEnumerable<string>
let readLines filePath = System.IO.File.ReadLines(filePath)

// Safe version
val readFile: filename: string -> string option
let readFile (filename: string) : string option =
    if File.Exists filename then
        Some(File.ReadAllText filename)
    else
        None
