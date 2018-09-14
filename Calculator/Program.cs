/*  Title  :    Calculator
 *  Author :    nicolas.glassey@cpnv.ch
 *  Version:    06.09.2018 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        #region private attributes
        static private int userInputOperand01;
        static private int userInputOperand02;
        static private int displayAddResult;
        static private int displaySousResult;
        static private int displayMultResult;
        static private int displayDiviResult;
        #endregion private attributes

        /// <summary>
        /// This function is designed to be application's entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ask user to input 2 operands
            //tant que la variable userInputOperand01 n'est pas numérique recommencer
            Console.Write("First operand  : ");
            try
            {
                userInputOperand01 = int.Parse(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.Write("Error la valeur n'est pas numérique");
            }

            Console.Write("Second operand : ");
            userInputOperand02 = int.Parse(Console.ReadLine());

            //declare, init and use a "calculator" object
            Calculator calculator = new Calculator();
            displayAddResult = calculator.add(userInputOperand01, userInputOperand02);
            displaySousResult = calculator.sub(userInputOperand01, userInputOperand02);
            displayMultResult = calculator.mul(userInputOperand01, userInputOperand02);
            displayDiviResult = calculator.div(userInputOperand01, userInputOperand02);

            //display result
            Console.Write("Result of " + userInputOperand01 + " + " + userInputOperand02 + " = " + displayAddResult + "\n");
            Console.Write("Result of " + userInputOperand01 + " - " + userInputOperand02 + " = " + displaySousResult + "\n");
            Console.Write("Result of " + userInputOperand01 + " * " + userInputOperand02 + " = " + displayMultResult + "\n");
            Console.Write("Result of " + userInputOperand01 + " / " + userInputOperand02 + " = " + displayDiviResult + "\n");

            Console.ReadLine();
        }
    }
}
