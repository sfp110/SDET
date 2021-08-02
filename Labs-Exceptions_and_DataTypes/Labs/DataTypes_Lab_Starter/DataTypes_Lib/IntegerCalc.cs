using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            int result = checked(num1 + num2);

            //checked keyword checks if the the addition is orverflown.
            //if so , throws an OvverFlowException

            //if (num1 + num2 > int.MaxValue)
            //{
            //    throw new OverflowException();
            //}

            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return checked(num1 - num2);
        }

        public static int Multiply(int num1, int num2)
        {
            return checked(num1 * num2);
        }

        public static int Divide(int num1, int num2)
        {
            if( num2==0)
            {
                throw new ArgumentException("Can't divide by zero");
            }
            return checked(num1 / num2);
        }

        public static int Modulus(int num1, int num2)
        {
            if( num2 == 0)
            {
                throw new ArgumentException("Can't modulo by zero");
            }
            return checked(num1 % num2);
        }
    }
}
