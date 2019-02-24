using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the worst program!");

            Console.WriteLine("\t Want some quick mafs? Type 'yes'");


            while (true)
            {
                

                string input = Console.ReadLine();
                switch (input)
                {
                    case "yes":
                        Console.WriteLine("\t Gimme a number!");
                        string firstValue = Console.ReadLine();
                        int firstNumber = int.Parse(firstValue);

                        Console.WriteLine("\t Nice one, cupcake. Gimme another!");
                        string secondValue = Console.ReadLine();
                        int secondNumber = int.Parse(secondValue);

                        if(firstNumber == secondNumber)
                        {
                            int quickMafs = firstNumber * 2 * 3;
                            Console.WriteLine("\t I have a " + firstNumber + ", I have a " + secondNumber + " ... BOOM! --> " + quickMafs);
                            Console.WriteLine("\t Wait a minute...");
                        }
                        else
                        {
                            int realMafs = firstNumber + secondNumber;
                            Console.WriteLine("\t I have a " + firstNumber + ", I have a " + secondNumber + " ... BOOM! --> " + realMafs);
                            Console.WriteLine("\t Now that's quick mafs!");

                        }

                        Console.WriteLine("\t Want some more quick mafs? Type 'yes'");
                        break;


                    case "no":
                        Console.WriteLine("\t Fuck you, type 'yes'!");
                        break;

                    default:
                        Console.WriteLine("\t Gimme the right stuff, idiot-sandwich!");
                        break;

                }


            }


        }
    }
}
