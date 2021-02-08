using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Calculator
{
    class Actions
    {

        Method mt = new Method();
        Сycle cyc = new Сycle();

        public void plus(double numberfirst, char sign, string input)
        {
<<<<<<< HEAD
            mt.BeginPL(input, sign, numberfirst, out double result, out double numbersecond);
            
            cyc.Tree(numberfirst, numbersecond, result, input, sign);
        }

        public void subtraction(double numberfirst, char sign, string input)
        {
            mt.BeginSB(input, sign, numberfirst, out double result, out double numbersecond);

            cyc.Tree(numberfirst, numbersecond, result, input, sign);
        }

        public void multiplication(double numberfirst, char sign, string input)
        {
            mt.BeginMUL(input, sign, numberfirst, out double result, out double numbersecond);
=======
            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} number 2");

            mt.Begin(numberfirst, out double result, out double numbersecond);
            
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

                    mt.PL(ex, ref result, ref rezultend,  out double c );
                   
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and?");                    
                    ex = Convert.ToChar(Console.ReadLine()); // перевірити хуйня виходить подумати як замінити

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

                    mt.SB(ex, ref result, ref rezultend, out double c);

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

                    mt.MUL(ex, ref result, ref rezultend, out double c);

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

                    mt.DIV(ex, ref result, ref rezultend, out double c);

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
            mt.Begin(numberfirst, out double result, out double numbersecond);

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

                    mt.PL(ex, ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and?");
                    ex = Convert.ToChar(Console.ReadLine()); // перевірити хуйня виходить подумати як замінити

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

                    mt.SB(ex, ref result, ref rezultend, out double c);

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

                    mt.MUL(ex, ref result, ref rezultend, out double c);

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

                    mt.DIV(ex, ref result, ref rezultend, out double c);

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
        public void multiplication(double numberfirst, char sign)
        {
            mt.Begin(numberfirst, out double result, out double numbersecond);

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

                    mt.PL(ex, ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and?");
                    ex = Convert.ToChar(Console.ReadLine()); // перевірити хуйня виходить подумати як замінити

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

                    mt.SB(ex, ref result, ref rezultend, out double c);

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

                    mt.MUL(ex, ref result, ref rezultend, out double c);

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

                    mt.DIV(ex, ref result, ref rezultend, out double c);

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
        public void division(double numberfirst, char sign)
        {
            mt.Begin(numberfirst, out double result, out double numbersecond);

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

                    mt.PL(ex, ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and?");
                    ex = Convert.ToChar(Console.ReadLine()); // перевірити хуйня виходить подумати як замінити

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

                    mt.SB(ex, ref result, ref rezultend, out double c);

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

                    mt.MUL(ex, ref result, ref rezultend, out double c);

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
>>>>>>> parent of cc380a8 (dil na 01)

            cyc.Tree(numberfirst, numbersecond, result, input, sign);
        }

        public void division(double numberfirst, char sign, string input)
        {
            mt.BeginDIV(input, sign, numberfirst, out double result, out double numbersecond);

            cyc.Tree(numberfirst, numbersecond, result, input, sign);
        }
    }
}
    

