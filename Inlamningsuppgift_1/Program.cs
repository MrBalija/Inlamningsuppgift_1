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

            double sumOne = 0;
            double sumTwo = 0;
            bool running = true;
            List<double> sumList = new List<double>();
            double[] sumArray = new double[] { };

            while (running)
            {
                Console.WriteLine("Please enter two optional operators ('+', '-', '*', '/') for your equation:");

                Console.Write("> Enter first operator:");
                string userInputFirstOperator = (Console.ReadLine());
                Console.Write("> Enter second operator:");
                string userInputSecondOperator = (Console.ReadLine());

                Console.WriteLine(); //For spacing
                Console.WriteLine("Please enter three optional terms for your operators:");

                Console.Write("> Enter first term: ");
                double userInputFirstTerm = Convert.ToDouble(Console.ReadLine());
                Console.Write("> Enter second term: ");
                double userInputSecondTerm = Convert.ToDouble(Console.ReadLine());
                Console.Write("> Enter third term: ");
                double userInputThirdTerm = Convert.ToDouble(Console.ReadLine());


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
                Console.WriteLine("> " + userInputFirstTerm + " " + userInputFirstOperator + " " + userInputSecondTerm + " " + userInputSecondOperator + " " + userInputThirdTerm + " = " + sumTwo);


                //CHECK if sum is less, more or equal to 100 and write it to the player
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
                    sumArray = sumList.ToArray(); //Turns the list (sumList) into an array (to my pre-defined sumArray)
                    double sum = sumArray.Sum(); //Sums up all elements in the array
                    
                    Console.WriteLine("Thank you for playing. The sum of all rounds is " + sum + ". Have a nice day, bye!");
                    
                    running = false; //Sets the while-loop to false = the program ends
                }
                Console.WriteLine(); //For spacing
            }
        }
    }
}
