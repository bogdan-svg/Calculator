using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Method
    {
        
<<<<<<< HEAD
        public void BeginPL(string input,char sign, double numberfirst, out double result,out double numbersecond)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{numberfirst} {sign} number 2");

                input = Console.ReadLine();
                bool rezultat = double.TryParse(input, out numbersecond);
                if (rezultat)
                {
                    result = numberfirst + numbersecond;
                    break;
                }
                else
                {                    
                    Console.Clear();
                    Console.WriteLine("Eba ty lox BeginPL");
                    Console.ReadKey();
                }
            }
        }
        public void BeginSB(string input,char sign, double numberfirst, out double result, out double numbersecond)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{numberfirst} {sign} number 2");

                input = Console.ReadLine();
                bool rezultat = double.TryParse(input, out numbersecond);
                if (rezultat)
                {
                    result = numberfirst - numbersecond;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Eba ty lox BeginSB");
                    Console.ReadKey();
                }
            }
        }
        public void BeginMUL(string input, char sign, double numberfirst, out double result, out double numbersecond)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{numberfirst} {sign} number 2");

                input = Console.ReadLine();
                bool rezultat = double.TryParse(input, out numbersecond);
                if (rezultat)
                {
                    result = numberfirst * numbersecond;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Eba ty lox BeginMUL");
                    Console.ReadKey();
                }
            }
        }
        public void BeginDIV(string input, char sign, double numberfirst, out double result, out double numbersecond)
        {
            while (true)
            {                
                Console.Clear();
                Console.WriteLine($"{numberfirst} {sign} number 2");
                input = Console.ReadLine();
                bool rezultat = double.TryParse(input, out numbersecond);
                if(rezultat)
                {
                    if (numbersecond == 0)
                    {
                        Console.WriteLine("can not div on zero");
                        Console.WriteLine("continue - press any key \nesc = exit");
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
                else
                {
                    Console.Clear();
                    Console.WriteLine("Eba ty lox BeginDIV");
                    Console.ReadKey();
                }
            }
        }

        
        public void PL(string input, char ex, ref double result, ref double rezultend, out double c)
        {
            while (true)
            {                
                Console.Clear();
                Console.WriteLine($"{result} {ex} number");
                input = Console.ReadLine();
                bool rezultat = double.TryParse(input, out c);
                if (rezultat)
                {
                    rezultend = result;
                    result += c;
                    break;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Eba ty lox PL");
                    Console.ReadKey();
                }
            }
=======
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
>>>>>>> parent of cc380a8 (dil na 01)
        }
        public void SB(string input, char ex, ref double result, ref double rezultend, out double c)
        {
<<<<<<< HEAD
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{result} {ex} number");
                input = Console.ReadLine();
                bool rezultat = double.TryParse(input, out c);
                if (rezultat)
                {
                    rezultend = result;
                    result -= c;
                    break;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Eba ty lox PL");
                    Console.ReadKey();
                }
            }                        
        }
        public void MUL(string input, char ex, ref double result, ref double rezultend, out double c)
=======
            
            c = Convert.ToDouble(Console.ReadLine());
            rezultend = result;
            result /= c;
           
        }
        public void Equal_0(double numberfirst, char sign, double numbersecond, double result)
>>>>>>> parent of cc380a8 (dil na 01)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{result} {ex} number");
                input = Console.ReadLine();
                bool rezultat = double.TryParse(input, out c);
                if (rezultat)
                {
                    rezultend = result;
                    result *= c;
                    break;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Eba ty lox PL");
                    Console.ReadKey();
                }
            }                                    
        }
        public void DIV(string input, char ex, ref double result, ref double rezultend, out double c)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{result} {ex} number");
                input = Console.ReadLine();
                bool rezultat = double.TryParse(input, out c);
                if (rezultat)
                {
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
                else
                {
                    Console.Clear();
                    Console.WriteLine("Eba ty lox PL");
                    Console.ReadKey();
                }
            }            
        }
        
    }
}
