using CalculatorDll;
using System;
using Xunit;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void Summ5and10equal15()
        {
            Calculator calculator = new Calculator();
            calculator.Operation = OperationType.Summ;
            calculator.AddOperand(5);
            calculator.AddOperand(10);
            double result = calculator.Calculate();

            Assert.Equal(15, result);
        }

        [Fact]
        public void Divide5by10equal0dot5()
        {
            Calculator calculator = new Calculator();
            calculator.Operation = OperationType.Divide;
            calculator.AddOperand(5);
            calculator.AddOperand(10);
            double result = calculator.Calculate();

            Assert.Equal(0.5, result);
        }

        [Fact]
        public void DivideWithLostOperand()
        {
            Calculator calculator = new Calculator();
            calculator.Operation = OperationType.Divide;
            calculator.AddOperand(10);
            try
            {
                double result = calculator.Calculate();
            }
            catch (Exception e) {
                Assert.True(e is CalculateLostOperandException);
                return;
            }
            // гарантия провала
            Assert.True(false);
        }

        [Fact]
        public void TryCalculateTwoOperation()
        {
            Calculator calculator = new Calculator();
            calculator.Operation = OperationType.Summ;
            calculator.AddOperand(5);
            calculator.AddOperand(10);
            double result1 = calculator.Calculate();
            calculator.Operation = OperationType.Divide;
            calculator.AddOperand(5);
            calculator.AddOperand(10);
            double result2 = calculator.Calculate();

            Assert.Equal(15, result1);
            Assert.Equal(0.5, result2);
        }
    }
}
