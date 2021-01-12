using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Method
    {
        public void Begin(double numberfirst, char sign, out double result, out double numbersecond)
        {            
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} number 2");
            double.TryParse(Console.ReadLine(), out numbersecond);            
            result = numberfirst + numbersecond;                   
        }
        public void Equal_0(double numberfirst, char sign, double numbersecond, double result)
        {
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = {result}");
        }
       
        public void Equal_1(double rezultend, char ex, double c, double result)
        {
            Console.Clear();
            Console.WriteLine($"{rezultend} ? {c} = {result}");            
        }

    }
}
