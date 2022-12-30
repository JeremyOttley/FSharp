type Name = 
   { 
      First : string
      Middle : string Option
      Last : string 
   }

module NameFormatting =

   let FormatName (name : Name) =
      match name.First, name.Middle, name.Last with
      | f, Some m, l -> sprintf "%s, %s %s" l f m
      | f, None, l -> sprintf "%s, %s" l f
