# C# Homework 06

---

**Cheyne Lowery**

**January 27, 2021**

**CS-HW06-Cheyne.md**

---

1. An *exception* is an error in an application that happens during execution. *Exceptions* also provide a way to to handle that error.

2. If a *try block* executes without error(s), your program will continue and release control to the next funciton or process.

3. If there is no matching *catch handler* for an *unhandled exception*, control is returned to the calling method which searches for a matching catch handler.

4. If the *exception block* fails to handle an error, the calling method exits and releases control to its caller.

5. The *parent class* for all *exceptions* is *System.Exception (NOT System.SystemException)*. *Child classes inherit* members from the *System.Exception superclass* in order to create more specific *exception classes*.

6. Determine the type of an error by including multiple *catch blocks* beginning with the MOST specific exceptions listed first succeeding *the try block*.

7. The purpose of *overflow checking* is to return an error instead of letting the compiler silently claculate an *integer overflow*, thus returning the wrong answer.

8. Range of values for type *Int32*: **-2147483648 (-2.147bn) to 2147483647 (2.147bn) = range of Int32 values**

9. An *unsigned Int32* can contain values from **0 to 4,294,967,295 (4.294bn, all positive)**. *Signed integers* can contain both *positive and negative values*; unsigned integers can contain *only positive values*.

10. The *finally block* always ensures that a statement will run if control enters a *try block*, regardless of whether an *exception* was thrown.

11. If you don't need to display a message or conduct *resource management* like closing connections, there isn't a reason to use a *finally block*.