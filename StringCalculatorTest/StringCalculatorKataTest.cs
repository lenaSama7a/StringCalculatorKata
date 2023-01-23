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
            int expectedNumber;
            int actualNumber = 0;
            //Act
            expectedNumber = _sc.Add("");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Sum of numbers in string with one number")]
        [Owner("Lena")]
        public void StringWithOneNumber()
        {
            //Arrange
            int expectedNumber;
            int actualNumber = 5;
            //Act
            expectedNumber = _sc.Add("5, L, S");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Sum of numbers in string with two numbers")]
        [Owner("Lena")]
        public void StringWithTwoNumbers()
        {
            //Arrange
            int expectedNumber;
            int actualNumber = 16;
            //Act
            expectedNumber = _sc.Add("10, L, 6");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Adding numbers in unknown-length string ")]
        public void StringWithunknownNumbers()
        {
            //Arrange
            int expectedNumber;
            int actualNumber = 26;
            //Act
            expectedNumber = _sc.Add("16, 10, Lena");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Sum of numbers in string with new lines between numbers")]
        public void StringWithNewLines()
        {
            //Arrange
            int expectedNumber;
            int actualNumber = 10;
            //Act
            expectedNumber = _sc.Add("5,4\n1");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        [Description("Adding numbers in string with different delimiters")]
        public void StringWithDifferentDelimiters()
        {
            //Arrange
            int expectedNumber;
            int actualNumber = 3;
            //Act
            expectedNumber = _sc.Add("//;\n1;2");
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
            int expectedNumber;
            int actualNumber = 2;
            //Act
            expectedNumber = _sc.Add("1001, 2, D");
            //Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }
    }
}
