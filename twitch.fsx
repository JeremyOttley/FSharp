open System

let streamlink (channel: string) =
    let program = new System.Diagnostics.Process()
    program.StartInfo.FileName <- "streamlink"
    program.StartInfo.Arguments <- ($"--twitch-low-latency https://www.twitch.tv/{channel} best")
    program.StartInfo.UseShellExecute <- false
    program.Start() |> ignore

Environment.GetCommandLineArgs()[2] |> streamlink
