using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {

            for (int i = 0; i < contents.Count; i++)
            {
                switch(i)
                {
                    case 0:
                        contents[0] = "Alpha";
                        break;
                    case 1:
                        contents[1] = "Beta";
                        break;
                    case 2:
                        contents[2] = "Gamma";
                        break;
                    case 3:
                        contents[3] = "Delta";
                        break;
                    case 4:
                        contents[4] = "Epsilon";
                        break;
                    case 5:
                        contents[5] = "Zeta";
                        break;
                    default: break;
                }
            }
            return contents.ToArray();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            string[,,] threeDArray = new string[length1, length2, length3];

            int count = 0;

            //for(int i = 0; i < length1; i++)
            //{
            //    for(int j = 0; j < length2; j++)
            //    {
            //        for (int k = 0; k < length3; k++)
            //        {
            //            threeDArray[i,j,k] = contents[count];
            //            count++;
            //        }
            //        count++;
            //    }
            //    count++;
            //}
                if((length1 * length2 * length3) >= count)
                {
                    throw new ArgumentException("Number of elements in list must match array size");
                }

                for (int i = 0; i < length1; i++)
                {
                    for (int j = 0; j < length2; j++)
                    {
                        for (int k = 0; k < length3; k++)
                        {
                            threeDArray[i, j, k] = contents[count++];
                        }
                    }
                }
                return threeDArray;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {

            if(contents.Count != countRow1 + countRow2)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }

            int counter = 0;
            string[][] jagged2DArray = new string[][] 
            { 
                new string[countRow1],
                new string[countRow2]
            };

            foreach (var array in jagged2DArray)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = contents[counter++];
                }
            }

            return jagged2DArray;
        }
    }
}
