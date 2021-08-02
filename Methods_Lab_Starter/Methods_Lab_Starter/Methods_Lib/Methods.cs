using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if(totalDays<0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            return ((int)(totalDays / 7), totalDays % 7);

        }

        public static int RollDice(Random rng)
        {
            //min inclusive, max exclusive
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}
