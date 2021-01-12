using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Actions
    {
                
        double rezultend;
        char ex;

        Method mt = new Method();

        public void plus(double numberfirst, char sign)
        {
            mt.Begin(numberfirst, sign, out double result, out double numbersecond);
            
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");

            char.TryParse(Console.ReadLine(), out ex);
            while (true)
            {                
                if (ex == '=')
                {
                    mt.Equal_0(numberfirst, sign, numbersecond, result);
                    break;
                }
                else if (ex == '+')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result += c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and?");
                    ex = Convert.ToChar(Console.ReadLine());// перевірити хуйня виходить подумати як замінити
                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, ex, c, result);
                        break;
                    }
                }
                else if (ex == '-')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result -= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());
                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, ex, c, result);
                        break;
                    }
                }
                else if (ex == '*')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result *= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());
                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, ex, c, result);
                        break;
                    }
                }
                else if (ex == '/')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result /= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());
                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, ex, c, result);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("lox");
                    Console.ReadKey();
                }
            }
        }
        public void subtraction(double numberfirst, char sign)
        {
            mt.Begin(numberfirst, sign, out double result, out double numbersecond);
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
            char.TryParse(Console.ReadLine(), out ex);


            while (true)
            {
                if (ex == '=')
                {
                    mt.Equal_0(numberfirst, sign, numbersecond, result);
                    break;
                }
                else if (ex == '+')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result += c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '-')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result -= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '*')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result *= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '/')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result /= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("lox");
                    Console.ReadKey();
                }
            }
        }
        public void multiplication(double numberfirst, char sign)
        {
            mt.Begin(numberfirst, sign, out double result, out double numbersecond);
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
            char.TryParse(Console.ReadLine(), out ex);

            while (true)
            {
                if (ex == '=')
                {
                    Console.Clear();
                    Console.WriteLine($"{numberfirst} {sign} {numbersecond} = {result}");
                    break;
                }
                else if (ex == '+')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result += c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '-')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result -= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '*')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result *= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '/')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result /= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("lox");
                    Console.ReadKey();
                }
            }
        }
        public void division(double numberfirst, char sign)
        {
            mt.Begin(numberfirst, sign, out double result, out double numbersecond);
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
            char.TryParse(Console.ReadLine(), out ex);

            while (true)
            {
                if (ex == '=')
                {
                    Console.Clear();
                    Console.WriteLine($"{numberfirst} {sign} {numbersecond} = {result}");
                    break;
                }
                else if (ex == '+')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result += c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '-')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result -= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '*')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result *= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else if (ex == '/')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {sign} number");
                    double c = Convert.ToDouble(Console.ReadLine());
                    rezultend = result;
                    result /= c;
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {sign} {c} = and");
                    sign = Convert.ToChar(Console.ReadLine());
                    if (sign == '=')
                    {
                        Console.Clear();
                        Console.WriteLine($"{rezultend} + {c} = {result}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("lox");
                    Console.ReadKey();
                }
            }
        }
    }
}
    

