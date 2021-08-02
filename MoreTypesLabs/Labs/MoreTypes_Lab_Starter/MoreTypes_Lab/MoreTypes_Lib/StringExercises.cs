using System;
using System.Text;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string result = input.ToUpper().Replace(" ", string.Empty);

            for(int i = 0; i < num; i++)
            {
                result += i;
            }

            return result;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            string result = $"{number} {street}, {city} {postcode}.";

            return result;
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            var outOfResult = ((Single)score / outOf) * 100.0;

            string result = $"You got {score} out of {outOf}: {outOfResult.ToString("0.#")}%";

            return result;
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
           if( Double.TryParse(numString, out double numStringParsed))
            {
                return numStringParsed;
            }
            else
            {
                return -999;
            }
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            input.ToUpper();
            
            var a = 0; var b = 0; var c = 0; var d = 0;

            for(int i=0; i< input.Length; i++)
            {
                switch(input[i])
                {
                    case 'A':
                        a++;
                        break;
                    case 'B':
                        b++;
                        break;
                    case 'C':
                        c++;
                        break;
                    case 'D':
                        d++;
                        break;
                    default:
                        break;
                }
            }

            return $"A:{a} B:{b} C:{c} D:{d}";
        }
    }
}
