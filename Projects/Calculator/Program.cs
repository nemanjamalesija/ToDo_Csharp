using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



public class Calculator
{
    private string UserInput { get; set; } = string.Empty;
    private double FirstOperand { get; set; }
    private double SecondOperand { get; set; }
    private char Operation { get; set; }
    private double Result { get; set; }

    readonly Operator Operator = new();



    public static void Main()
    {
        Calculator calculator = new Calculator();
        calculator.initializeProgram();


    }

        public void initializeProgram()
    {
        Console.WriteLine("Please enter first number.");
        FirstOperand = validateUserInput();

        Console.WriteLine("Please enter second number.");
        SecondOperand = validateUserInput();

        defineOperation();


        if (Operation == 'a')
        {
            Result = Operator.add(FirstOperand, SecondOperand);
        }

        if (Operation == 's')
        {
            Result = Operator.subtract(FirstOperand, SecondOperand);
        }

        if (Operation == 'm')
        {
            Result = Operator.multiply(FirstOperand, SecondOperand);
        }

        if (Operation == 'd')
        {
            Result = Operator.divide(FirstOperand, SecondOperand);
        }

        Console.WriteLine($"Result: {Result}");
        restartOrExit();
    }

    double validateUserInput()
    { 

        double intCompared;
        bool isDouble;

        do
        {
            UserInput = Console.ReadLine() ?? "";
            isDouble = double.TryParse(UserInput, out intCompared);

            if (!isDouble)
            {
                Console.WriteLine("Please provide valid input");
            }

        } while (!isDouble);



        return double.Parse(UserInput);
    }

    

    void defineOperation()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("[A]dd");
        Console.WriteLine("[S]ubtract");
        Console.WriteLine("[M]ultiple");
        Console.WriteLine("[D]ivide");

        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a single key without displaying it
            Operation = char.ToLower(keyInfo.KeyChar);

            if (Operation != 'a' && Operation != 's' && Operation != 'm' && Operation != 'd')
            {
                Console.WriteLine("Please provide a valid operation.");
            }
        }

        while (Operation != 'a' && Operation != 's' &&  Operation != 'm' && Operation != 'd');

    }


    void restartOrExit()
    {

        Console.WriteLine("Press Y to restart, press N to exit.");


        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a single key without displaying it
            Result = char.ToLower(keyInfo.KeyChar);


            if (Result == 'y')
            {
                initializeProgram();
            }

            if (Result == 'n')
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please provide valid input: Y to restart, N to exit.");
            }
        }

        while (Result != 'y' && Result != 'n');

    }
}
