namespace CalculatorGUI
{
   partial class CalculatorGUIForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnQuadratic = new System.Windows.Forms.Button();
            this.btnPowerX = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnLogX = new System.Windows.Forms.Button();
            this.btnLog10 = new System.Windows.Forms.Button();
            this.btnQuotient = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnWhitespace = new System.Windows.Forms.Button();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(146, 386);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 50);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquareRoot.Location = new System.Drawing.Point(20, 386);
            this.btnSquareRoot.Margin = new System.Windows.Forms.Padding(0);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(126, 50);
            this.btnSquareRoot.TabIndex = 26;
            this.btnSquareRoot.Text = "Square Root";
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnQuadratic
            // 
            this.btnQuadratic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuadratic.Location = new System.Drawing.Point(146, 336);
            this.btnQuadratic.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuadratic.Name = "btnQuadratic";
            this.btnQuadratic.Size = new System.Drawing.Size(126, 50);
            this.btnQuadratic.TabIndex = 25;
            this.btnQuadratic.Text = "Quadratic";
            this.btnQuadratic.Click += new System.EventHandler(this.btnQuadratic_Click);
            // 
            // btnPowerX
            // 
            this.btnPowerX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPowerX.Location = new System.Drawing.Point(20, 336);
            this.btnPowerX.Margin = new System.Windows.Forms.Padding(0);
            this.btnPowerX.Name = "btnPowerX";
            this.btnPowerX.Size = new System.Drawing.Size(126, 50);
            this.btnPowerX.TabIndex = 24;
            this.btnPowerX.Text = "Power X";
            this.btnPowerX.Click += new System.EventHandler(this.btnPowerX_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinMax.Location = new System.Drawing.Point(146, 286);
            this.btnMinMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(126, 50);
            this.btnMinMax.TabIndex = 23;
            this.btnMinMax.Text = "Min/Max";
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnLogX
            // 
            this.btnLogX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogX.Location = new System.Drawing.Point(20, 286);
            this.btnLogX.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogX.Name = "btnLogX";
            this.btnLogX.Size = new System.Drawing.Size(126, 50);
            this.btnLogX.TabIndex = 22;
            this.btnLogX.Text = "Log Base X";
            this.btnLogX.Click += new System.EventHandler(this.btnLogX_Click);
            // 
            // btnLog10
            // 
            this.btnLog10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog10.Location = new System.Drawing.Point(146, 236);
            this.btnLog10.Margin = new System.Windows.Forms.Padding(0);
            this.btnLog10.Name = "btnLog10";
            this.btnLog10.Size = new System.Drawing.Size(126, 50);
            this.btnLog10.TabIndex = 21;
            this.btnLog10.Text = "Log Base 10";
            this.btnLog10.Click += new System.EventHandler(this.btnLog10_Click);
            // 
            // btnQuotient
            // 
            this.btnQuotient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuotient.Location = new System.Drawing.Point(20, 236);
            this.btnQuotient.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuotient.Name = "btnQuotient";
            this.btnQuotient.Size = new System.Drawing.Size(126, 50);
            this.btnQuotient.TabIndex = 20;
            this.btnQuotient.Text = "Quotient/Remainder";
            this.btnQuotient.Click += new System.EventHandler(this.btnQuotient_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReverse.Location = new System.Drawing.Point(146, 186);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(0);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(126, 50);
            this.btnReverse.TabIndex = 19;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnWhitespace
            // 
            this.btnWhitespace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWhitespace.Location = new System.Drawing.Point(20, 186);
            this.btnWhitespace.Margin = new System.Windows.Forms.Padding(0);
            this.btnWhitespace.Name = "btnWhitespace";
            this.btnWhitespace.Size = new System.Drawing.Size(126, 50);
            this.btnWhitespace.TabIndex = 18;
            this.btnWhitespace.Text = "Remove Whitespace";
            this.btnWhitespace.Click += new System.EventHandler(this.btnWhitespace_Click);
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(20, 4);
            this.txtInput1.Multiline = true;
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(252, 26);
            this.txtInput1.TabIndex = 17;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(20, 36);
            this.txtInput2.Multiline = true;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(252, 26);
            this.txtInput2.TabIndex = 28;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(20, 104);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(252, 79);
            this.txtOutput.TabIndex = 29;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(20, 436);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 50);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(20, 68);
            this.txtInput3.Multiline = true;
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(252, 26);
            this.txtInput3.TabIndex = 31;
            // 
            // CalculatorGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 503);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnQuadratic);
            this.Controls.Add(this.btnPowerX);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnLogX);
            this.Controls.Add(this.btnLog10);
            this.Controls.Add(this.btnQuotient);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnWhitespace);
            this.Controls.Add(this.txtInput1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CalculatorGUIForm";
            this.Text = "String/Math Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnSquareRoot;
      private System.Windows.Forms.Button btnQuadratic;
      private System.Windows.Forms.Button btnPowerX;
      private System.Windows.Forms.Button btnMinMax;
      private System.Windows.Forms.Button btnLogX;
      private System.Windows.Forms.Button btnLog10;
      private System.Windows.Forms.Button btnQuotient;
      private System.Windows.Forms.Button btnReverse;
      private System.Windows.Forms.Button btnWhitespace;
      private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInput3;
    }
}

