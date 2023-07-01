using System;
using Sparky;

namespace Sparky.MSTest
{
    [TestClass]
    public  class CalculatorMSTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Arrange : 

            Calculator calc = new();
            // Act
            var result = calc.AddNumbers(1,2);

            // Assert 
            Assert.AreEqual(3,result);

        }
    }
}
