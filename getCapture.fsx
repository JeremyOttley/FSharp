open System.Text.RegularExpressions

// simple
let getCapture s p =
  let m = Regex.Match(s, p)
  [for x in m.Groups -> x.Value].Item(1)

// option
let getCapture s p =
  let m = Regex.Match(s, p)
  [for g in (m.Groups |> Seq.skip 1) -> 
	if g.Success then Some g.Value else None].Head
  
// getCapture "20D4EB1 [GA4D84F4].mp4" "\[(\w+)\]" //=> "GA4D84F4"
