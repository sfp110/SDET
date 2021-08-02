using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;
using System;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        // Are these 2 numbers different ? And if so is num1%num2 even?

        //n^2%n = 0

        //BUT 

        // 3 % 3*5

        // 2 % 2*5

        // 7 % 7*5

        //YEAH... Didn't know there was such a thing as a composite number.

        //I have been trying to reivent the wheel when it comes to prime numbers -.-'

        //I'm basically saying, 

        //[TestCase(10,5)]
        //public void GivenTwoDifferentNumbersOneTheDoubleOfTheOther_TheResult_ReturnsTrue(int num1, int num2)
        //{
        //    Assert.That(Exercises.MyMethod(num1,num2), Is.EqualTo(true));
        //}

        //[TestCase(10, 10)]
        //public void GivenTwoEqualNumbers_TheResult_Returnsfalse(int num1, int num2)
        //{
        //    Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(false));
        //}
        [TestCase(15,3,true)]
        [TestCase(6, 2,true)]
        [TestCase(35,7,true)]
        [TestCase(11, 5, false)]

        //Is num2 a factor of num1?
        public void GivenTwoDifferentNumbers_IsTheResult_ACompositeNumber(int num1, int num2, bool result)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(result));
        }

        // Factor, in mathematics, a number or algebraic expression that divides another number or expression evenly—i.e., with no remainder.
        // For example, 3 and 6 are factors of 12 because 12 ÷ 3 = 4 exactly and 12 ÷ 6 = 2 exactly.
        // The other factors of 12 are 1, 2, 4, and 12.
        // A positive integer greater than 1, or an algebraic expression, that has only two factors (i.e., itself and 1) is termed prime;
        // a positive integer or an algebraic expression that has more than two factors is termed composite.

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        //[Test]
        //public void WhenListIsEmpty_Average_ReturnsZero()
        //{
        //    var myList = new List<int>() {};
        //    Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        //}

        [Test]
        public void WhenListIsEmpty_Average_ThrowsException()
        {
            var myList = new List<int>() {};
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(123)]
        public void TicketTypeTest_OlderThan100_YoungerThan0(int age)
        {
            //var result = Exercises.TicketType(age);
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(104)]
        public void GradeMark_BiggerThan100_or_SmallerThan0(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Mark can't be : " + mark));
        }

        [TestCase(88)]
        public void GivenGradeMarkBetween_75_and_100(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Is.EqualTo("Pass with Distinction"));
        }

        [TestCase(63)]
        [TestCase(74)]
        public void GivenGradeMarkBetween_60_and_75(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Is.EqualTo("Pass with Merit"));
        }

        [TestCase(40)]
        [TestCase(59)]
        public void GivenGradeMarkBetween_40_and_60(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Is.EqualTo("Pass"));
        }
        [TestCase(33)]
        [TestCase(39)]
        public void GivenGradeMarkBetween_0_and_40(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Is.EqualTo("Fail"));
        }
    }
}
