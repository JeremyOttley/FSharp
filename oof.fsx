type Chicken (name: string, size: float) =

	// Place imperative code in `do` blocks
	do
		if System.String.IsNullOrEmpty name then
			invalidArg (nameof name) "Chickens must have names."

	// general function 
	let grow (newSize: float) =
		Chicken (name, newSize)

	// Empty Constructor
	new () =
		Chicken ("DefaultChicken", 12.0)

	// Partial Constructor
	new (name: string) = 
		Chicken (name, 5.0)

	member this.Name = name
	member this.Size = size
	member this.Grow (newSize: float) = grow newSize



// let c1 = Chicken ("Gary", 10.0) //=> c1.Name
