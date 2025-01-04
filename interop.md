# Calling C# methods from F#

Calling a C# method from F# is straightforward. Given the following C# methods:

```csharp
public class CallMe
{
    public int SingleArgument(int i) { return i; }

    public int MultipleArguments(int i, int j) { return i + j; }
}
```

You can call them as shown below. Note that methods with multiple arguments have to be called with a tuple, which makes it look like a call in C#.

```
let callMe = CallMe()

let a = callMe.SingleArgument 1

let b = callMe.MultipleArguments (1, 2)
```

Calling methods with out-parameters works as well. The return value and the out-parameter(s) are returned as a tuple:

```
let success, guid = Guid.TryParse "no guid" // success: bool, guid: Guid
```

