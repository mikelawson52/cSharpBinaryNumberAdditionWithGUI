/*
 * Michael Lawson
 * Assignment 07
 * Due Date: 10/12/2017
 * IT3045C Section 001
 * Add two binary numbers in an array type format based off of what was given to us in class, and create a GUI around it to take in user input.
 * This class Binary contains method AddBinary to run the logic of adding two binary numbers.
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

namespace Assignment05Fall2017
{
    class Binary
    {
        /// <summary>
        /// Add two binary numbers stored in int arrays: op1 + op2
        /// </summary>
        /// <param name="op1">Operand #1</param>
        /// <param name="op2">Operand #2</param>
        /// <returns>the sum of op1 and op2</returns>
        public static int[] AddBinary(int[] op1, int[] op2)
        {
            //start out by comparing array lengths.  If they are not equal, there is no reason to do tests on them.
            if (op1.Length != op2.Length)
            {
                //throws arrays are not equal exception
                throw new System.InvalidOperationException("Arrays must be equal in length");
            }
            //New array of integers that will be the result of the two arrays in the parameters of the AddBinary method.  Length of the arrays being compared.
            int[] result = new int[op1.Length];
            //Loop through the two arrays given, starting on the highest index because binary numbers are added right to left.
            for (int i = 1; i < op1.Length + 1; i++)
            {
                //if any number in the original two arrays are not 0 or 1, throw an exception of out of argument out of range.
                 if (op1[op1.Length - i] > 1  || op2[op2.Length - i] > 1 || op1[op1.Length - i] < 0 || op2[op2.Length - i] < 0)
                 {
                    //throws argument out of range error
                     throw new System.ArgumentOutOfRangeException("Array has a number that is invalid in it, argument out of range.");
                 }
                else
                {
                    //if the code makes it here, it will start at the highest index of the arrays, add the numbers located in that index together, and make it the answer in the corresponding index of result.
                result[result.Length - i] = op1[op1.Length - i] + op2[op2.Length - i] + result[result.Length - i];
                    //if the result is 2, make that index equal to 0 and add a 1 to the next index to have math performed on it.
                    if (result[result.Length - i] == 2)
                    {
                        //if the result of index 0 was >= 2, we know that the binary number would have to add another digit, which would overflow our array. 
                        if (result.Length - i - 1 < 0)
                        {
                            //Throws overflow exception.
                            //tells user the array's boundary has been reached.
                            string message = "Binary numbers added together have grown beyond the range of the array.";
                            string caption = "Error, overflow.";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(message, caption, buttons);
                            int[] escape = new int[1];
                            return escape;
                            // throw new System.OverflowException("Binary number has grown out of the range of the array.");
                        }
                        try
                        {
                            result[result.Length - i] = 0;
                            result[result.Length - i - 1] = 1;
                        }
                        catch { }
                    }
                    //if the result was 3, make that index equal to 1 and add a 1 to the next index to have math performed on it.
                    if (result[result.Length - i] == 3)
                    {
                        //if the result of index 0 was >= 2, we know that the binary number would have to add another digit, which would overflow our array. 
                        if (result.Length - i - 1 < 0)
                        {
                            //Throws overflow exception.
                            //Tells user the array's boundary has been reached.
                            string message = "Binary numbers added together have grown beyond the range of the array.";
                            string caption = "Error, overflow.";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(message, caption, buttons);
                            int[] escape = new int[1];
                            return escape;
                            //throw new System.OverflowException("Binary number has grown out of the range of the array.");
                        }
                        else
                        {
                            try
                            {
                                result[result.Length - i] = 1;
                                result[result.Length - i - 1] = 1;
                            }
                            catch { }
                        }
                    }
                }
            }
            //returns the result array as the solution.
            return result;
        }
    }
}
