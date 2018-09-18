/*
 * Michael Lawson
 * Assignment 07
 * Due Date: 10/12/2017
 * IT3045C Section 001
 * Add two binary numbers in an array type format based off of what was given to us in class, and create a GUI around it to take in user input.
 * This partial class frmBinaryAddition contains the events of the form and its controls.
 * Resources: Bill's provided base code, my assignment 05 code.
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions Microsoft documentation on how to create my own exceptions.
 * https://stackoverflow.com/questions/1297231/convert-string-to-int-in-one-line-of-code-using-linq Convert string textbox array to integer array to do math.
 * https://stackoverflow.com/questions/1822811/int-array-to-string Convert integer array back to a string array to put back into a textbox.
 */
using Assignment05Fall2017;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05Fall2017_lawsonm6
{
    public partial class frmBinaryAddition : Form
    {
        public frmBinaryAddition()
        {
            InitializeComponent();
        }
        //Button event method
        private void btnRetrieveInput_Click(object sender, EventArgs e)
        {
            //convert first textbox to an integer array
            string[] inputStringOne = tbUserInputOne.Text.Split('\n', ' ');
            int i = 0;
            //ignore inputs that can't be converted to an integer
            int[] inputIntegerOne = (from s in inputStringOne where int.TryParse(s, out i) select i).ToArray();
            
            //convert second textbox to an integer array
            string[] inputStringTwo = tbUserInputTwo.Text.Split('\n', ' ');
            int j = 0;
            //ignore inputs that can't be converted to an integer
            int[] inputIntegerTwo = (from s in inputStringTwo where int.TryParse(s, out j) select j).ToArray();
            
            //if the input length isn't equal, tell the user and don't do the addition.
            if (inputIntegerOne.Length != inputIntegerTwo.Length)
            {
                string message = "Binary numbers are not equal in length, input lengths may be different or an input is not an integer. Please check your inputs.";
                string caption = "Error Detected in length";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            //if input length is equal, continue
            if (inputIntegerOne.Length == inputIntegerTwo.Length)
            {
                //int stop is to stop the program from running if the user gets an error message.
                int stop = 0;
                //loop through each array and detect if the input is anything other than a 0 or 1, and tell the user if the input is invalid.
                for (int ii = 0; ii < inputIntegerOne.Length; ii++)
                {
                    if (inputIntegerOne[ii] < 0 || inputIntegerOne[ii] > 1)
                    {
                        string messageRange = "Input is out of range, only 0's and 1's are accepted in a binary number.";
                        string captionRange = "Error Detected in input";
                        MessageBoxButtons buttonsRange = MessageBoxButtons.OK;
                        MessageBox.Show(messageRange, captionRange, buttonsRange);
                        stop++;
                        break;
                    }
                    if (inputIntegerTwo[ii] < 0 || inputIntegerTwo[ii] > 1)
                    {
                        string messageRange = "Input is out of range, only 0's and 1's are accepted in a binary number.";
                        string captionRange = "Error Detected in input";
                        MessageBoxButtons buttonsRange = MessageBoxButtons.OK;
                        MessageBox.Show(messageRange, captionRange, buttonsRange);
                        stop++;
                        break;
                    }
                }
                //if stop did not get incremented, do the addition.
                if (stop == 0)
                {
                    //Call the Binary method, add the two binary numbers, save result in resultInteger array.
                    int[] resultInteger = Binary.AddBinary(inputIntegerOne, inputIntegerTwo);
                    //return the result to its original string form in order to display the solution to the user.
                    string resultString = resultInteger.Aggregate(string.Empty, (s, l) => s + " " + l.ToString());
                    //Clear solution textbox every addition to avoid confusion.
                    tbResult.Clear();
                    //Send the result to the solution textbox.
                    tbResult.AppendText(resultString);
                }
            }
        }
        //placeholder
        private void tbUserInputOne_TextChanged(object sender, EventArgs e)
        {

        }
        //placeholder
        private void tbUserInputTwo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
