using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlamningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Welcome to the Math-operator";

            string userInputFirstOperator;
            string userInputSecondOperator;

            string userInputFirstTermString;
            double userInputFirstTerm;
            string userInputSecondTermString;
            double userInputSecondTerm;
            string userInputThirdTermString;
            double userInputThirdTerm;

            double sumOne = 0;
            double sumTwo = 0;

            bool running = true;

            List<double> sumList = new List<double>();
            double[] sumArray;

            while (running)
            {
                
                Console.WriteLine("Please enter two optional operators ('+', '-', '*', '/') for your equation:");
                
                //OPERATOR: if first input-operator doesn't match any of the optional operators, loop the question.
                do
                {
                    Console.Write("> Enter first operator:");
                    userInputFirstOperator = (Console.ReadLine());
                } while (userInputFirstOperator != "+" && userInputFirstOperator != "-" && userInputFirstOperator != "*" && userInputFirstOperator != "/");

                //OPERATOR: if second input-operator doesn't match any of the optional operators, loop the question.
                do
                {
                Console.Write("> Enter second operator:");
                userInputSecondOperator = (Console.ReadLine());
                } while (userInputSecondOperator != "+" && userInputSecondOperator != "-" && userInputSecondOperator != "*" && userInputSecondOperator != "/");
                
                Console.WriteLine(); //For spacing


                //FIRST term: checks for number inputs only.
                Console.WriteLine("Please enter three optional terms for your operators:");
                do
                {
                    Console.Write("> Enter first term: ");
                userInputFirstTermString = Console.ReadLine();
                } while (!double.TryParse(userInputFirstTermString, out userInputFirstTerm));

                //SECOND term: checks for number inputs only.
                do
                {
                    Console.Write("> Enter second term: ");
                    userInputSecondTermString = Console.ReadLine();
                } while (!double.TryParse(userInputSecondTermString, out userInputSecondTerm));

                //THIRD term: checks for number inputs only.
                do
                {
                    Console.Write("> Enter third term: ");
                    userInputThirdTermString = Console.ReadLine();
                } while (!double.TryParse(userInputThirdTermString, out userInputThirdTerm));


                //DO EQUATION: check which argument is true (first operator), and calculate the equation using first and second term.
                if (userInputFirstOperator == "+")
                {
                    sumOne = userInputFirstTerm + userInputSecondTerm;
                }
                else if (userInputFirstOperator == "-")
                {
                    sumOne = userInputFirstTerm - userInputSecondTerm;
                }
                else if (userInputFirstOperator == "*")
                {
                    sumOne = userInputFirstTerm * userInputSecondTerm;
                }
                else if (userInputFirstOperator == "/")
                {
                    sumOne = userInputFirstTerm / userInputSecondTerm;
                }

                //DO EQUATION: check which argument is true (second operator), and calculate the equation using the sum from above and third term.
                if (userInputSecondOperator == "+")
                {
                    sumTwo = sumOne + userInputThirdTerm;
                    sumList.Add(sumTwo);
                }
                else if (userInputSecondOperator == "-")
                {
                    sumTwo = sumOne - userInputThirdTerm;
                    sumList.Add(sumTwo);
                }
                else if (userInputSecondOperator == "*")
                {
                    sumTwo = sumOne * userInputThirdTerm;
                    sumList.Add(sumTwo);
                }
                else if (userInputSecondOperator == "/")
                {
                    sumTwo = sumOne / userInputThirdTerm;
                    sumList.Add(sumTwo);
                }
                
                Console.WriteLine(); //For spacing
                
                //Presents the player with the full equation and sum.
                Console.WriteLine("> " + userInputFirstTerm + " " + userInputFirstOperator + " " + userInputSecondTerm + " " + userInputSecondOperator + " " + userInputThirdTerm + " = " + sumTwo);

                //CHECK if sum is less, more or equal to 100 and write it to the player.
                if (sumTwo < 100)
                {
                    Console.WriteLine("> The sum is less than a hundred");
                }
                else if (sumTwo == 100)
                {
                    Console.WriteLine("> Cool, now you have a hundred, *clap-clap*");
                }
                if (sumTwo > 100)
                {
                    Console.WriteLine("> The sum is more than a hundred");
                }

                //ASK the player if she/he wants to go for another try
                Console.WriteLine("Another try ('Y' = yes and 'N' = no)?");
                string anotherTryNo = Console.ReadLine().ToUpper();
                Console.WriteLine(); //For spacing

                if (anotherTryNo == "N")
                {
                    sumArray = sumList.ToArray(); //Turns the list (sumList) into an array (using the already declared sumArray).
                    double sum = sumArray.Sum(); //Sums all elements in the array.
                    
                    Console.WriteLine("Thank you for playing. The sum of all rounds is " + sum + ". Have a nice day, bye!");
                    
                    running = false; //Sets the while-loop to false = the program ends.
                }
                Console.WriteLine(); //For spacing
            }
        }
    }
}
