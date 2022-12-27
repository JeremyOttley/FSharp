let readFile (filename: string): string option =
	try
		Some(System.IO.File.ReadAllText filename)
	with
	| :? System.IO.FileNotFoundException -> printfn "File not found"; None;;
