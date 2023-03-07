// outdated

open System
open System.Net

    let tryParse s =
        match Uri.TryCreate(s, UriKind.Absolute) with
        | (true, url) -> Some(url)
        | _ -> None

    let isHTTPFamily (url : Uri) =
        url.Scheme = Uri.UriSchemeHttp || url.Scheme = Uri.UriSchemeHttps

    type CheckResult =
    | OK
    | Redirected of Uri
    | Error of WebExceptionStatus * WebException

    let check (url : Uri) =
        let req = WebRequest.Create(url)
        if (req :? HttpWebRequest) then
            req.Method <- "HEAD"
        try
            use rsp = req.GetResponse()
            rsp.Close()
            if url = rsp.ResponseUri then
                OK
            else
                Redirected(rsp.ResponseUri)
        with
        | :? WebException as e -> Error(e.Status, e)
