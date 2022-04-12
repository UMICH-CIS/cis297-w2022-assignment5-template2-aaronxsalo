using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
   public partial class CalculatorGUIForm : Form
   {
        private Calculator calculator;
        private bool thirdEnabled;
        public CalculatorGUIForm()
        {
            InitializeComponent();
            calculator = new Calculator();
            thirdEnabled = false;
            txtInput3.Visible = false;
        }

        private void btnWhitespace_Click(object sender, EventArgs e)
        {
            _ThirdEnabledSwitch();
            txtInput2.Text = ""; //clears second input because it is not used
            txtOutput.Text = calculator.RemoveWhite(txtInput1.Text);
            _ClearForm();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            _ThirdEnabledSwitch();
            txtInput2.Text = ""; //clears second input because it is not used
            txtOutput.Text = calculator.ReverseString(txtInput1.Text);
            _ClearForm();
        }

        private void btnQuotient_Click(object sender, EventArgs e)
        {
            _ThirdEnabledSwitch();
            try
            {
                txtOutput.Text = calculator.QuotientRemainder(Int32.Parse(txtInput1.Text), Int32.Parse(txtInput2.Text));
                _ClearForm();
            }
            catch (FormatException)
            {
                txtOutput.Text = "Error! Input must be two numbers!";
            }
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            _ThirdEnabledSwitch();
            try
            {
                txtInput2.Text = ""; //clears second input because it is not used
                txtOutput.Text = calculator.LogTen(double.Parse(txtInput1.Text));
                _ClearForm();
            }
            catch (FormatException)
            {
                txtOutput.Text = "Error! Input must be a number!";
            }
        }

        private void btnLogX_Click(object sender, EventArgs e)
        {
            _ThirdEnabledSwitch();
            try
            {
                txtOutput.Text = calculator.LogX(double.Parse(txtInput1.Text), double.Parse(txtInput2.Text));
                _ClearForm();
            }
            catch (FormatException)
            {
                txtOutput.Text = "Error! Input must be two numbers!";
            }
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            _ThirdEnabledSwitch();
            try
            {
                txtOutput.Text = calculator.MinMax(Int32.Parse(txtInput1.Text), Int32.Parse(txtInput2.Text));
                _ClearForm();
            }
            catch (FormatException)
            {
                txtOutput.Text = "Error! Input must be two numbers!";
            }
        }

        private void btnPowerX_Click(object sender, EventArgs e)
        {
            _ThirdEnabledSwitch();
            try
            {
                txtOutput.Text = calculator.Power(Int32.Parse(txtInput1.Text), Int32.Parse(txtInput2.Text));
                _ClearForm();
            }
            catch (FormatException)
            {
                txtOutput.Text = "Error! Input must be two numbers!";
            }
        }

        private void btnQuadratic_Click(object sender, EventArgs e)
        {
            if (!thirdEnabled)
            {
                txtInput3.Visible = true;
                thirdEnabled = true;
            }
            else
            {
                try
                {
                    txtOutput.Text = calculator.Quadratic(Double.Parse(txtInput1.Text), Double.Parse(txtInput2.Text), Double.Parse(txtInput3.Text));
                    _ClearForm();
                }
                catch (FormatException)
                {
                    txtOutput.Text = "Error! Input must be three numbers!";
                    txtInput3.Visible = false;
                    thirdEnabled = false;
                }
            }
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            _ThirdEnabledSwitch();
            try
            {
                txtInput2.Text = ""; //clears second input because it is not used
                txtOutput.Text = calculator.SquareRoot(Double.Parse(txtInput1.Text));
                _ClearForm();
            }
            catch (FormatException)
            {
                txtOutput.Text = "Error! Input must be a number!";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _ClearForm();
            txtOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ClearForm()
        {
            _ThirdEnabledSwitch();
            txtInput1.Text = "";
            txtInput2.Text = "";
            txtInput3.Text = "";
        }

        private void _ThirdEnabledSwitch()
        {
            if (thirdEnabled)
            {
                txtInput3.Visible = false;
                thirdEnabled = false;
            }
        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/