using System; //by faraaj and miaaf

class Calculator
{
    public static double Run(double num1, double num2, string op)
    {
        // 
        switch (op)
        {
            case "+": return num1 + num2;
            case "-": return num1 - num2;
            case "*": return num1 * num2;
            case "/":
                // != means not equal
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    return double.NaN;
                }
            default: return double.NaN;
        }
    }
}
class Program
{
    static void Main(string[] args)//miaf#6161
    {
        bool exit = false;
        Console.WriteLine("Calculator \r");
        Console.WriteLine("------------------------\n");

        while (!exit)
        {
            string num1 = "";
            string num2 = "";
            double result = 0;

            Console.Write("Enter a number: ");
            num1 = Console.ReadLine();

            double correctNum1 = 0;
            while (!double.TryParse(num1, out correctNum1))
            {
                Console.Write("This is not a valid number. Please enter an whole number.: ");
                num1 = Console.ReadLine();
            }

            Console.Write("Enter 2nd number: ");
            num2 = Console.ReadLine();

            double correctNum2 = 0;
            while (!double.TryParse(num2, out correctNum2))
            {
                Console.Write("This is not a valid number. Please enter an whole number.: ");
                num2 = Console.ReadLine();
            }

            // Choose a process
            Console.WriteLine("Please select a process from the list:");
            Console.WriteLine("\t+ - Plus");
            Console.WriteLine("\t- - Minus");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.Write("What is your choosen? ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.Run(correctNum2, correctNum1, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation caused a mathematical error.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while calculating the result! \n: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            Console.Write("Press the ESC button to close the program.. ");
            if (Console.ReadKey().Key == ConsoleKey.Escape) exit = true;

            Console.WriteLine("\n");
        }
        Console.WriteLine("The program was successfully closed. Please press any key.\n");
        Console.ReadKey();
    }
}
