using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Display
    {
        public void Equal_0(double numberfirst, double numbersecond, double result, char sign)
        {
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = {result}");
        }
        public void Equal_1(double rezultend, double c, double result, char sign)
        {
            Console.Clear();
            Console.WriteLine($"{rezultend} {sign} {c} = {result}");
        }
    }
}
