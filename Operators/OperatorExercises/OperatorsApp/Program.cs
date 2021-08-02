using System;
using System.Collections.Generic;

namespace OperatorsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOdd(22));
            // i++ is different from ++i

            int i = 0;

            i = ++i; // == 1
            i = i++; // == 0

            Console.WriteLine(i);


            /*
             * The behavior is well defined in C# and the evaluation order is:
             * 
             * Left side i is evaluated to the variable i
             * Right side is evaluated to 0, and i is incremented (now i==1)
             * The assignment is executed, it sets i to 0. (now i==0)
             * 
             * The end result is i==0.
             */



            List<int> nums = new List<int> { 10, 6, 22, -17, 3 };

            Console.WriteLine("The Highest number in the Foreach is: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("The Highest number in the For Loop is: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("The Highest number in the While Loop is: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("The Highest number in the DoWhile Loop is: " + LoopTypes.HighestDoWhileLoop(nums));
        }

        public static bool EvenOdd(int number)
        {
            //returns true if the result = 0
            //else is not even
            return number % 2 == 0;
        }
        public static string Priority(int level)
        {
            string priorityLevel = "Code: ";
            switch (level)
            {
                case 3:
                    priorityLevel = priorityLevel + "RED";
                    break;
                case 2:
                case 1:
                    priorityLevel = priorityLevel + "AMBER";
                    break;
                case 0:
                    priorityLevel = priorityLevel + "GREEN";
                    break;
                default:
                    priorityLevel = "NOT SELECTED";
                    break;
            }

            return priorityLevel;
        }
    }
}
