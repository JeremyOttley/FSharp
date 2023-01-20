using System;
using System.Collections.Generic;

namespace PortingToFsharp
{
    public class Squarer
    {
        public int Square(int input)
        {
            var result = input * input;
            return result;
        }

        public void PrintSquare(int input)
        {
            var result = this.Square(input);
            Console.WriteLine("Input={0}. Result={1}",
              input, result);
        }
    }
    
//

namespace PortingToFsharp

open System
open System.Collections.Generic

type Squarer() =
	
	let Square (input : int): int =
		input * input

	let PrintSquare (input : int) =
		let result = Square input
		printfn "Input=%i. Result=%i" input result
    
