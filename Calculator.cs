using System; //by faraaj and miaaf (and quamozos)

class Calculator
{
    public static double Run(double num1, double num2, string op)
    {
        switch (op)
        {
            case "+": return num1 + num2;
            case "-": return num1 - num2;
            case "*": return num1 * num2;
            case "/":
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
            Console.WriteLine("Enter your problem(ex: A + B)");
            var karma = Console.ReadLine();
            if (karma.IndexOf(' ') == -1) ThrowExceptionToConsole("Wrong format!");
            var arr = karma.Split(' ');
            if (arr.Length != 3) ThrowExceptionToConsole("Wrong format!");
            double num1 = 0, num2 = 0, result = 0;
            string op;
            double.TryParse(arr[0], out num1);
            double.TryParse(arr[2], out num2);
            op = arr[1];
            if (num1 == 0 || num2 == 0 || (op != "+" && op != "-" && op != "*" && op != "/"))
                ThrowExceptionToConsole("Please write true arguments.");
            result = Calculator.Run(num1, num2, op);
            try
            {
                result = Calculator.Run(num1, num2, op);
                if (double.IsNaN((double)result)) Console.WriteLine("This operation caused a mathematical error.\n");
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while calculating the result! \n: " + e.Message);
            }
            
            //what the fuck is this code?
            /*string num1 = "";
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
            }*/

            Console.WriteLine("------------------------\n");

            Console.Write("Press any key to continue or ESC to close program... ");
            if (Console.ReadKey().Key == ConsoleKey.Escape) exit = true;

            Console.WriteLine();
        }
        Console.WriteLine("The program was successfully closed. Please press any key.\n");
        Console.ReadKey();
    }

    static void ThrowExceptionToConsole(string message)
    {
        Console.WriteLine(message);
        Console.ReadKey();
        return;
    }
}
