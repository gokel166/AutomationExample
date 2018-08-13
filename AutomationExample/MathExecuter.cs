using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExample
{
    [TestClass]
    public class MathExecuter
    {
        [TestMethod]
        private void AdditionSolution_IsValid()
        {
            // Arrange
            MathExecute me = new MathExecute();

            // Act
            var results = me.AdditionFunction(4, 8);

            // Assert
            Assert.AreEqual(12, results);
        }

        [TestMethod]
        private void SubtractionSolution_IsValid()
        {
            // Arrange
            MathExecute me = new MathExecute();

            // Act
            var results = me.SubtractionFunction(15, 8);

            // Assert
            Assert.AreEqual(12, results);
        }
    }
}
