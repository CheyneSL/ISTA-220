# C# Homework 12

---

**Cheyne Lowery**

**February 19, 2021**

**CS-HW12-Cheyne.md**

---

1. *Inheritance* promotes the principle of *don't repeat yourself (DRY)* because derived classes may contain members that appear in all derived classes In order to not be redundant in writing the members several times, it can *inherit* them from one *base class*, in which they will appear in all *derived classes* without explicitly writing them.

2. The syntax of a *derived class* that *inherits* from a *base class* contains *three parts*: **class declaration**, **derived class name**, **colon** to indicate inheritance, and **base class**, IE:
	- **class DerivedClass : BaseClass**
	
3. All user defined types inherit from some base class. *Structs* inherit from *System.ValueType* and *Classes* inherit from *System.Object*.

4. If the base class does not contain a *default constructor*, the compiler will *automatically* create one and call it before instantiating the derived class.

5. You can assign a variable of a derived class to another variable of its base class *if* the derived class is *lower* in the heirarchy and *inherits*all basic members from the base class.

6. No, you cannot assign a variable of a derived class to another variable of its base class when creating a derived class. If they are the *same* level in the hierarchy, they *cannot* be assigned to eachother.

7. You can assign a variable of a base class to another variable of a derived class as long as it is first checked with the *as* or *is* operators, or if it is *casted*.

8. You should use the *new* keyword when defining a method in a derived class when you are informally *overriding* the base class method and want to *silence* the method. It is a best practice to use the *new* keyword here in order to avoid confusion.

9. A *virtual method* is a method in the base class that is able to be *overridden* and given *new implementation* by a derived class. A virtual method *cannot* be private, and both the virtual and override method signatures *must* be identical.

10. The *override* keyword signifies that a method in a derived class has a *different implementation* that the base class.

11. You define an *extension type* as a static class with static methods and bring them into scope via *using* directives. These can be accessed via *dot notation* with the correct parameters. The *this* keyword must also be used in order to identify that this is an *extension method*.

12. *Extension types* can be helpful when you want to extend the functionality of a class without modifying existing code.

13. The *Liskov Substitution* principle states that all derived types must be able to be replaced by the base class without effecting *correctness*, *task performance*, etc. This equates to *backward compatibility* For example, if it looks like a duck and quacks like a duck, more specific types shouldn't require batteries.