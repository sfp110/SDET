using System;
using System.Text;

namespace MoreDataTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilderMethod();


            ShowEnumNumbers();

            Enums();

            //DateTimeMethods();

            //MultiDimensionsArray();

            //JaggedArray();


            int[] myIntArray = { 12, 23, 34, 45, 56 };

            Array.Reverse<int>(myIntArray);

            foreach(var element in myIntArray)
            {
                Console.WriteLine(element);
            }

            //------------------------------------------------------
            Console.WriteLine("How many apples");
            string input = Console.ReadLine();

            //int numApples = Int32.Parse(input);


            var success = (Int32.TryParse(input, out int parsedApples));

            //Console.WriteLine(parsedApples);

            //------------------------------------------------------
            int typeOfSpecification = 1;
            var myString = " C# list fundamentals ";
            //Console.WriteLine(StringExercise(myString, typeOfSpecification));
            StringInterpolation("Sergio");

            var num1 = 2;
            var num2 = 7;

            var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";

            var fString2 = $"Log to the base {num2} of {num1} is {Math.Log(num2, num1):0.####}";
            var fString3 = $"That will be {num2 / 3.0:C} please!";

           //------------------------------------------------------
        }

        public static void StringBuilderMethod()
        {
            const int sLen = 30, Loops = 5000;
            DateTime sTime, eTime;
            int i;
            string sSource = new String('X', sLen);
            string sDest = "";
            // 
            // Time string concatenation.
            // 
            sTime = DateTime.Now;
            for (i = 0; i < Loops; i++) sDest += sSource;
            eTime = DateTime.Now;
            Console.WriteLine("Concatenation took " + (eTime - sTime).TotalSeconds + " seconds.");
            // 
            // Time StringBuilder.
            // 
            sTime = DateTime.Now;
            System.Text.StringBuilder sb = new System.Text.StringBuilder((int)(sLen * Loops * 1.1));
            for (i = 0; i < Loops; i++) sb.Append(sSource);
            sDest = sb.ToString();
            eTime = DateTime.Now;
            Console.WriteLine("String Builder took " + (eTime - sTime).TotalSeconds + " seconds.");
            // 
            // Make the console window stay open
            // so that you can see the results when running from the IDE.
            // 
            Console.WriteLine();
            Console.Write("Press Enter to finish ... ");
            Console.Read();
        }
        public enum SUIT
        {
            HEARTS,
            CLUBS,
            DIAMONDS,
            SPADES
        }

        public static void Enums()
        {
            SUIT theSuitName = SUIT.HEARTS;
            int theSuit = 3;
            //if (theSuit == (int)SUIT.SPADES)
            if (theSuitName == SUIT.SPADES)
            {
                Console.WriteLine($"The Suid is {SUIT.SPADES}");
            }
            else
            {
                Console.WriteLine($"The suit is {(SUIT)theSuit} not {SUIT.SPADES}");
            }

            var anotherSuit = Enum.Parse(typeof(SUIT), "DIAMONDS");
        }

        public enum Size
        {
            SMALL= 10,
            MEDIUM = 25,
            LARGE = 50,
            EXTRA_LARGE
        }
        public static void ShowEnumNumbers()
        {
            var arrayOfValues = Enum.GetValues(typeof(Size));

            foreach(var element in arrayOfValues)
            {
                Console.WriteLine(element);
            }
        }

        public static void DateTimeMethods()
        {
            var now = DateTime.Now;
            Console.WriteLine("The time is now " + now);
            Console.WriteLine($"The time is now {now.Ticks}");

            var tomorrow = now.AddDays(1);
            Console.WriteLine($"Tomorrow it will be {tomorrow} with {now.Ticks} ticks");

        }


        public static void MultiDimensionsArray()
        {
            int[,] grid = new int[2, 4];
            grid[0, 1] = 6;
            grid[1, 3] = 8;
            grid[1, 3] = 10;

            //Rows first 

            //4 rows , 2 columns

            char[,] gridTwo = { {'a','b',},
                                {'c','d',},
                                {'e', 'f'},
                                {'g','h' }};

            foreach(var element in gridTwo)
            {
                Console.WriteLine(element);
            }

            for(int i = gridTwo.GetLowerBound(0); i<= gridTwo.GetUpperBound(0);i++)
            {
                for(int j = gridTwo.GetLowerBound(1); j<= gridTwo.GetUpperBound(1); j++)
                {
                    Console.Write($"({i},{j}) {gridTwo[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        public static void JaggedArray()
        {
            //arrow first, columns after
            int[][] intJArray = new int[2][];
            intJArray[0] = new int[4];
            intJArray[1] = new int[2];

            intJArray[0][2] = 3;
            intJArray[1][0] = 5;

            string[][] animalJArray = new string[][]
            {
                new string[] {"llama","puma","horse","kitchen"},
                new string[] {"haddock", "tuna" }
            }; // 2 rows, the first with 4 columns, the second with 2 columns


            Console.WriteLine("Jagged array of animals");
            foreach(var row in animalJArray)
            {
                foreach(var entry in row)
                {
                    Console.WriteLine($"{entry}");
                }
            }
            

        }

        public static void StringInterpolation(string str)
        {
            //Concatonation
            Console.WriteLine("My name is : " + str + " using concatenation (+)");

            //Interpolation
            Console.WriteLine($"My name is : {str} using interpolation");

        }

        public static string StringExercise(String myString, int typeOfSpecification)
        {
            //string result = string.Empty;
            //switch (typeOfSpecification)
            //{
            //    case 1:
            //        result = myString.Trim();
            //        break;
            //    case 2:
            //        result = myString.ToUpper();
            //        break;
            //    case 3:
            //        result = myString.Replace('L', '*').Replace('N', '*');
            //        break;
            //    case 4:
            //        int index = myString.IndexOf("N");
            //        if (index >= 0)
            //            result = result.Substring(0, index);
            //        break;

            //    default:
            //        break;
            //}

            //var trimmedString = myString.Trim();
            //var ucString = trimmedString.ToUpper();
            //var replacedString = ucString.Replace('L', '*');
            //var replacedString2 = replacedString.Replace('T', '*');
            //var nPos = replacedString2.IndexOf('N');
            //var finalString = replacedString2.Remove(nPos + 1);
            //return finalString;

            var result = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
            var index = result.IndexOf('N');
            result = result.Remove(index + 1);

            //I'm only adding a line of code here to test if I can have the repo in both computers
            //and that it won't result in any issues.


            return result;
        }

        public static string StringBuilderExercise(string myString)
        {
            var trimmedUpperString = myString.Trim().ToUpper();
            var pos = trimmedUpperString.IndexOf('N');

            StringBuilder sb = new StringBuilder(trimmedUpperString);

            sb.Replace('L', '*').Replace('T', '*').Remove(pos + 1, (sb.Length - pos - 1));

            return sb.ToString();
        }
    }
}
