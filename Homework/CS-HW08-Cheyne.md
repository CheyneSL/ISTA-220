# C# Homework 08

---

**Cheyne Lowery**

**February 4, 2021**

**CS-HW08-Cheyne.md**

---

1.The difference between a deep copy and shallow copy: A *DEEP COPY* returns another instance of the same class with the same data where reference fields are also copied in order to have their own pointer(s). A *SHALLOW COPY* returns a another instance as a deep copy, however both instances will share the same pointer in the *stack* (the data in that ref field cannot be independed of each instance).

2. The value of a *reference* is the memory address of the value in the *heap*.

3. You declare a value type by specifying the *datatype*, *variablename*, *assignment operator*, and the *value* to be assigned.

4. You declare a reference type by using the *NEW* keyword to intantiate it.

5. Yes, you assign *NULL* to a value type by appending a question mark to the end of the value type in the declaration.

6. You *CANNOT* assign a nullable value type to a non-nullable value type because the latter is explicitly declared to never be *NULL*.

7. The difference between the stack and the heap: The *STACK* is a *Last-In-First-Out* data structure where the size of data allocation is *fixed*. The *HEAP* is dynamic memory allocation where data size can change and can be stored in any order as data is referenced by address instead of as an array.

8. *Classes* are referred to as specialized types because they contain unique members as in behavior (functionality), and unique data sets of data.
 
9. The *ref* keyword that prefixes a parameter, will reference the original argument. In other words, any changes to made to the original argument will reflect in all other places where that arguemnt is prefixed with *REF*.

10. The *out* parameter allows a method to run first and initialize that value in the method body.

11. *Boxing* converts a value type to an object and stores it on the *heap*. *Unboxing* allows you to copy a *boxed value* on the *heap* and place it on the *stack*.

12. A *cast* checks whether a *type conversion* will work. Essential for unboxing, otherwise you will get a compile-time error. Two types: *downcast* and *upcast*. A cast will not be checked by the compiler (.sln build), but will be checked by the runtime environment, in which case you may still recieve an error. You may explicity check the validity of the cast with either the *is* or *as* keywords.