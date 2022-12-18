open System.Net.Http
open System.Net.Http.Json

type Post =
    { userId: int
      id: int
      title: string
      body: string }

task {
    use client = new HttpClient()
    let url = "https://jsonplaceholder.typicode.com/posts"

    let! posts = client.GetFromJsonAsync<Post[]>(url)

    printfn $"%A{posts}" // prints the 100 post array to the console
}
|> Async.AwaitTask
// we run synchronously
// to allow the fsi to finish the pending tasks
|> Async.RunSynchronously
