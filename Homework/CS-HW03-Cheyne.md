# C# Homework 03

---

**Cheyne Lowery**

**January 21, 2021**

**CS-HW03-Cheyne.md**

---

1. A *method* is a named sequence of statements that are nested in the method body and referenced via the method name (Named blocks of code).

2. A *function* is used to calculate a result on given input(s). A *procedure* defines order of execution. A subroutine is a set of instructions associated with a specific name (method). A *subprocedure* is a function that does not return a value.

3. The *return statement* returns execution to the calling method and returns a value if it matches the the value in the method declaration.

4. An *expression bodied method* is a method where the return statement is excluded because the expression after '=>' implicitly returns the value.

5. The *scope* of a variable is the location(s) where that variable is accessible, defined by curly brackets.

6. A *field* is a variable declared inside the body of a class, NOT inside of a method!

7. An *overloaded method* is a method that has multiple instances of itself in the same scope, but differ in the parameters - MUST MAINTAIN THE SAME RETURN TYPE

8. You *call* a method that requires arguments via: **[accessibility] [return type] [identifier] [(input params)]**

9. Specify a *method parameter list* by separating each parameter with a comma. Each parameter takes a *type* and *identifier*.

10. You specify an *optional parameter* when defining a method by assigning it a value in the method definition, IE:
	- **[type] [identifier] [assignment operator] [value]**

11. You can pass *named parameters* to a method in any order by using writing: **[identifier] [colon] [value]**, when calling a method.

12. You return values from a method either via the *return* keyword, or the *lambda operator*. To return multiples values from a method, you can use a *tuple* via: **\(type, type) [identifier]([params]\)**, and return the tuple values by using a return statement followed by the return values, separated by commas.

13. A *tuple* is a small collection of values, usually two, IE:
	- **public (string, string) casing(string yourName)**
	- **{**
	- **nameToUpper = yourName.ToUpper();**
	- **nameToLower = yourName.ToLower();**
	- **return (nameToUpper, nameToLower);**
	- **}**
	
14. In the example provided, the method calls itself. It thus calculates the factorial by calling it multiple times. This is an example of *recursion*.

15. The compiler will call the method overload with the *closest signature*. If they are of the same precedence, the application will NOT compile.

16. The *Common Object Model (COM)* is a binary interface standard that gives CLR the ability to allow certain languages to interoperate at the object level.