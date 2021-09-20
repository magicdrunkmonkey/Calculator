using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring and initilize variables
            bool menuLoop = true;
            int num1, num2;
            double result;

            //Menu
            while(menuLoop)
            {
                Console.Clear();
                Console.WriteLine("Calculator");
                Console.WriteLine("-------------");
                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:\n");
                Console.WriteLine("\n1) Add");
                Console.WriteLine("\n2) Subtract");
                Console.WriteLine("\n3) Multiply");
                Console.WriteLine("\n4) Divide");
                Console.WriteLine("\n\n0) Quit Calculator");

                //Menu input
                Console.Write("\nChoose option and press [Enter]: ");
                int menuOption = Convert.ToInt32(Console.ReadLine());

                // Ask the user to type the first number.
                Console.WriteLine("Type a number, and then press Enter");
                num1 = Convert.ToInt32(Console.ReadLine());

                // Ask the user to type the second number.
                Console.WriteLine("Type another number, and then press Enter");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (menuOption)
                {
                    case 1: //Add
                        {
                            result = Add(num1, num2);
                            break;
                        }

                    case 2: //Subract
                        {
                            break;
                        }

                    case 3: //Multiply
                        {
                            break;
                        }

                    case 4: //Divide
                        {
                            break;
                        }

                    case 0: //Quit Calculator
                        {
                            menuLoop = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("The option is not in the selection.");

                            Console.WriteLine("\nPress any key to return to the menu ...");
                            Console.ReadKey();
                            break;
                        }
                }


            }

            
            private static int Add(int addNum1, int addNum2)
            {
                int addResult = addNum1 + addNum2;
                return addResult;
            }
            
        }
    }
}
