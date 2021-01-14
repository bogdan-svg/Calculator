using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Method
    {
        
        public void Begin(double numberfirst, out double result, out double numbersecond)
        {           
            double.TryParse(Console.ReadLine(), out numbersecond);
            result = numberfirst + numbersecond;
        }
        public void PL(char ex, ref double result, ref double rezultend, out double c)
        {            
            c = Convert.ToDouble(Console.ReadLine());
            rezultend = result;
            result += c;            
        }
        public void SB(char ex, ref double result, ref double rezultend, out double c)
        {            
            c = Convert.ToDouble(Console.ReadLine());
            rezultend = result;
            result -= c;
        }
        public void MUL(char ex, ref double result, ref double rezultend, out double c)
        {           
            c = Convert.ToDouble(Console.ReadLine());
            rezultend = result;
            result *= c;            
        }
        public void DIV(char ex, ref double result, ref double rezultend, out double c)
        {
            
            c = Convert.ToDouble(Console.ReadLine());
            rezultend = result;
            result /= c;
           
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
