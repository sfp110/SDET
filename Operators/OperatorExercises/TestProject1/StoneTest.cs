using OperatorsApp;
using NUnit.Framework;

namespace TestProject1
{
    class StoneTest
    {
        /*
        [TestCase(156, 11)]
        public void GivenTotalPounds_GetStones_ReturnsStones(int totalPounds, int expResult)
        {
            Assert.That(Methods.GetStones(totalPounds), Is.EqualTo(expResult));
        }

        [TestCase(7, 0)]
        [TestCase(15, 1)]
        [TestCase(156, 11)]
        public void GivenTotalStones_GetPounds_ReturnsStones(int totalStones, int expResult)
        {
            Assert.That(Methods.GetStones(totalStones), Is.EqualTo(expResult));
        }
        */

        [TestCase(64, "Fail")]
        public void GivenAGradeLessThan65_Grade_ReturnsFail(int gradeValue, string expResult)
        {
            Assert.That(Methods.GetGrade(gradeValue), Is.EqualTo(expResult));
        }
        [TestCase(65, "Pass")]
        public void GivenAGradeLessThan65_Grade_ReturnsPass(int gradeValue, string expResult)
        {
            Assert.That(Methods.GetGrade(gradeValue), Is.EqualTo(expResult));
        }
        [TestCase(86, "Distinction")]
        public void GivenAGradeMoreThan85_Grade_ReturnsDistinction(int gradeValue, string expResult)
        {
            Assert.That(Methods.GetGrade(gradeValue), Is.EqualTo(expResult));
        }


    }
}
