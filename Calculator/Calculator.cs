using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }

        public double Add(double addend)
        {
            return addend + Accumulator; 
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }

        public double Subtract(double subtracter)
        {
            return Accumulator-subtracter; 
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b; 
            return a * b;
        }

        public double Multiply(double multipler)
        {
            return multipler * Accumulator; 
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp); 
            return Math.Pow(x, exp);
        }

        public double Power(double exponent)
        {
            return Math.Pow(Accumulator, exponent); 
        }


        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            double value = dividend / divisor;
            Accumulator = value; 
            return value;
        }

        public double Divide(double divisor)
        {
            return Divide(Accumulator, divisor); 
        }

        public double Accumulator{ get; private set; }

        public void Clear()
        {
            Accumulator = 0; 
        }

        public void foo() { }

    }

}
