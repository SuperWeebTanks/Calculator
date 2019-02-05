using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator
{
    public class Calculator
    {
        public virtual double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }

        public virtual double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }

        public virtual double Multiply(double a, double b)
        {
            Accumulator = a * b; 
            return a * b;
        }

        public virtual double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp); 
            return Math.Pow(x, exp);
        }

        public virtual double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            double value = dividend / divisor;
            Accumulator = value; 
            return value;
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0; 
        }

    }

    public class OverloadedCalculator : Calculator
    {
        public virtual double Add(double addend)
        {
            return base.Add(addend, Accumulator); 
        }

        public virtual double Subtract(double subtract)
        {
            return base.Subtract(subtract, Accumulator); 
        }

        public virtual double Multiply(double multiplier)
        {
            return base.Multiply(multiplier, Accumulator); 
        }

        public virtual double Divide(double divisor)
        {
            return base.Divide(Accumulator, divisor); 
        }

        public virtual double Power(double exponent)
        {
            return base.Power(Accumulator, exponent); 
        }
    }
}
