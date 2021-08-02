using System;
using System.IO;
using System.Collections.Generic;

namespace ExceptionTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var text = File.ReadAllText("HelloWorld.txt");
            int catyGrade = -23;
            //string text;
            //string path = "HelloWorld.txt";

            //try
            //{
            //    text = File.ReadAllText(path);
            //    Console.WriteLine(text);
            //}
            //catch ( FileNotFoundException e)
            //{
            //    Console.WriteLine("Sorry I can't find: " + path);
            //    Console.WriteLine(e.Message);
            //}
            //catch(ArgumentException ae)
            //{
            //    //Console.WriteLine("Sorry you gave an empty named file");
            //    Console.WriteLine(ae.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("We made it here.");
            //}

            double pi = 3.141592654;

            float x = (float)pi;


            var name = "Cathy";
            var isClean = true;
            var letter = 'P';
            var uLongNum = 52uL;


            var prices = new List<decimal>();
            //var prices = List<decimal> prices 

            short n1 = -65;
            ushort n2 = 65;
            int n3 = -100_000;
            uint n4 = 100_000;
            var max = Int32.MaxValue;
            uint n5 = 4_000_000_000;
            long n6 = long.MaxValue;
            ulong n7 = ulong.MaxValue;

            nuint nuInteger = nuint.MaxValue;

            float sum = 0;


            Console.WriteLine(TryThis(byte.MaxValue))   ;

            for (int i =0; i< 100_000; i++)
            {
                sum += 2 / 5.0f;
            }

            float correctValue = 2 / 5.0f * 100000;
            Console.WriteLine("The result added 100 000x is " + sum);
            Console.WriteLine("The result of 2/5.0f * 100 000 = " + correctValue);

            Console.WriteLine("The values are " + sum + " and " + correctValue);
            Console.WriteLine("The difference is " + (correctValue - sum));


            try
            {
                Console.WriteLine(Grade(catyGrade));
            }
            catch ( ArgumentOutOfRangeException e )
            {
                //Console.WriteLine("Caty's grade " + catyGrade + " is weird!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //FINALLY IS ALWAYS READ REGARDLESS IF AN EXCEPTION IS THROWN OR NOT (if it catches or not)
                Console.WriteLine("Bananas");
            }

        }
        public static byte TryThis( byte x)
        {
            return ++x;
        }
        public static string Grade(int mark)
        {
            if(mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark can't be : " + mark);
            }

            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}
