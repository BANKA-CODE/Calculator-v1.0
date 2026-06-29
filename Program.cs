using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string Use = "Y";
            string prompt = "Enter your first number: ";
            string prompt2 = "Enter your second number: ";


            Console.WriteLine("Welcome to the Calculator program");

          bool valid =  UserChoice("choose your prefered program: ", out choice);
            bool life = true;
            while (life)
            {
                while (!valid || choice<=0 || choice >4)
                {
                    Console.WriteLine("Invalid option. Please try again ");
                    valid = UserChoice("choose your prefered program: ", out choice);
                }

                Console.WriteLine(prompt);
                
                if (!double.TryParse(Console.ReadLine(), out double input))
                {
                    Console.WriteLine("Invalid number entered. Restarting...");
                    continue;
                }

                Console.WriteLine(prompt2);
               if(!double.TryParse(Console.ReadLine(), out double input2))
                {
                    Console.WriteLine("Invalid number entered. Restarting...");
                    continue;
                }

                switch (choice)
                {
                    case 1:

                        Console.WriteLine($"Result: {Addition(input, input2)}"); 

                        break;
                    case 2:

                        Console.WriteLine($"Result: {Subtraction(input, input2)}"); 

                        break;
                    case 3:
                        Console.WriteLine($"Result: {Multiplication(input, input2)}"); 

                        break;
                    case 4:

                       double result= Divison(input, input2);

                        if (input2!=0)
                        {
                            Console.WriteLine($"Result: {result}");
                        }

                        break;

                    default:

                        Console.WriteLine("Invalid selection detected.....");
                        break;
                }

                Console.WriteLine("Do you wish to use the program again? ");
                Use = Console.ReadLine();

                if (Use.Trim().ToUpper()=="N")
                {
                 
                    break;

                }
                else
                {
                    valid = false;
                }
            }

            Console.WriteLine("BYe BYe! Press any key to exit....");
            
            Console.ReadKey();
        }

        static bool UserChoice(string Prompt, out int choice) 
        {
            int Tempchoice = 0;
            choice = 0;
            Console.Write(Prompt);

            Console.WriteLine("\n1.Addition " +
              "\n2.Subtraction" +
              "\n3.Multiplication" +
              "\n4.Division");

            if(int.TryParse(Console.ReadLine(), out Tempchoice) && Tempchoice>=1 && Tempchoice <=4)
            {
                choice = Tempchoice;
                return true;
            }

            return false;
        }

        static double Addition(double num1, double num2)
        {
            double sum = num1 + num2;

            return sum;   
        }


        static double Subtraction(double num1, double num2)
        {
            double difference = num1 - num2;

            return difference;
        }

        static double Multiplication(double num1, double num2)
        {
            double product = num1*num2;

            return product;
        }

        static double Divison(double num1, double num2)
        {
            double quotient = 0;


            if (num2==0)
            {

                Console.WriteLine("Cannot devide by zero");

            }
            else
            {
                quotient = num1 / num2;
            }

            return quotient;
        }

    } 
  
    }
