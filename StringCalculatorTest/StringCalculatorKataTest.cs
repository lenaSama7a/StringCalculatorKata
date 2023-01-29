using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator_Kata;
namespace StringCalculatorTest
{
    [TestClass]
    public class StringCalculatorKataTest
    {
        private StringCalculator _sc;
        public StringCalculatorKataTest()
        {
            _sc = new StringCalculator();
        }

        [TestMethod]
        [Description("Sum of numbers in empty string")]
        [Owner("Lena")]
        public void EmptyString()
        {
            //Arrange
            int actualNumber;
            int expectedNumber = 0;
            //Act
            actualNumber = _sc.Add("");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Sum of numbers in string with one number")]
        [Owner("Lena")]
        public void StringWithOneNumber()
        {
            //Arrange
            int actualNumber;
            int expectedNumber = 5;
            //Act
            actualNumber = _sc.Add("5");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Sum of numbers in string with two numbers")]
        [Owner("Lena")]
        public void StringWithTwoNumbers()
        {
            //Arrange
            int actualNumber;
            int expectedNumber = 16;
            //Act
            actualNumber = _sc.Add("10, 6");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Adding numbers in unknown-length string ")]
        public void StringWithunknownNumbers()
        {
            //Arrange
            int actualNumber;
            int expectedNumber = 26;
            //Act
            actualNumber = _sc.Add("16, 10");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Sum of numbers in string with new lines between numbers")]
        public void StringWithNewLines()
        {
            //Arrange
            int actualNumber;
            int expectedNumber = 10;
            //Act
            actualNumber = _sc.Add("5,4\n1");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Adding numbers in string with different delimiters")]
        public void StringWithDifferentDelimiters()
        {
            //Arrange
            int actualNumber;
            int expectedNumber = 6;
            //Act
            actualNumber = _sc.Add("//;\n5;1");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Throw an exception if string has negative numbers")]
        public void StringWithNegativeNumbers()
        {
            try
            {
                _sc.Add("1, 4, -1, -5, -7");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            //this is message to be showen if the test is failed:
            Assert.Fail("call to fileExist() didn't throw an ArgumentNullException");
        }

        [TestMethod]
        [Description("ignore big numbers in string")]
        public void StringWithBigNumbers()
        {
            //Arrange
            int actualNumber;
            int expectedNumber = 2;
            //Act
            actualNumber = _sc.Add("1001, 2");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("ignore non digit characters in string")]
        public void StringWithCharacters()
        {
            //Arrange
            int actualNumber;
            int expectedNumber = 7;
            //Act
            actualNumber = _sc.Add("5, Lena, 2, D");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }
    }
}
