using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public class Methods
    {

        // 1 stone = 14 pounds
        public static int GetStones(int totalPounds)
        {
            return totalPounds / 14;
        }
        public static int GetPounds(int totalStones)
        {
            return totalStones % 14;
        }

        public static string GetGrade(int gradeValue)
        {

            var grade = gradeValue >= 65 ? (gradeValue >= 85 ? "Distinction" : "Pass") : "Fail";

            return grade;
        }

    }
}
