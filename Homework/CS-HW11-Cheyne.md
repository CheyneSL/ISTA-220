# C# Homework 11

---

**Cheyne Lowery**

**February 18, 2021**

**CS-HW11-Cheyne.md**

---

1. A *parameter array* is a an array that acts as a parameter to a method. It allows the method to use an *arbitrary number of arguments* of varying types.

2. To define an array that takes an arbitrary number of arguments *(parameter array)*, you must delcare the a method and in the parameter list, declare an array prefixed by the *params* keyword, and the variable name, IE:
	- **public int myMethod(params int[] paramArray)**

3. To call a method that takes an *arbitrary number of arguments*, simply call the method with a comma separated list of values as the arguments. The values must be of the *same type* as the *params array* in the method declaration, unless the *params array* is of type *System.Object*, IE:
	- **myMethod(1, Cheyne, false); //method that takes any number of arguments of any type.**

4. You can't use an array to pass an arbitrary number of arguments to a method because the array must be declared and instantiated, and once instantiated, the array is a fixed size. You can use *anonymous arrays*, but the extra syntax becomes cumbersome and can be better completed via paramter arrays.

5. A method can have *any number of parameters* through *parameter arrays*.

6. Parameter arguments do not have to have the same type by declaring the parameter array of type *Object* from *System.Object*.

7. A method that takes a *parameter array* can take an *arbitrary number* of paramters, whereas a *method* that takes optional parameters only accepts a *fixed amount* of arguments.

8. To define a method that takes *different and arbitrary* types of arguments, you must define a method, and a params array of type *Object* from *System.Object*.

9. Write a method that accepts any number of arguments of a given type:
	- **public void myMethd(params string[] stringList) {//code}**

10. Write a method that accepts any number of arguments of any type:
	- **public void myMethod(params Object[] objectList) {//code};**