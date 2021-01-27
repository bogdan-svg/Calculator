using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Calculator
{
    class Display
    {
        char ex;
        double rezultend;
        Method mt = new Method();
        bool a;
        public void Tree(double numberfirst, double numbersecond, double result,string input, char sign)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{numberfirst} {sign} {numbersecond} = \npress = for and \n or + , - , * , / ");

                input = Console.ReadLine();
                a = char.TryParse(input, out ex);
                if (a)
                {

                    if (ex == '=')
                    {
                        mt.Equal_0(numberfirst, numbersecond, result, sign);
                        break;
                    }
                    else
                    {
                        while (true)
                        {
                            if (ex == '+')
                            {
                                sign = ex;
                                mt.PL(input, ex, ref result, ref rezultend, out double c);

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{rezultend} {ex} {c} = \npress = for and \n or + , - , * , /");

                                    input = Console.ReadLine();
                                    a = char.TryParse(input, out ex);

                                    if (a)
                                    {
                                        if (ex == '=')
                                        {
                                            mt.Equal_1(rezultend, c, result, sign);
                                            break;
                                        }

                                        else if (ex != '+' && ex != '-' && ex != '*' && ex != '/')
                                        {
                                            while (true)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("No such sign");
                                                Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
                                                char.TryParse(Console.ReadLine(), out ex);
                                                if (ex == '+' || ex == '-' || ex == '*' || ex == '/')
                                                {
                                                    break;
                                                }
                                            }
                                        }

                                        else
                                            break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" esc = exit\n Press any key for continue");
                                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                                        {
                                            Process.GetCurrentProcess().Kill();
                                        }
                                    }
                                }
                            }
                            else if (ex == '-')
                            {
                                sign = ex;
                                mt.SB(input, ex, ref result, ref rezultend, out double c);

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{rezultend} {ex} {c} = \npress = for and \n or + , - , * , /");

                                    input = Console.ReadLine();
                                    a = char.TryParse(input, out ex);

                                    if (a)
                                    {
                                        if (ex == '=')
                                        {
                                            mt.Equal_1(rezultend, c, result, sign);
                                            break;
                                        }
                                        else if (ex != '+' && ex != '-' && ex != '*' && ex != '/')
                                        {
                                            while (true)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("No such sign");
                                                Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
                                                char.TryParse(Console.ReadLine(), out ex);
                                                if (ex == '+' || ex == '-' || ex == '*' || ex == '/')
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                            break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" esc = exit\n Press any key for continue");
                                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                                        {
                                            Process.GetCurrentProcess().Kill();
                                        }
                                    }
                                }
                            }
                            else if (ex == '*')
                            {
                                sign = ex;
                                mt.MUL(input, ex, ref result, ref rezultend, out double c);

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{rezultend} {ex} {c} = \npress = for and \n or + , - , * , /");

                                    input = Console.ReadLine();
                                    a = char.TryParse(input, out ex);

                                    if (a)
                                    {
                                        if (ex == '=')
                                        {
                                            mt.Equal_1(rezultend, c, result, sign);
                                            break;
                                        }
                                        else if (ex != '+' && ex != '-' && ex != '*' && ex != '/')
                                        {
                                            while (true)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("No such sign");
                                                Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
                                                char.TryParse(Console.ReadLine(), out ex);
                                                if (ex == '+' || ex == '-' || ex == '*' || ex == '/')
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                            break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" esc = exit\n Press any key for continue");
                                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                                        {
                                            Process.GetCurrentProcess().Kill();
                                        }
                                    }
                                }
                            }
                            else if (ex == '/')
                            {
                                sign = ex;
                                mt.DIV(input, ex, ref result, ref rezultend, out double c);

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"{rezultend} {ex} {c} = \npress = for and \n or + , - , * , /");

                                    input = Console.ReadLine();
                                    a = char.TryParse(input, out ex);

                                    if (a)
                                    {
                                        if (ex == '=')
                                        {
                                            mt.Equal_1(rezultend, c, result, sign);
                                            break;
                                        }
                                        else if (ex != '+' && ex != '-' && ex != '*' && ex != '/')
                                        {
                                            while (true)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("No such sign");
                                                Console.WriteLine($"{numberfirst} {sign} {numbersecond} = and or + - * /");
                                                char.TryParse(Console.ReadLine(), out ex);
                                                if (ex == '+' || ex == '-' || ex == '*' || ex == '/')
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                            break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" esc = exit\n Press any key for continue");
                                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                                        {
                                            Process.GetCurrentProcess().Kill();
                                        }
                                    }
                                }
                            }
                            else if (ex != '=' && ex != '+' && ex != '-' && ex != '*' && ex != '/')
                            {
                                Console.Clear();
                                Console.WriteLine("false");
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
                            else
                                break;
                        }


                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" esc = exit\n Press any key for continue");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
                break;
            }
        }

    }
}
