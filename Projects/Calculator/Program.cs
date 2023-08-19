// See https://aka.ms/new-console-template for more information


public class Calculator
{
    string userInput = string.Empty;
    double firstOperand;
    double secondOperand;
    char operation;
    double result;
    char restart;

    public static void Main()
    {
        Calculator calculator = new Calculator();
        calculator.initializeProgram();

    }

    void initializeProgram()
    {
        Console.WriteLine("Please enter first number.");
        firstOperand = validateUserInput();

        Console.WriteLine("Please enter second number.");
        secondOperand = validateUserInput();

        defineOperation();


        if (operation == 'a')
        {
            result = add(firstOperand, secondOperand);
        }

        if (operation == 's')
        {

            result = subtract(firstOperand, secondOperand);
        }

        if (operation == 'm')
        {

            result = multiply(firstOperand, secondOperand);

        }

        if (operation == 'd')
        {

            result = divide(firstOperand, secondOperand);
        }


        Console.WriteLine($"Result: {result}");
        restartOrExit();

    }

    double validateUserInput()
    {
        double intCompared;
        userInput = Console.ReadLine();
        bool res = double.TryParse(userInput, out intCompared);
       

        {

            while (!res)
            {
                Console.WriteLine("Please provide a valid input.");
                userInput = Console.ReadLine();
                res = double.TryParse(userInput, out intCompared);

            }

          
            return double.Parse(userInput);
          

        }

    }

    void defineOperation()
    {

        Console.WriteLine("What would you like to do?");
        Console.WriteLine("[A]dd");
        Console.WriteLine("[S]ubtract");
        Console.WriteLine("[M]ultiple");
        Console.WriteLine("[D]ivide");


       
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // Read a single key without displaying it
            operation = char.ToLower(keyInfo.KeyChar);

      

            if (operation == 'a' || operation == 's' || operation == 'm' || operation == 'd')
            {
                break; // Exit the loop when a valid operation is entered
            }
            else
            {
                Console.WriteLine("Please provide a valid operation.");
            }
        }

    }

    // operations
    double add (double a, double b)
    {

        return a + b;
    }

    double subtract(double a, double b)
    {

        return a - b;
    }

    double multiply (double a, double b)
    {
        return a * b;
    }

    double divide (double a, double b)
    {

        if (a == 0 || b == 0)
        {
            Console.WriteLine("Cannot divide by 0.");
            initializeProgram();

        }

        return a / b;
    }


    void restartOrExit()
    {

        Console.WriteLine("Press Y to restart, press N to exit.");

        while (true)
           
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // Read a single key without displaying it
            restart = char.ToLower(keyInfo.KeyChar);

            if (restart == 'y')
            {
                
                initializeProgram();
            }

            if (restart == 'n')
            {

          
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please provide valid input: Y to restart, N to exit.");

            }

        }

    }
}
