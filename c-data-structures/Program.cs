using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Lab: Data Structures - String Reversal Using Stacks

            Objective:
            - Reverse a string using a Stack data structure.
            */

            /*
            Step 1: Create the main program to take user input.
            */
            Console.WriteLine(Console.Out.NewLine + "Enter a string to reverse: ");
            string userInput = Console.ReadLine();

            //validate the input
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Invalid input. Please enter a valid string.");
                return;
            }

            //Call method to reverse string
            string reversedString = ReverseString(userInput);
            Console.WriteLine("Reversed string: " + reversedString);
        }
        /*
        Step 2: Method to reverse the string using a Stack
        - Return type: string
        - Parameter: string input
        */
        public static string ReverseString(string input)
        {
            // Step 3: Instantiate a Stack to store characters
            Stack<char> stack = new Stack<char>();

            // Step 4: Retrieve the characters from the Stack in reverse order
            foreach (char c in input)
            {
                stack.Push(c);
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }

        /*
        Step 5 (Extra Challenge): Validate that the input contains only letters
        */
        public static bool ValidateInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
