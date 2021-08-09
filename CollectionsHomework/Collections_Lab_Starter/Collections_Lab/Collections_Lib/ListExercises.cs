using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> myList = new List<int>();

            for(int i=1; i <= max; i++)
            {
                if(i % 5 == 0)
                {
                    myList.Add(i);
                }
            }

            return myList;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> letteredList = new List<string>();

            foreach(var item in sourceList)
            {
                string x = item.Substring(0,1);

                if(x =="a" || x == "A")
                {
                    letteredList.Add(item);
                }
            }

            return letteredList;
        }
    }
}
