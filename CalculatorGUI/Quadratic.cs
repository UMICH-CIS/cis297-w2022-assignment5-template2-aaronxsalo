using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorGUI
{
    interface IQuadratic
    {
        string Display();
    }

    /// <summary>
    /// This class implements the quadratic equation for the application
    /// </summary>
    class Quadratic : IQuadratic
    {
        private double a;
        private double b;
        private double c;
        private double discriminant;
        private double x1;
        private double x2;
        private bool valid;

        /// <summary>
        /// Constructor for Quadratic class. Sets a, b, c, and valid bool.
        /// </summary>
        /// <param name="coA"></param>
        /// <param name="coB"></param>
        /// <param name="coC"></param>
        public Quadratic(double coA, double coB, double coC)
        {
            this.a = coA;
            this.b = coB;
            this.c = coC;
            this.valid = true;
        }

        /// <summary>
        /// Calculates the discriminant for the equation. Called in Display function.
        /// </summary>
        private void _CalcDiscriminant()
        {
            discriminant = Math.Pow(b, 2) - 4 * a * c;
        }

        /// <summary>
        /// Calculates the root(s) for the equation. Called in Display function.
        /// </summary>
        private void _CalcRoot()
        {
            if (discriminant == 0 && a != 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else if (discriminant > 0 && a != 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else
            {
                valid = false;
            }
        }

        /// <summary>
        /// Calls both calc functions and then displays the results as a modified string.
        /// </summary>
        public string Display()
        {
            _CalcDiscriminant();
            _CalcRoot();

            if (valid)
            {
                if (x1 == x2)
                {
                    return "Equation has one root: " + x1;
                }
                else
                {
                    return "Equation has two roots: " + x1 + " " + x2;
                }
            }
            else
            {
                return "Error! Equation has no real roots!";
            }
        }
    }
}
