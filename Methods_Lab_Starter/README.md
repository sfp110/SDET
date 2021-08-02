<img src="https://boolerang.co.uk/wp-content/uploads/job-manager-uploads/company_logo/2018/04/SG-Logo-Black.png" alt="Sparta Logo" width="200"/>

---   
# Lab - Methods

## Setup
Download the starter code `Methods_Lab_Starter` and open it in Visual Studio.

## Lab

1.  Implement the method `MethodsLib.Methods.DaysAndWeeks` so it returns a tuple (week, days) corresponding to a given number of days, and passes the relevant tests in `Methods._Tests.TuplesTests`.

2.  Implement a `static` method called `PowersRoot` in the `MethodsLib.Methods` class which given a number of type `int`, returns a tuple containing:
- the number's square (an int)
- cube (an int)
- and square root (a double) 
 *(hint - call a method of the `Math` class)*.  

    Write unit tests for this method in the `Methods_Tests.TuplesTests` class.

3. In the class `Methods_Tests.DiceTests`, write unit tests for the method `MethodsLib.Methods.RollDice` .  The tests should ensure that:
- the number returned is between 1 and 12 inclusive.
- the number returned is correct *(Hint - you can use the `Random(Int32)` constructor overload to create a random number generator that always generates the same sequence of values )*



