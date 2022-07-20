// Any tuple can be unpacked into variables using a simple let binding. The only requirement is that the number of variables and structure match the tuple. You will get a compile error if you try to extract too many or too few values from a tuple.

let date = (30, "October", 1988)
// val date : int * string * int = (30, "October", 1988)

let day, month, year = date
// val year : int = 1988
// val month : string = "October"
// val day : int = 30

// To extract values from two-element tuples, you can use the fst and snd functions.

let fullname = ("Jeremy", "Ottley")
// val fullname : string * string = ("Jeremy", "Ottley")

let first = fst fullname
// val first : string = "Jeremy"
let last = snd fullname
// val last : string = "Ottley"
