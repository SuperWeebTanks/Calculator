﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public partial class CalculatorUnitTest
    {
        [TestCase(2,4, ExpectedResult = -2, TestName = "2-4 = -2")]
        [TestCase(0,-3, ExpectedResult = 3, TestName = "0-3 = 3")]
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

            Assert.That(uut.Power(3.0,-3.0),Is.EqualTo(0.037).Within(0.1));
        }

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

    public partial class CalculatorUnitTest
    {
       
    }
}
