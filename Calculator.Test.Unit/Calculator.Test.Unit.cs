using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public partial class CalculatorUnitTest
    {
        [TestCase(2,4, ExpectedResult = -2, TestName = "2-4 = -2")]
        [TestCase(0,-3, ExpectedResult = 3, TestName = "0-(-3) = 3")]
        [TestCase(-5,-7, ExpectedResult = 2, TestName = "-5-(-7) = 2")]
        public double Subtract_SubtractIntegerandInteger_Correct(int a, int b)
        {
            var uut = new Calculator();

            return uut.Subtract(a, b);
        }

        [TestCase(2,4, ExpectedResult = 8, TestName = "2*4 = 8")]
        [TestCase(0,-3, ExpectedResult = 0, TestName = "0*(-3) = 0")]
        [TestCase(5,7, ExpectedResult = 35, TestName = "5*7 = 35")]
        public double Multiply_MultiplyIntegerandInteger_Correct(int a, int b)
        {
            var uut = new Calculator();

            return uut.Multiply(a, b);
        }

        [Test]
        public void Power_Power3AndMin3Returns0point1()
        {
            var uut = new Calculator();

            Assert.That(uut.Power(3.0,-3.0),Is.EqualTo(0.037).Within(0.01));
        }
        
        [TestCase(100,1,ExpectedResult = 100, TestName = "100^1=100")]
        [TestCase(2,4, ExpectedResult = 16, TestName = "2^4=16")]
        [TestCase(10,0, ExpectedResult = 1, TestName = "10^0=1")]
        public double Power_PowerIntegerandInteger_Correct(int a, int b)
        {
            var uut = new Calculator();

            return uut.Power(a, b);
        }

        [TestCase(2,4, ExpectedResult = 6, TestName = "2+4=6")]
        [TestCase(0,-3, ExpectedResult = -3, TestName = "0+(-3)=-3")]
        [TestCase(-5,-7, ExpectedResult = -12, TestName = "-5+(-7)=-12")]
        [TestCase(2, 3, ExpectedResult = 5, TestName = "2+3=5")]
        [TestCase(34,72,ExpectedResult = 106, TestName = "34+72=86")]
        [TestCase(92, 150, ExpectedResult = 242, TestName = "92+150=231")]
        [TestCase(20, 30, ExpectedResult = 50, TestName = "20+30=50")]
        [TestCase(20,35,ExpectedResult = 55, TestName = "20 + 35 = 55")]
        [TestCase(-20, 20, ExpectedResult = 0, TestName = "-20 + 20 = 0")]
        public double Add_AddIntegerandInteger_Correct(int a, int b)
        {
            var uut = new Calculator();

            return uut.Add(a, b); 
        }

    }

    [TestFixture]
    public partial class CalculatorUnitTest //Overloaded
    {
        private Calculator uut; 
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
            uut.Clear(); //Clear accomulator 
        }

        [Test]
        public void DivideOverloaded_DivedeByZero_CatchDivideByZeroException()
        {
            uut.Clear();
            Assert.That(() => uut.Divide(0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(32, ExpectedResult = 0, TestName = "32 Divided by 0 = 0, Accumulator = 0")]
        [TestCase(44, ExpectedResult = 0, TestName = "44 diveded by 0 = 0, Accumulator = 0")]
        public double Divide_DivideWholeNumbers_ExpectWholeNumber(double a)
        {
            uut.Clear();
            return uut.Divide(a); 
        }

        [Test]
        public void DivideOverloaded_Divide32point5with22point32_Result1point456()
        {
            uut.Add(35.5, 0); //Set accumulator = 0
            Assert.That(uut.Divide(22.32), Is.EqualTo(1.59).Within(0.1));
        }

        [Test]
        public void PowerOverloaded_Exponent4pint4andAccumulator2point1_Result()
        {
            uut.Add(2.1, 0); 
            Assert.That(uut.Power(4.4), Is.EqualTo(26.167).Within(0.1));
        }

        [TestCase(2, ExpectedResult = 4, TestName = "2 To the power of 2 = 4, Accumulator = 2")]
        [TestCase(8, ExpectedResult = 256, TestName = "2 To the power of 8 = 256, Accumulator = 2")]
        public double Power_WholeNumberToThePowerOfWholeNumber_ExpectWholeNumber(double a)
        {
            uut.Add(2, 0);
            return uut.Power(a); 
        }

        [Test]
        public void PowerOverloaded_0ToThePowerOf0_Result0()
        {
            uut.Clear();
            Assert.That(uut.Power(0), Is.EqualTo(1).Within(0.0001));
        }
        
    }
}
