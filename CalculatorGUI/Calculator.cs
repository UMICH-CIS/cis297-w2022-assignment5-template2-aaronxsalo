using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorGUI
{
    interface ICalculator
    {
        string RemoveWhite(string s);
        string ReverseString(string s);
        string QuotientRemainder(int n1, int n2);
        string LogTen(double n);
        string LogX(double n, double x);
        string MinMax(int n1, int n2);
        string Power(int n1, int n2);
        string Quadratic(double a, double b, double c);
        string SquareRoot(double n);
    }

    /// <summary>
    /// This class implements the calculator functionality for the application
    /// </summary>
    class Calculator : ICalculator
    {
        /// <summary>
        /// method that removes whitespace from input string
        /// </summary>
        /// <param name="s"></param>
        public string RemoveWhite(string s)
        {
            return s.Replace(" ", "");
        }

        /// <summary>
        /// method that reverses input string
        /// </summary>
        /// <param name="s"></param>
        public string ReverseString(string s)
        {
            char[] reverseArray = s.ToCharArray();
            Array.Reverse(reverseArray);
            return String.Concat(reverseArray);
        }

        /// <summary>
        /// method finds the quotient and remainder while dividing the inputs
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public string QuotientRemainder(int n1, int n2)
        {
            try
            {
                int quotient = n1 / n2;
                int remainder = 0;
                Math.DivRem(n1, n2, out remainder);
                return "Quotient: " + quotient + " Remainder: " + remainder;
            }
            catch(DivideByZeroException)
            {
                return "Error! Cannot divide by zero!";
            }
        }

        /// <summary>
        /// method finds log base 10 of the input
        /// </summary>
        /// <param name="n"></param>
        public string LogTen(double n)
        {
            return Math.Log10(n).ToString();
        }

        /// <summary>
        /// method finds the log base second input of the first input
        /// </summary>
        /// <param name="n"></param>
        /// <param name="x"></param>
        public string LogX(double n, double x)
        {
            return Math.Log(n, x).ToString();
        }

        /// <summary>
        /// method finds the min and max of the inputs
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public string MinMax(int n1, int n2)
        {
            return "Min: "+ Math.Min(n1, n2) + " Max: " + Math.Max(n1, n2);
        }

        /// <summary>
        /// method finds first input to the power of the second input
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public string Power(int n1, int n2)
        {
            return Math.Pow(n1, n2).ToString();
        }

        /// <summary>
        /// method uses Quadratic object to calculate quadratic equation with the three inputs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public string Quadratic(double a, double b, double c)
        {
            Quadratic quadratic = new Quadratic(a, b, c);
            return quadratic.Display();
        }

        /// <summary>
        /// method square root of the input
        /// </summary>
        /// <param name="n"></param>
        public string SquareRoot(double n)
        {
            return Math.Sqrt(n).ToString();
        }
    }
}
