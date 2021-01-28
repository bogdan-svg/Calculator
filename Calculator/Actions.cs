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

            cyc.Tree(numberfirst, numbersecond, result, input, sign);
        }

        public void division(double numberfirst, char sign, string input)
        {
            mt.BeginDIV(input, sign, numberfirst, out double result, out double numbersecond);

            cyc.Tree(numberfirst, numbersecond, result, input, sign);
        }
    }
}
    

