using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(int n)
        {
            
            long result = 1;
            for(int i = n; i > 0;  i--)
            {
                result *= i;
            }

            return checked(result);
        }

        public static float Mult(float num1, float num2)
        {
            return (float)Math.Round((num1 * num2),5);
        }
    }
}
