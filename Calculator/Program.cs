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
        static private char userInputOperateur;
        static private int displayOPResult;
        static private int i;


        #endregion private attributes
        Log Log = new Log();
        /// <summary>
        /// This function is designed to be application's entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ask user to input 2 operands
            //tant que la variable userInputOperand01 n'est pas numérique recommencer
            do
            {
                Console.Write("First operand  : ");
                try
                {
                    i = 0;
                    userInputOperand01 = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException ex)
                {
                    i = 1;
                    Console.Write("Error la valeur n'est pas numérique\n");
                    Log.Logger(ex.ToString());
                }
            } while (i == 1);

            do
            {
                Console.Write("Second operand  : ");
                try
                {
                    i = 0;
                    userInputOperand02 = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException ex)
                {
                    i = 1;
                    Console.Write("Error la valeur n'est pas numérique\n");
                    Log.Logger(ex.ToString());
                }
            } while (i == 1);
            do
            {
                do
                {
                    Console.Write("Choisir operateur : ");
                    try
                    {
                        i = 0;
                        userInputOperateur = char.Parse(Console.ReadLine());
                    }
                    catch (System.FormatException ex)
                    {
                        i = 1;
                        Console.Write("Il faut choisir +, -, * ou /\n");
                        Log.Logger(ex.ToString());
                    }
                } while (i == 1);
                Calculator calculator = new Calculator();

                try
                {
                    displayOPResult = calculator.Ope(userInputOperand01, userInputOperand02, userInputOperateur);
                    i = 0;
                }
                catch (System.FormatException ex)
                {
                    i = 1;
                    Console.Write("Il faut choisir +, -, * ou /\n");
                    Log.Logger(ex.ToString());
                }
            } while (i == 1);
            //declare, init and use a "calculator" object

            //display result
            Console.Write("Result of " + userInputOperand01 + " " + userInputOperateur + " " + userInputOperand02 + " = " + displayOPResult + "\n");
            
            Console.ReadLine();
        }
    }
}
