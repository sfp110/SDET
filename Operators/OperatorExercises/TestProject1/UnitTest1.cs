using NUnit.Framework;
using OperatorsApp;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(4)]
        public void TestMethod1(int x)
        {
            Assert.That(Program.EvenOdd(x), Is.EqualTo(true));
        }

        [TestCase(3, "Code: AMBER")]
        //NUmber 3 should fail. 
        [TestCase(2,"Code: AMBER")]
        [TestCase(1, "Code: AMBER")]
        public void GivenALevelOf2_Priority_ReturnsAmber(int level, string expResult)
        {
            Assert.That(Program.Priority(level), Is.EqualTo(expResult));
        }
    }
}