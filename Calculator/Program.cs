using System;
using System.Diagnostics;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions ac = new Actions(); 
            double numberfirst;
            char sign;

            

            while (true)
            {
                Console.WriteLine("number");
                if (double.TryParse(Console.ReadLine(), out numberfirst))
                {                    
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{numberfirst} sign");
                        if (char.TryParse(Console.ReadLine(), out sign))
                        {
                            if (sign == '+')
                            {
                                ac.plus(numberfirst, sign);
                                Console.WriteLine("exit? esc");
                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    Process.GetCurrentProcess().Kill();
                                }
                                else
                                {
                                    Console.Clear();
                                    break;
                                }                                
                            }
                            else if (sign == '-')
                            {
                                ac.subtraction(numberfirst, sign);
                                Console.WriteLine("exit? esc");
                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    Process.GetCurrentProcess().Kill();
                                }
                                else
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (sign == '*')
                            {
                                //ac.multiplication(numberfirst, sign);
                                Console.WriteLine("exit? esc");
                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    Process.GetCurrentProcess().Kill();
                                }
                                else
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (sign == '/')
                            {
                                //ac.division(numberfirst, sign);
                                Console.WriteLine("exit? esc");
                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    Process.GetCurrentProcess().Kill();
                                }
                                else
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("nemae takogo znaky");
                                Console.WriteLine("exit? esc");
                                if (Console.ReadKey().Key == ConsoleKey.Escape)
                                {
                                    Process.GetCurrentProcess().Kill();
                                }
                                else
                                    Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("exit? esc");
                            if (Console.ReadKey().Key == ConsoleKey.Escape)
                            {
                                Process.GetCurrentProcess().Kill();
                            }
                            else
                                Console.Clear();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("exit? esc");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                        Console.Clear();
                }
            }


        }
    }
}
