# C# Homework 02

---

**Cheyne Lowery**

**January 14, 2021**

**CS-HW02-Cheyne.md**

---


1) A *local variable* restricts the the variable to the scope of the method where it is declared.

2) A *statement* is a command that performs an action - generally works tandem with methods

3) *Identifiers* are the names assigned to elements, and used to reference elements within your program.

4) *Keywords* are predefined identifiers that have a specific use(s) within the compiler and cannot be used for anything else.

5) A *variable* is a named location in memory.

6) Assign a value to a variable via the *assignment operator*. If a variable is initialized, it MUST be assigned a value via the definite assignment rule. You CAN declare and initialize a variable with: int identifier (AssignmentOperator) value.

7) If a *.csproj* is opened individual of the solution, you will NOT have access to any of the required libraries. The *DEBUG* feature will also be unavailable.

8) *Arithmetic operators* and *variable types* are related because arithmetic operators operate on variables/operands.

9) You turn an integer into a string via the *string.Parse()* method, IE:
	- **string myString = string.Parse(5);**

10) You turn an integer to a string via the *Int32.Parse()* method, IE:
	- **int myInt = Int32.Parse("5");**

11) The difference between *precedence* and *associativity* is *associativity* refers to the direction of the evaluation if precedence is the same amongst operators (explicit), IE:
	- **5 + 4 + 3 - Left (5 + 4) + 3 - Right 5 + (4 + 3)**.
*Precedence* refers to the order in which subexpressions are evaluated based on the operators (implicit), IE:
	- **4 + 5 \* 2 = 14** (multiplicand will always be higher precedence than the addition operator).

12) The *definite assignment* rule dictates that a variable will always contain a value (including NULL).

13) *Pre/Postfix Increment/Decrement*

	- **Prefix Increment = INCREMENT value BEFORE evaluation**
	- **Postfix Increment = INCREMENT value AFTER evaluation**
	- **Prefix Decrement = DECREMENT value BEFORE evaluation**
	- **Postfix Decrement = DECREMENT value AFTER evaluation**

14) *String interpolation* allows the use of variable value types within string by prefacing string with '**$**' and surrounding the variable with angled brackets.

15) The *var* keyword is an implicitly typed variable where the compiler reasons the actual value type.