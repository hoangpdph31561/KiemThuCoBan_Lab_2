using KiemThuCoBan_Lab_2_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_2_Test
{
    [TestFixture]
    public class CalculatorTest
    {

        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }
        [TearDown]
        public void TearDown()
        {
            // Clean up resources or reset states as necessary
            _calculator = null; // Release the reference for garbage collection
        }
        #region Test add method
        [Test]
        public void Calculator_Add_ReturnsSumOfZeroNumber()
        {
            var result = _calculator.Add(0, 0);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfZeroOneNumber()
        {
            var result = _calculator.Add(0, 1);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfOneZeroNumber()
        {
            var result = _calculator.Add(1, 0);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfNegativeZeroNumber()
        {
            var result = _calculator.Add(-1, 0);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfZeroNegativeNumber()
        {
            var result = _calculator.Add(0, -1);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfNegativePositiveNumber()
        {
            var result = _calculator.Add(-1, 1);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Calculator_Add_ReturnsIntMaxValue()
        {
            var aiFirstNumber = int.MaxValue - 1;
            var aiSecondNumber = 1;
            var result = _calculator.Add(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }
        [Test]
        public void Calculator_Add_ReturnsIntMinValue()
        {
            var aiFirstNumber = int.MinValue + 1;
            var aiSecondNumber = -1;
            var result = _calculator.Add(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MinValue));
        }
        [Test]
        public void Calculator_Add_ReturnsValueWithMaxMinValue()
        {
            var aiFirstNumber = int.MaxValue;
            var aiSecondNumber = int.MinValue;
            var result = _calculator.Add(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(-1));
        }
        #endregion

        #region Test subtract method
        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfZeroNumber()
        {
            var result = _calculator.Subtract(0, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfZeroOneNumber()
        {
            var result = _calculator.Subtract(0, 1);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfOneZeroNumber()
        {
            var result = _calculator.Subtract(1, 0);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfNegativeZeroNumber()
        {
            var result = _calculator.Subtract(-1, 0);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfZeroNegativeNumber()
        {
            var result = _calculator.Subtract(0, -1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfNegativePositiveNumber()
        {
            var result = _calculator.Subtract(-1, 1);
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Calculator_Subtract_ReturnsIntMaxValue()
        {
            var aiFirstNumber = int.MaxValue;
            var aiSecondNumber = 0;
            var result = _calculator.Subtract(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void Calculator_Subtract_ReturnsIntMinValue()
        {
            var aiFirstNumber = int.MinValue;
            var aiSecondNumber = 0;
            var result = _calculator.Subtract(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MinValue));
        }

        [Test]
        public void Calculator_Subtract_ReturnsValueWithMaxMinValue()
        {
            var aiFirstNumber = int.MaxValue;
            var aiSecondNumber = int.MaxValue;
            var result = _calculator.Subtract(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(0));
        }
        #endregion

        #region Test multiply method
        [Test]
        public void Calculator_Multiply_ReturnsProductOfZeroNumbers()
        {
            var result = _calculator.Multiply(0, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Calculator_Multiply_ReturnsProductOfZeroAndOneNumber()
        {
            var result = _calculator.Multiply(0, 1);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Calculator_Multiply_ReturnsProductOfOneAndZeroNumber()
        {
            var result = _calculator.Multiply(1, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Calculator_Multiply_ReturnsProductOfNegativeAndZeroNumber()
        {
            var result = _calculator.Multiply(-1, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Calculator_Multiply_ReturnsProductOfZeroAndNegativeNumber()
        {
            var result = _calculator.Multiply(0, -1);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Calculator_Multiply_ReturnsProductOfNegativeAndPositiveNumber()
        {
            var result = _calculator.Multiply(-2, 3);
            Assert.That(result, Is.EqualTo(-6));
        }

        [Test]
        public void Calculator_Multiply_ReturnsProductOfPositiveAndNegativeNumber()
        {
            var result = _calculator.Multiply(2, -3);
            Assert.That(result, Is.EqualTo(-6));
        }

        [Test]
        public void Calculator_Multiply_ReturnsProductOfTwoPositiveNumbers()
        {
            var result = _calculator.Multiply(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Calculator_Multiply_ReturnsProductOfTwoNegativeNumbers()
        {
            var result = _calculator.Multiply(-2, -3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Calculator_Multiply_ReturnsMaxValue()
        {
            var aiFirstNumber = int.MaxValue;
            var aiSecondNumber = 1;
            var result = _calculator.Multiply(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }
        #endregion

        #region Test divide method
        [Test]
        public void Calculator_Divide_ReturnsQuotientOfTwoPositiveNumbers()
        {
            var result = _calculator.Divide(6, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Calculator_Divide_ReturnsQuotientOfPositiveAndNegativeNumber()
        {
            var result = _calculator.Divide(6, -3);
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Calculator_Divide_ReturnsQuotientOfNegativeAndPositiveNumber()
        {
            var result = _calculator.Divide(-6, 3);
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Calculator_Divide_ReturnsQuotientOfTwoNegativeNumbers()
        {
            var result = _calculator.Divide(-6, -3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Calculator_Divide_ReturnsQuotientWithRemainder()
        {
            var result = _calculator.Divide(7, 3);
            Assert.That(result, Is.EqualTo(2)); // Assuming integer division
        }

        [Test]
        public void Calculator_Divide_ReturnsQuotientWithZeroDenominator()
        {
            var ex = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Attempted to divide by zero."));
        }

        [Test]
        public void Calculator_Divide_ReturnsQuotientWithZeroNumerator()
        {
            var result = _calculator.Divide(0, 5);
            Assert.That(result, Is.EqualTo(0));
        }
        #endregion
    }
}
