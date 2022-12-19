module Web =
    open System.Net

    let downloadFile (url:String) (dest:string) =
        use wc = new WebClient()
        wc.DownloadFile(url, dest)
        
// Web.downloadFile "https://character.totalpartykill.ca/lotfp/json/" "character.json"
