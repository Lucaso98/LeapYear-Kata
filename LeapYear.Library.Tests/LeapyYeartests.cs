using NUnit.Framework;
using System;

namespace LeapYear.Library.Tests
{
    [TestFixture]
    public class LeapyYeartests
    {
        [Test]
        public void Test_DivisibleBy4_ReturnsLeapYear()
        {
            // Arrange
            int input = 2000;

            // Act
            string output = LeapYearer.getValue(input);

            // Assert
            Assert.AreEqual("Leap Year", output);
        }
        
        [Test]
        public void Test_DivisibleBy4And100_ButNotDivisible400_ReturnsNotLeapYear()
        {
            int input = 1900;
            string output = LeapYearer.getValue(input);
            Assert.AreEqual("NOT Leap Year", output);
        }

        [Test]
        public void Test_NotDivisibleBy4_ReturnsNotLeapYear()
        {
            int input = 2450;
            string output = LeapYearer.getValue(input);
            Assert.AreEqual("NOT Leap Year", output);
        }
        
    }
}
