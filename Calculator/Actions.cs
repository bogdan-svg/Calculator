using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            mt.BeginPL(sign, numberfirst, out double result,out double numbersecond);

            Console.Clear();
            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = \npress = for and \n or + , - , * , /  ");

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
                    

                    mt.PL(ex, ref result, ref rezultend,  out double c );
                   
                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = \npress = for and \n or + , - , * , / ");
                    sign = ex;
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                    else if (ex != '+' && ex != '-' && ex != '*' && ex != '/')
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("dadada");
                            Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
                            char.TryParse(Console.ReadLine(), out ex);
                            if (ex == '+' || ex == '-' || ex == '*' || ex == '/')
                            {
                                break;
                            }
                        }

                    }                        
                }
                else if (ex == '-')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");

                    mt.SB(ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '*')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");

                    mt.MUL(ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '/')
                {
                    mt.DIV(ex, ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No such sign");
                    Console.WriteLine("esc = exit or\n Press any key for continue");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"{numberfirst} {sign} {numbersecond} = \npress = for and \n or + , - , * , /  ");
                        char.TryParse(Console.ReadLine(), out ex);                        
                    }
                }
            }
        }
        public void subtraction(double numberfirst, char sign)
        {
           

            mt.BeginSB(sign, numberfirst, out double result, out double numbersecond);

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
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '-')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");

                    mt.SB(ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '*')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");

                    mt.MUL(ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '/')
                {

                    mt.DIV(ex, ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
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
            

            mt.BeginMUL(sign, numberfirst, out double result, out double numbersecond);
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");

                char.TryParse(Console.ReadLine(), out ex);
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
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '-')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");

                    mt.SB(ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '*')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");

                    mt.MUL(ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '/')
                {

                    mt.DIV(ex, ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
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
            mt.BeginDIV(sign, numberfirst, out double result, out double numbersecond);
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");

                char.TryParse(Console.ReadLine(), out ex);
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
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '-')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");

                    mt.SB(ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '*')
                {
                    Console.Clear();
                    Console.WriteLine($"{result} {ex} number");

                    mt.MUL(ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
                        break;
                    }
                }
                else if (ex == '/')
                {

                    mt.DIV(ex, ref result, ref rezultend, out double c);

                    Console.Clear();
                    Console.WriteLine($"{rezultend} {ex} {c} = and");
                    ex = Convert.ToChar(Console.ReadLine());

                    if (ex == '=')
                    {
                        mt.Equal_1(rezultend, sign, c, result);
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
    

