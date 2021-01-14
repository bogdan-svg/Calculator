using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Calculator
{
    class Method
    {
        
        public void BeginPL(double numberfirst, out double result, out double numbersecond)
        {           
            double.TryParse(Console.ReadLine(), out numbersecond);
            result = numberfirst + numbersecond;
        }
        public void BeginSB(double numberfirst, out double result, out double numbersecond)
        {
            double.TryParse(Console.ReadLine(), out numbersecond);
            result = numberfirst - numbersecond;
        }
        public void BeginMUL(double numberfirst, out double result, out double numbersecond)
        {
            double.TryParse(Console.ReadLine(), out numbersecond);
            result = numberfirst * numbersecond;
        }
        public void BeginDIV(char sign, double numberfirst, out double result, out double numbersecond)
        {
            while (true)
            {
                result = 0;
                Console.Clear();
                Console.WriteLine($"{numberfirst} {sign} number 2");
                double.TryParse(Console.ReadLine(), out numbersecond);
                if (numbersecond == 0)
                {
                    Console.WriteLine("dadada");
                    Console.WriteLine("continue ? esc = exit");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
                else
                {
                    result = numberfirst / numbersecond;
                    break;
                }
            }
        }


        public void PL(ref double result, ref double rezultend, out double c)
        {            
            c = Convert.ToDouble(Console.ReadLine());
            rezultend = result;
            result += c;            
        }
        public void SB(ref double result, ref double rezultend, out double c)
        {            
            c = Convert.ToDouble(Console.ReadLine());
            rezultend = result;
            result -= c;
        }
        public void MUL(ref double result, ref double rezultend, out double c)
        {           
            c = Convert.ToDouble(Console.ReadLine());
            rezultend = result;
            result *= c;            
        }
        public void DIV(char ex, ref double result, ref double rezultend, out double c)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{result} {ex} number");
                c = Convert.ToDouble(Console.ReadLine());

                if (c == 0)
                {
                    Console.WriteLine("dadada");
                    Console.WriteLine("continue ? esc = exit");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
                else
                {
                    rezultend = result;
                    result /= c;
                    break;
                }
            }
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
