/*
 * Michael Lawson
 * Assignment 07
 * Due Date: 10/12/2017
 * IT3045C Section 001
 * Add two binary numbers in an array type format based off of what was given to us in class, and create a GUI around it to take in user input.
 * This class StartForm is the entry point for the code that opens the form. It contains the main method.
 * Resources: Bill's provided base code, my assignment 05 code.
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions Microsoft documentation on how to create my own exceptions.
 * https://stackoverflow.com/questions/1297231/convert-string-to-int-in-one-line-of-code-using-linq Convert string textbox array to integer array to do math.
 * https://stackoverflow.com/questions/1822811/int-array-to-string Convert integer array back to a string array to put back into a textbox.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05Fall2017_lawsonm6
{
    class StartForm
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBinaryAddition());
        }
    }
}
