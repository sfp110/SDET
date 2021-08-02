using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public class LoopTypes
    {
        internal static int HighestForEachLoop(List<int> nums)
        {
            var highest = nums[0];
            foreach(int n in nums)
            {
                if(highest < n)
                {
                    highest = n;
                }
            }

            return highest;
        }
        internal static int HighestForLoop(List<int> nums)
        {
            int highest = nums[0];

            for(int i =0; i< nums.Count; i++)
            {
                if(highest < nums[i])
                {
                    highest = nums[i];
                }
            }

            return highest;
        }
        internal static int HighestWhileLoop(List<int> nums)
        {
            var highest = nums[0];
            int iteration = 0;

            while (iteration < nums.Count)
            {
                if(highest < nums[iteration])
                {
                    highest = nums[iteration];
                }

                iteration++;
            }
            return highest;
        }
        internal static int HighestDoWhileLoop(List<int> nums)
        {
            var highest = nums[0];
            int iteration = 0;

            do
            {
                if (highest < nums[iteration])
                {
                    highest = nums[iteration];
                }

                iteration++;
            }

            while (iteration < nums.Count);

            return highest;
        }
    }
}
