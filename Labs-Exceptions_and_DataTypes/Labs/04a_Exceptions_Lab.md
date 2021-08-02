<img src="https://boolerang.co.uk/wp-content/uploads/job-manager-uploads/company_logo/2018/04/SG-Logo-Black.png" alt="Sparta Logo" width="200"/>

---   
# Lab - Exceptions

Over the last few days we have seen several examples of methods whose input may be outside of a valid range:
- 02a Introduction to Unit tests lesson:
  - `Greeting` method 
- 02a Unit Test Lab:
  - `AvailableClassifications` method
- 03 Operators and Control Flow lesson
    - `GetStones` method
    - `GetPounds` method
- 03 Operators and Control Flow Lab
  - `Average` method
  - `TicketType` method
  - `Grade` method
  - `GetScottishMaxWeddingNumbers` method

Change each method so it throws an exception if invalid input is received.  

For the `Average` method, throw an exception if the array is empty.

Add unit tests to test that the correct `Exception` type is thrown.  Be sure you have tests either side of the valid/invalid data boundary.