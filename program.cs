using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator\n");
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PerformOperation("Addition");
                        break;
                    case "2":
                        PerformOperation("Subtraction");
                        break;
                    case "3":
                        PerformOperation("Multiplication");
                        break;
                    case "4":
                        PerformOperation("Division");
                        break;
                    case "5":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using Console Calculator!");
        }

        static void PerformOperation(string operation)
        {
            Console.Write("Enter the first number: ");
            double num1 = GetValidNumber();
            
            Console.Write("Enter the second number: ");
            double num2 = GetValidNumber();
            
            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case "Addition":
                    result = num1 + num2;
                    break;
                case "Subtraction":
                    result = num1 - num2;
                    break;
                case "Multiplication":
                    result = num1 * num2;
                    break;
                case "Division":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"The result of {operation} is: {result}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static double GetValidNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
