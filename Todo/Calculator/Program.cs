// See https://aka.ms/new-console-template for more information


public class Calculator
{
    string userInput;
    string userInputOperation;
    int firstOperand;
    int secondOperand;
    string operation;
    int result;
    string restart;

    public static void Main()
    {
        Calculator calculator = new Calculator();
        calculator.initializeProgram();

    }

    void initializeProgram()
    {
        Console.WriteLine("Please enter first number");
        firstOperand = validateUserInput();


        if (firstOperand is int)
        {
            Console.WriteLine("Please enter second number");
            secondOperand = validateUserInput();

        }

        if (firstOperand is int && secondOperand is int)
        {

         operation = promptUserForOperation();

        }

        if (operation == "a")
        {
            result = add(firstOperand, secondOperand);
        }

        if (operation == "s")
        {

            result = subtract(firstOperand, secondOperand);
        }

        if (operation == "m")
        {

            result = multiply(firstOperand, secondOperand);

        }

        if (operation == "d")
        {

            result = divide(firstOperand, secondOperand);
        }


        Console.WriteLine("Result: " + result);
        restartOrExit();



        Console.ReadKey();

    }

    int validateUserInput()
    {
        int intCompared;
        userInput = Console.ReadLine();
        bool res = int.TryParse(userInput, out intCompared);
       

        {

            while (!res)
            {
                Console.WriteLine("Please provide a valid input");
                userInput = Console.ReadLine();
                res = int.TryParse(userInput, out intCompared);

            }

          
            return int.Parse(userInput);
          

        }

    }

    string promptUserForOperation()
    {

        Console.WriteLine("What would you like to do?");
        Console.WriteLine("[A]dd");
        Console.WriteLine("[S]ubtract");
        Console.WriteLine("[M]ultiple");
        Console.WriteLine("[D]ivide");


       
        while (true)
        {
            userInputOperation = Console.ReadLine().ToLower();

            if (userInputOperation == "a" || userInputOperation == "s" || userInputOperation == "m" || userInputOperation == "d")
            {
                break; // Exit the loop when a valid operation is entered
            }
            else
            {
                Console.WriteLine("Please provide a valid operation.");
            }
        }

       
        return userInputOperation;

    }

    // operations
    int add (int a, int b)
    {

        return a + b;
    }

    int subtract(int a, int b)
    {

        return a - b;
    }

    int multiply (int a, int b)
    {
        return a * b;
    }

    int divide (int a, int b)
    {

        if (a == 0 || b == 0)
        {
            Console.WriteLine("Cannot divide by 0");
            return -1;

        }

        return a / b;
    }


    void restartOrExit()
    {

        Console.WriteLine("Press Y to restart, press N to exit");

        while (true)
           
        {
            restart = Console.ReadLine().ToLower();

            if (restart == "y")
            {
                
                initializeProgram();
            }

            if (restart == "n")
            {

          
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please provide valid input: Y to restart, N to exit");

            }

        }

    }
}
