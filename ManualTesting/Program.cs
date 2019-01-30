using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ManualTestProgram
    {
        static void Main(string[] args)
        {
            var uut = new Calculator();

            //Add
            //Console.WriteLine("Add({0}, {1}) = {2}", 2.0, 4.0, uut.Add(2.0,4.0));
            Console.WriteLine("Add({0}, {1}) = {2}", 0.0, -3.0, uut.Add(0.0,-3.0));
            Console.WriteLine("Add({0}, {1}) = {2}", -5.0, -7.0, uut.Add(-5.0, -7.0));

            //Subtract
            Console.WriteLine("Subtract({0}, {1}) = {2}", 2.0, 4.0, uut.Subtract(2.0, 4.0));
            Console.WriteLine("Subtract({0}, {1}) = {2}", 0.0, -3.0, uut.Subtract(0.0, -3.0));
            Console.WriteLine("Subtract({0}, {1}) = {2}", -5.0, -7.0, uut.Subtract(-5.0, -7.0));

            //Multiply
            Console.WriteLine("Multiply({0}, {1}) = {2}", 2.0, 4.0, uut.Multiply(2.0, 4.0));
            Console.WriteLine("Multiply({0}, {1}) = {2}", 0.0, -3.0, uut.Multiply(0.0, -3.0));
            Console.WriteLine("Multiply({0}, {1}) = {2}", -5.0, -7.0, uut.Multiply(-5.0, -7.0));

            //Power
            Console.WriteLine("Power({0}, {1}) = {2}", 2.0, 4.0, uut.Power(2.0, 4.0));
            Console.WriteLine("Power({0}, {1}) = {2}", 10.0, 0.0, uut.Power(10.0, 0.0));
            Console.WriteLine("Power({0}, {1}) = {2}", 3.0, -3.0, uut.Power(3.0, -3.0));
        }
    }
}
