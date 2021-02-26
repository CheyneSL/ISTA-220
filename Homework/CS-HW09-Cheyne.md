# C# Homework 09

---

**Cheyne Lowery**

**February 10, 2021**

**CS-HW09-Cheyne.md**

---

1. An *enum* is a type of class that holds a list of read-only variables on the stack.

2. Declare an *enum* for military ranks: **enum Enlisted { PVT, PV2, PFC, SPC, CPL, SGT, SSG, SFC, MSG, 1SG, SGM, CSM };**

3. Using the *ranks enum*, assign a rank to you and your friend:
	- Cheyne.Name = Enlisted.SGT; **Assigns the name property of the 'Cheyne' object the Enlisted enum var, 'SGT'**
	- Jaret.Name = Enlisted.SGT; **Assigns the name property of the 'Jaret' object the Enlisted enum var, 'SGT'**

4. Determine the numberic index of particular ranks, using the *ranks enum*:
	- Enlisted soldier = Enlisted.PVT;
	- Console.WriteLine((int)soldier); **Assigns soldier the value: PVT. Casts value as int and prints the index**
	
5. To select the type of enum, use with a colon following the enum name IE: **enum Enlisted : short { PVT, PV2, PFC }**
	
6. A *struct* is a low overhead class stored on the stack. Contains *fields*, *methods*, and *properties*. Automatically has *default constructor*, may contain a custom constructor as long as *all* fields are initialized when it is called. *Structs* are used when the focus are their values rather than the functionality.

7. A *class* is a *reference type*. A *struct* is a *value type*. Struct custom constructors must initialize all fields when called. Custom class constructors can do anything.

8. Both *structs* and *enums* are stored on the *stack* as they are value types.

9. *System.Int32* Fields: **MaxValue, MinValue** Methods: **CompareTo(Int32), CompareTo(Object), Equals(Int32), Equals(Object),	GetHashCode(), GetTypeCode(), Parse(String), Parse(String, IFormatProvider), 	Parse(String, NumberStyles), Parse(String, NumberStyles, IFormatProvider), 	ToString(), ToString(IFormatProvider), ToString(String), ToString(String, IFormatProvider), TryFormat(Span<Char>, Int32, ReadOnlySpan<Char>, IFormatProvider), 	TryParse(ReadOnlySpan<Char>, Int32), TryParse(ReadOnlySpan<Char>, NumberStyles, IFormatProvider, Int32), TryParse(String, Int32), TryParse(String, NumberStyles IFormatProvider, Int32)**
	
10. Declare a struct named *DoD* with four branches: **struct DoD { string Army, AirForce, Navy, Marines; }**

11. You cannot create a default constructor for a struct because the compiler already generates one, setting all fields to 0, false, or NULL. A custom constructor should always be used to initialize the fields.

12. *CIL* is the *Common intermediate Language* for the *.NET Framework*. It is the *bytecode* that the *JIT (Just-In-Time)* compiler interprets. The *CLR (Common Language Runtime)* is the environment where the *CIL* is interpreted and executed.