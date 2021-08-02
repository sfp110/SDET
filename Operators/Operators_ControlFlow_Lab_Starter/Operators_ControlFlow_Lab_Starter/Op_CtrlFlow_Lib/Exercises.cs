using System.Collections.Generic;
using System;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        //THIS METHOD RETURNS TRUE IF THE NUMBERS ARE DIFFERENT AND IF NUM2 IS A FACTOR OF NUM1
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;

            //divide num1 by num2 and return the remainder.
            //If the remainder is 0, that expression is true
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            //if(nums.Count == 0)
            //{
            //    return 0;
            //}
            if(nums.Count == 0)
            {
                throw new ArgumentOutOfRangeException("0");
                //return 0;
            }
            
            double average = 0;
            for(int i = 0; i< nums.Count; i++)
            {
                average += nums[i];
            }
            return average / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {

            if(age > 122 || age < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong age number.");
            }

            string ticketType = string.Empty;
            if (age >= 60)
            {
                ticketType = "OAP";
            }
            else if (age >= 18 && age < 60)
            {
                ticketType = "Standard";
            }
            else if (age >= 13 && age < 18)
            {
                ticketType = "Student";
            }
            else if (age >= 5 && age < 13)
            {
                ticketType = "Child";
            }
            else
                ticketType = "Free";


            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";

            if(mark > 100 || mark < 0)
            {
                throw new ArgumentOutOfRangeException(" Mark can't be : " + mark);
            }

            if (mark >= 75 && mark <= 100)
                grade = "Pass with Distinction";
            else if (mark >= 60 && mark < 75)
                grade = "Pass with Merit";
            else if (mark >= 40 && mark < 60)
                grade = "Pass";
            else
                grade = "Fail";

            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            return 0;
        }
    }
}
