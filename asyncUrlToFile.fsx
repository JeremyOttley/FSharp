open System.Net.Http
open System.IO

task {
    /// open the file and note the ***use*** keyword in the file and the client
    use file = File.OpenWrite("./dummy.pdf")
    use client = new HttpClient()
    let! response = client.GetStreamAsync("https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf")
    /// copy the response contents to the file asynchronously
    do! response.CopyToAsync(file)
    // both file and client will be disposed automatically
    // after they get out of scope
}
|> Async.AwaitTask
// we run synchronously
// to allow the fsi to finish the pending tasks
|> Async.RunSynchronously

