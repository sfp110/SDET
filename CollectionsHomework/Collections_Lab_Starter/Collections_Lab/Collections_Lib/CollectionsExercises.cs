using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string result = string.Empty;

            if (num == 0 || num < 0)
            {
                return string.Empty;
            }

            while (num-- > 0 && queue.Count > 0)
            {
                result += queue.Dequeue() + ", ";
            }

            //I had to remove 2 because I was adding the comma and the space afterwards!
            return result.Remove(result.Length-2, 2);
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int[] reversed = new int[original.Length];

            var stack = new Stack<int>();

            foreach(var item in original)
            {
                //Push the ints to the stack
                stack.Push(item);
            }

            for(int i = 0; i < original.Length; i++)
            {
                reversed[i] = stack.Pop();
            }
            
            return reversed;

        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            string result = "";

            string newNumbers = string.Empty;

            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                    newNumbers += input[i];
            }

            foreach (var x in newNumbers)
            {
                if (dictionary.ContainsKey(x))
                {
                    dictionary[x]++;
                }
                else
                {
                    dictionary.Add(x, 1);
                }
            }

            
            foreach (var entry in dictionary)
            {
                result += entry + "";
            }
            return result; //might need to concatonate the result
        }
    }
}
