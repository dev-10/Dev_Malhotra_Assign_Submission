using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Assignments
{
 
        enum Calculator : byte
        {
            Addition, Subtraction, Multiplication, Division, Square, SquareRoot
        }
        class Solution3
        {
            static void Main(string[] args)
            {
                Console.WriteLine("####################################################################################################");
                Console.WriteLine("                                         Calculator                                                   ");
                Console.WriteLine("####################################################################################################");
                Console.WriteLine();
                Console.WriteLine("                              Welcome to basic Maths Calculator                                       ");
                Console.WriteLine();

                int i = 1;
                while (i == 1)
                {

                    Console.WriteLine();

                    Console.WriteLine("Enter the operation you want to perform from below List: ");
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Array possibleValues = Enum.GetValues(typeof(Calculator));
                    for (int j = 0; j < possibleValues.Length; j++)
                    {
                        Console.WriteLine(possibleValues.GetValue(j));
                    }

                    string input = Console.ReadLine();
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><>");

                    Object operation = Enum.Parse(typeof(Calculator), input, true);
                    Calculator ans = (Calculator)operation;

                    Console.WriteLine();
                    Console.WriteLine("You Have Choosed for : " + ans);


                    double result;
                    string compare = ans.ToString();


                    if (compare == "Addition")
                    {
                        Console.Write("        Enter First Number: ");
                        var a = int.Parse(Console.ReadLine());
                        Console.Write("        Enter Second Number: ");
                        var b = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                  
                        result = a + b;
                        Console.WriteLine("Sum of the number is: " + result);
                    }
                    else if (compare == "Subtraction")
                    {
                        Console.Write("        Enter First Number: ");
                        var a = int.Parse(Console.ReadLine());
                        Console.Write("        Enter Second Number: ");
                        var b = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    
                        result = b - a;
                        Console.WriteLine("Difference of the number is: " + result);
                    }
                    else if (compare == "Multiplication")
                    {
                        Console.Write("        Enter First Number: ");
                        var a = int.Parse(Console.ReadLine());
                        Console.Write("        Enter Second Number: ");
                        var b = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                     
                        result = a * b;
                        Console.WriteLine("Product of the number is: " + result);
                    }
                    else if (compare == "Division")
                    {
                        Console.Write("        Enter First Number: ");
                        var a = int.Parse(Console.ReadLine());
                        Console.Write("        Enter Second Number: ");
                        var b = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                      
                        result = a / b;
                        Console.WriteLine("Division of the number is: " + result);

                    }
                    else if (compare == "Square")
                    {
                        Console.Write("Enter the number: ");
                        Console.WriteLine();
                        var c = int.Parse(Console.ReadLine());
                        result = c * c;
                        Console.WriteLine("Square of the number is: " + result);

                    }
                    else if (compare == "SquareRoot")
                    {
                        Console.Write("Enter the  number: ");
                        Console.WriteLine();
                        double c = double.Parse(Console.ReadLine());
                        result = Math.Sqrt(c);
                        Console.WriteLine("SquareRoot of the number is: " + result);

                    }

                    else
                    {
                        Console.WriteLine("Please enter valid operation");
                    }

                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to perform another Operation or Exit: Press 1 to continue or any other key to exit:");
                    i = int.Parse(Console.ReadLine());
                    Console.Clear();

                }
            }

            }
        }
    
