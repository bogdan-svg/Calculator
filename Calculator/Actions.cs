using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Actions
    {
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        double result;
        double numbersecond;
        double rezultend;
        char sign;
        public void plus(double numberfirst, char sign)
        {            
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} number 2");
            numbersecond = Convert.ToDouble(Console.ReadLine());
            result = numberfirst + numbersecond;
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
            sign = Convert.ToChar(Console.ReadLine());
            while (true)
            {
                
                if (sign == '=')
                {
                    Console.Clear();
                    Console.WriteLine($"{numberfirst} {sign} {numbersecond} = {result}");
                    break;
                }
                else if (sign == '+')
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
                else if (sign == '-')
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
                        Console.WriteLine($"{rezultend} - {c} = {result}");
                        break;
                    }
                }
                else if (sign == '*')
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
                        Console.WriteLine($"{rezultend} * {c} = {result}");
                        break;
                    }
                }
                else if (sign == '/')
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
                        Console.WriteLine($"{rezultend} / {c} = {result}");
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
        public void subtraction(double numberfirst, char z)
        {            
            Console.Clear();
            Console.WriteLine($"{numberfirst} {z} number 2");
            numbersecond = Convert.ToDouble(Console.ReadLine());
            result = numberfirst - numbersecond;
            Console.Clear();
            Console.WriteLine($"{numberfirst} {z} {numbersecond} = and or + - * /");
            sign = Convert.ToChar(Console.ReadLine());


            while (true)
            {
                if (sign == '=')
                {
                    Console.Clear();
                    Console.WriteLine($"{numberfirst} {z} {numbersecond} = {result}");
                    break;
                }
                else if (sign == '+')
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
                else if (sign == '-')
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
                else if (sign == '*')
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
                else if (sign == '/')
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
        public void multiplication(double numberfirst, char z)
        {            
            Console.Clear();
            Console.WriteLine($"{numberfirst} {z} number 2");
            numbersecond = Convert.ToDouble(Console.ReadLine());
            result = numberfirst * numbersecond;
            Console.Clear();
            Console.WriteLine($"{numberfirst} {z} {numbersecond} = and or + - * /");
            sign = Convert.ToChar(Console.ReadLine());

            while (true)
            {
                if (sign == '=')
                {
                    Console.Clear();
                    Console.WriteLine($"{numberfirst} {z} {numbersecond} = {result}");
                    break;
                }
                else if (sign == '+')
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
                else if (sign == '-')
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
                else if (sign == '*')
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
                else if (sign == '/')
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
        public void division(double numberfirst, char z)
        {            
            Console.Clear();
            Console.WriteLine($"{numberfirst} {z} number 2");
            numbersecond = Convert.ToDouble(Console.ReadLine());
            result = numberfirst - numbersecond;
            Console.Clear();
            Console.WriteLine($"{numberfirst} {z} {numbersecond} = and or + - * /");
            sign = Convert.ToChar(Console.ReadLine());

            while (true)
            {
                if (sign == '=')
                {
                    Console.Clear();
                    Console.WriteLine($"{numberfirst} {z} {numbersecond} = {result}");
                    break;
                }
                else if (sign == '+')
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
                else if (sign == '-')
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
                else if (sign == '*')
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
                else if (sign == '/')
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
