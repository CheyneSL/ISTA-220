# C# Homework 04

---

**Cheyne Lowery**

**January 22, 2021**

**CS-HW04-Cheyne.md**

---

1. There are only *two* possible values to a *boolean expression*: **TRUE/FALSE**.

2. List the *equality*, *relational*, and *logical operators*:
  - **EQUALITY: '==' (equality) / '!=' (inequality)**
  - **RELATIONAL: '<' (less than) / '<=' (less than or equal to) / '>' (greater than) / '>=' (greater than or equal to)**
  - **CONDITIONAL LOGICAL OPERATORS (BOOL): && (and) / || (or) / ! (NOT)**
  
3. *Short circuiting* is a way of evaluating the expression based on only one operand.

4. *Short-circuit &&* means that the left operand evaluates to *FALSE*. *Short-circuit ||* means that the left operand evaluates to *TRUE*. 

5. The *primary operators* (specifically the precedence override) have the highest precedence. The assignment operator has the lowest precedence.

6. The code blocks in an *'if/else' statement* allows for the execution of more than on statement.

7. The application will not compile if the *break* keyword is omitted from a switch statement. The break statement prevents a *fall-through* (continuous execution) and returns control to the calling method.

8. *Switch* is a selection statement that chooses the single value to who you compare a list of values to. Case specified a pattern to compare to the match expression. Break returns control to the calling method and prevents a switch fall-through.

9. In the example, *recurr1* recursively calls 1 value to derive the factorial; *recurr2* calls operates on two separate values, still recursively, but not a factorial.

10. A *recursive* method is a method that calls itself in its own body until it returns a *scalar value*.
  
11. *Set theory* and *boolean algebra* dictate those as the same because "its not snowing or raining" is the unified negation of values whereas "its not snowing and its not raining" is intersecting negation of two values. They are the same because the operands on either side of the logical operator evaluate to the same boolean value. "I'm not running and walking" is the *intersected negation* of two values, whereas "I'm not running or I'm not walking" is the *union* of two separately negated values. Operands on either side of the logical operator evaluate to the same boolean value.