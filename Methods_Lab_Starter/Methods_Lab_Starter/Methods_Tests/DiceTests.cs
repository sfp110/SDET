using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [Test]
        public void GivenTwoDice_TestMinValue()
        {
            Random newRandomNumber = new Random();

            Assert.That(Methods.RollDice(newRandomNumber), Is.AtLeast(2).And.AtMost(12);
        }

    }
}
