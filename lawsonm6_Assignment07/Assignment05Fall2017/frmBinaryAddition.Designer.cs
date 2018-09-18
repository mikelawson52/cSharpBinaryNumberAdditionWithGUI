/*
 * Michael Lawson
 * Assignment 07
 * Due Date: 10/12/2017
 * IT3045C Section 001
 * Add two binary numbers in an array type format based off of what was given to us in class, and create a GUI around it to take in user input.
 * This class frmBinaryAddition contains all of the controls of the form.
 * Resources: Bill's provided base code, my assignment 05 code.
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions Microsoft documentation on how to create my own exceptions.
 * https://stackoverflow.com/questions/1297231/convert-string-to-int-in-one-line-of-code-using-linq Convert string textbox array to integer array to do math.
 * https://stackoverflow.com/questions/1822811/int-array-to-string Convert integer array back to a string array to put back into a textbox.
 */
namespace Assignment05Fall2017_lawsonm6
{
    partial class frmBinaryAddition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUserInputOne = new System.Windows.Forms.TextBox();
            this.btnStartAddition = new System.Windows.Forms.Button();
            this.tbUserInputTwo = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblSolution = new System.Windows.Forms.Label();
            this.lblFirstBinary = new System.Windows.Forms.Label();
            this.lblSecondBinary = new System.Windows.Forms.Label();
            this.lblExplaination = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUserInputOne
            // 
            this.tbUserInputOne.Location = new System.Drawing.Point(316, 192);
            this.tbUserInputOne.Multiline = true;
            this.tbUserInputOne.Name = "tbUserInputOne";
            this.tbUserInputOne.Size = new System.Drawing.Size(157, 211);
            this.tbUserInputOne.TabIndex = 0;
            this.tbUserInputOne.TextChanged += new System.EventHandler(this.tbUserInputOne_TextChanged);
            // 
            // btnStartAddition
            // 
            this.btnStartAddition.Location = new System.Drawing.Point(479, 218);
            this.btnStartAddition.Name = "btnStartAddition";
            this.btnStartAddition.Size = new System.Drawing.Size(85, 21);
            this.btnStartAddition.TabIndex = 1;
            this.btnStartAddition.Text = "Start Addition";
            this.btnStartAddition.UseVisualStyleBackColor = true;
            this.btnStartAddition.Click += new System.EventHandler(this.btnRetrieveInput_Click);
            // 
            // tbUserInputTwo
            // 
            this.tbUserInputTwo.Location = new System.Drawing.Point(570, 192);
            this.tbUserInputTwo.Multiline = true;
            this.tbUserInputTwo.Name = "tbUserInputTwo";
            this.tbUserInputTwo.Size = new System.Drawing.Size(145, 211);
            this.tbUserInputTwo.TabIndex = 2;
            this.tbUserInputTwo.TextChanged += new System.EventHandler(this.tbUserInputTwo_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(360, 447);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(328, 20);
            this.tbResult.TabIndex = 3;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(499, 422);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(45, 13);
            this.lblSolution.TabIndex = 4;
            this.lblSolution.Text = "Solution";
            // 
            // lblFirstBinary
            // 
            this.lblFirstBinary.AutoSize = true;
            this.lblFirstBinary.Location = new System.Drawing.Point(340, 176);
            this.lblFirstBinary.Name = "lblFirstBinary";
            this.lblFirstBinary.Size = new System.Drawing.Size(98, 13);
            this.lblFirstBinary.TabIndex = 5;
            this.lblFirstBinary.Text = "First Binary Number";
            // 
            // lblSecondBinary
            // 
            this.lblSecondBinary.AutoSize = true;
            this.lblSecondBinary.Location = new System.Drawing.Point(585, 176);
            this.lblSecondBinary.Name = "lblSecondBinary";
            this.lblSecondBinary.Size = new System.Drawing.Size(116, 13);
            this.lblSecondBinary.TabIndex = 6;
            this.lblSecondBinary.Text = "Second Binary Number";
            // 
            // lblExplaination
            // 
            this.lblExplaination.AutoSize = true;
            this.lblExplaination.Location = new System.Drawing.Point(243, 115);
            this.lblExplaination.Name = "lblExplaination";
            this.lblExplaination.Size = new System.Drawing.Size(592, 13);
            this.lblExplaination.TabIndex = 7;
            this.lblExplaination.Text = "Input integers in the text boxes below, containing only 1\'s and 0\'s.  Each number" +
    " must be seperated by spaces or enter keys.";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(438, 66);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(159, 13);
            this.lblIntro.TabIndex = 8;
            this.lblIntro.Text = "Binary Number Addition Program";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(318, 145);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(383, 13);
            this.lblStart.TabIndex = 9;
            this.lblStart.Text = "Hit \"Start Addition\" below to see the solution of adding your two binary numbers!" +
    "";
            // 
            // frmBinaryAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 492);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblExplaination);
            this.Controls.Add(this.lblSecondBinary);
            this.Controls.Add(this.lblFirstBinary);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbUserInputTwo);
            this.Controls.Add(this.btnStartAddition);
            this.Controls.Add(this.tbUserInputOne);
            this.Name = "frmBinaryAddition";
            this.Text = "Binary Addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Form controls

        private System.Windows.Forms.TextBox tbUserInputOne;
        private System.Windows.Forms.Button btnStartAddition;
        private System.Windows.Forms.TextBox tbUserInputTwo;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Label lblFirstBinary;
        private System.Windows.Forms.Label lblSecondBinary;
        private System.Windows.Forms.Label lblExplaination;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblStart;
    }
}