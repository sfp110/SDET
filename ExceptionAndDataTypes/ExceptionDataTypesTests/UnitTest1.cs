using NUnit.Framework;
using ExceptionTypes;
using System;

namespace ExceptionDataTypesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-34)]
        [TestCase(-1)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int grade)
        {
            Assert.That(() => Program.Grade(grade), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Mark can't be : " + grade));
            // Do this first - () => Program.Grade(grade) 

            // and then compary it to Throws.TypeOf<ArgumentOutOfRangeException>()
            // Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Mark can't be : " + grade)
            // is another example of an expression to compare it to. It's more specific 

            // () => IS A LAMDA EXPRESSION  
        }

        [TestCase(101)]
        [TestCase(122)]
        public void WhenMarkIsGreaterThan100_Grade_ThrowsAnArgumentOutOfRangeException(int grade)
        {
            Assert.That(() => Program.Grade(grade), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Mark can't be : " + grade));
            
        }


    }
}