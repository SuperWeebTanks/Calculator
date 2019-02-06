using System;
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
        [Test]
        public void Add_Add2And4Returns6()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(2.0, 4.0), Is.EqualTo(6.0));
        }

        [Test]
        public void Add_Add0AndMin3ReturnsMin3()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(0.0, -3.0), Is.EqualTo(-3.0));
        }

        [Test]
        public void Add_AddMin5AndMin7ReturnsMin12()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(-5.0, -7.0), Is.EqualTo(-12.0));
        }

        [Test]
        public void Subtract_Subtract2And4ReturnsMin2()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(2.0, 4.0), Is.EqualTo(-2.0));
        }


        [Test]
        public void Subtract_Subtract0AndMin3ReturnsMin3()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(0.0, -3.0), Is.EqualTo(3.0));
        }

        [Test]
        public void Subtract_SubtractMin5AndMin7Returns2()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(-5.0, -7.0), Is.EqualTo(2.0));
        }

        [Test]
        public void Multiply_Multiply2And4Returns8()
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(2.0, 4.0), Is.EqualTo(8.0));
        }

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

            Assert.That(uut.Power(3.0,-3.0),Is.EqualTo(0.11).Within(0.1));
        }

        //[TestCase(3,-3, ExpectedResult = , TestName = "3^(-3)=0.037")]
        [TestCase(2,4, ExpectedResult = 16, TestName = "2^4=16")]
        [TestCase(10,0, ExpectedResult = 1, TestName = "10^0=1")]
        public double Power_PowerIntegerandInteger_Correct(int a, int b)
        {
            var uut = new Calculator();

            return uut.Power(a, b);
        }

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

        [TestCase(10)]
        public void AddOverload_Correct(int a)
        {

            Assert.That();
        }
    }

    

}
