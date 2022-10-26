namespace ClassLibrary1
open System

module SingleCase =
            
    //definition
    let (|UpperCase|) (x:string) = x.ToUpper()

    //PM usage
    match "foo" with
    | UpperCase "FOO" -> printfn " = FOO "
    | a when a.ToUpper() = "FOO" -> printfn " = FOO (long form)"
    | anythingElse -> printfn "%s" anythingElse
    
    //| UpperCase thisIsUpperCase -> printfn "%s" thisIsUpperCase

    //used as part of function  
    let usedInaFunctionSig (UpperCase(u)) =
        printfn "%s" u
    usedInaFunctionSig "lower"
       
    //used as method 
    let usedLikeAMethod f =
        let uppered = (|UpperCase|) f
        printfn "%s" uppered
    usedLikeAMethod "likeamethod"
       
    //deconstruction binding 
    let (UpperCase deconstructed) = "lower"
    printfn "%s" deconstructed
    
    //lazy
    let (|Lazy|) (x:Lazy<_>) = x.Force()
    
    let fourtyTwo = 42
    let lazyTest = lazy (fourtyTwo + 10)
    match lazyTest with
    | Lazy(result) -> printfn "%i" result
    
    //properties - poormans shorthand lambda
    type MyType =
        {FirstProperty: string; Two: int}
        
    let (|Fst|) (x:MyType) = x.FirstProperty
    
    let testList = [ {FirstProperty = "test"; Two = 42}
                     {FirstProperty = "anotherTest"; Two = 54} ]
    
    let firstProps1 = testList |> List.map (fun x -> match x with Fst a -> a)
    let firstProps2 = testList |> List.map (function Fst a -> a)
    let firstProps3 = testList |> List.map (|Fst|)
    // -----------------------------------------------------------------------

module MultiCase =
    let (|Odd|Even|) x =
        if x % 2 = 0 then Even x
        else Odd x
    
    let (|Sentence|Word|WS|) (input : string) =
        match input.Trim() with
        | "" -> WS
        | input when input.Contains(" ") -> Sentence (input.Split([|" "|], StringSplitOptions.None))
        | everythingElse -> Word (everythingElse)
             
    let usedLikeAMethod f =
        let sentenceWordOrWS = (|Sentence|Word|WS|) f
        match sentenceWordOrWS with
        | Choice1Of3 _ -> "sentence"
        | Choice2Of3 _ -> "word"
        | Choice3Of3 _ -> "whitespace"
  
  
//-----------------------------------------------------------------------------              
module PartialActive =
       
    let (|AllAndLast|_|) (xs: 'T list) = 
        match xs with
        | [] -> 
            None
        | _ -> 
            let reversed = List.rev xs
            Some (List.rev reversed.Tail, reversed.Head)
            
    let numbers = [1..10]
    
    match numbers with
    | AllAndLast (all, last) ->
        printfn "last: %A, all: %A" last all
    | anyThingElse -> printfn "anything else: %A" anyThingElse
    
    //emulator sample
    let between startAddress endAddress address =
        if address >= startAddress && address <= endAddress then Some() else None
        
    let romStart, romEnd = 0xfc000u, 0xff000u    
    let (|Rom|_|) = between romStart romEnd
    
    let writeToMemory location data =
        match location with
        | Rom -> printfn "Cannot write to %A because it is a Rom area" location
        | _ -> printfn "write data here"
        
    let (|LEA|_|) data =
            //0100 rrr1 11ss sSSS
        if data &&& 0b1111000111000000 = 0b0100000111000000 then
            let register = byte (data >>> 9) &&& 0b111uy
            let mode = byte (data >>> 3) &&& 0b111uy
            let register2 = byte data &&& 0b111uy
            Some(register, mode, register2)
        else None
        
    match 0b0100001111010011 with
    | LEA(register, mode, register2) -> printfn "LEA %A %A %A" register mode register2
    | other -> printfn "other: %u" other
    
    //quotation sample           
    open Microsoft.FSharp.Quotations
    open Microsoft.FSharp.Quotations.Patterns 
    let (|InstanceMethod|_|) (expr:Expr) =
        match expr with
        | Call(instance, mi, args) ->
            instance |> Option.map (fun e -> (e, mi, args))
        | _ -> None
        
    let number = 42
    
    match <@@ number.Equals 42 @@> with
    | InstanceMethod(e,mi,args)  -> printfn "instance method: e: %A" e
    | other -> printfn "Not an instance method: %A" other

//-----------------------------------------------------------------------------        
module Parameterized =
    
    let (|Contains|_|) pattern value =
        if String.IsNullOrWhiteSpace value then
            None
        elif value.Contains pattern then
            Some()
        else None
        
    match "foo" with
    | Contains "o" -> printfn "contains o"
    | _ -> printfn "anything else"
     
        
    //emulator sample  
    let romStart, romEnd = 0xfc000u, 0xff000u    
    let (|MemoryBetween|_|) startAddress endAddress address =
        if address >= startAddress && address <= endAddress then Some() else None 
 
    let writeToMemory location data =
        match location with
        | MemoryBetween romStart romEnd -> printfn "Cannot write to %A because it is a Rom area" location
        | _ -> printfn "write data here"
        
    writeToMemory 0xfc001u 0x0000u
