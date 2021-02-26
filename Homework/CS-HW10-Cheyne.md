# C# Homework 10

---

**Cheyne Lowery**

**February 11, 2021**

**CS-HW10-Cheyne.md**

---

1. An *initialized array* is a contiguous block of memory holding a collection of variable(s), it can also expand or contract.

2. An array that is *only declared* is stored on the *stack* as a valute type. An array that is initialized is stored on the *heap* as a reference type.

3. Memory allocated to hold an array reference is stored on the *stack*.

4. An array can hold types of which it is declared to hold. An array can also hold all types which can be *upcasted*, or types that *inherit* from the initial type, IE: **double[]** can hold <double> & <int> **object[]** can hold <class>, <struct>, <enum> (reference to reference)
	
5. A *foreach* loop always iterates through the entire array, IE:
	- Set the sentinal value: **([0] through [.Length - 1])**
	- Write the loop: **foreach ([dataType] [randomVarName] in [collectionName]) { };**
		
6. A *deep copy array/collection* means that the collection values point to different addresses on the heap. You can only create a deep copy array by using a for loop: Initialize, Create a new array of the same size, write a for loop, assigning the values from array one to array two using corresponding indexes, IE:
	- **string[] people = { "Cheyne", "PhilLazangna", "Doniel" };**
	- **string[] people2 = new string[pins.Length];**
	- **for (int person = 0; person < people.Length; person++)**
	- **{**
	- **people2[person] = people[person];**
	- **}**
	
7. The difference in syntax between a *multidimensional array* and an *array of arrays (jagged arrays)* is that you specify a column between the square
brackets in the arrayDatatype for a *multidimensional array*, in order to indicate how many dimensions you want to include **(one comma = 2D, two commas = 3D, etc)**. You must also specify the length of each column in the array declaration by using numeric values between the commas. In an *array of arrays*, you use two sets square brackets in the array datatype and array declaration, specifying amount of child arrays with a numeric value in the first set of square brackets. You must then initialize the size and data for each child array, IE:
	- Multidimensional Array: **double[, ,] ohBabyATriple = new double[2, 2, 2]** This is a 3D array, each columns declared with a size of 2, and indexes 0 and 1.
	- Array of arrays (jagged array):
	- **double [][] ohBabyATriple2 = new double[3][];** This is a jagged array containing 3 child arrays.
	- **double[] first = new double[] {1, 4, 6};**
	- **double[] second = new double[] {3, 9, 7};**
	- **double[] third = new double[] {1, 25, 46};**
	- Each child array is dynamic and initialized to the values in the curly braces.

8. You can determine the use case for either a *jagged array* or *mutltidimensional array* by understanding whether your *third dimension/child arrays*are going to be of varying sizes. Comes down to *memory optimization*.

9. To *flatten* a *multidimension array*, use the method **.SelectMany** provided by the **System.Linq (Language Integrated Query) namespace**. It takes the values from any *enumerable collection* and reformts them in a *one dimensional* list, IE:
	- **int[][] arr1 = new [2][];**
	- **int[] first = new int[] {1, 2, 3};**
	- **int[] second = new int[] {4, 5, 6};**
	- **var myCollection = arr1.SelectMany(a => a.Value);**
	- OR you can use nested *for loops*.
				
10. You can only modify elements in an array with *for loops*, because the *foreach loop* only provides *read-only* copies of each element in the array.