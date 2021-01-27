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
            string input = null;
            

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
                                ac.plus(numberfirst, sign, input);
                                Console.WriteLine("Press esc for exit \nor any key for continue Program.cs");
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
                                ac.subtraction(numberfirst, sign, input);
                                Console.WriteLine("Press esc for exit \nor any key for continue Program.cs");
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
                                ac.multiplication(numberfirst, sign, input);
                                Console.WriteLine("Press esc for exit \nor any key for continue Program.cs");
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
                                ac.division(numberfirst, sign,input);
                                Console.WriteLine("Press esc for exit \nor any key for continue Program.cs");
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
                                Console.Clear();
                                Console.WriteLine("No such sign");
                                Console.WriteLine("esc = exit\n Press any key for continue");
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
                            Console.WriteLine("  esc = exit\n Press any key for continue ");
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
                    Console.WriteLine("Press esc for exit \nor any key for continue Program.cs");
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
