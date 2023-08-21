﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class Calculator
{
    private string UserInput { get; set; }
    private double FirstOperand { get; set; }
    private double SecondOperand { get; set; }
    private char Operation { get; set; }
    private double Result { get; set; }
    private char Restart { get; set; }


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
        bool isDouble;

        do
        {
            userInput = Console.ReadLine() ?? "";
            isDouble = double.TryParse(userInput, out intCompared);

            if (!isDouble)
            {
                Console.WriteLine("Please provide valid input");
            }

        } while (!isDouble);



        return double.Parse(userInput);
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
            operation = char.ToLower(keyInfo.KeyChar);

            if (operation != 'a' && operation != 's' && operation != 'm' && operation != 'd')
            {
                Console.WriteLine("Please provide a valid operation.");
            }
        }

        while (operation != 'a' && operation != 's' &&  operation != 'm' && operation != 'd');

    }

    // operations
    double add(double a, double b)
    {
        return a + b;
    }

    double subtract(double a, double b)
    {
        return a - b;
    }

    double multiply(double a, double b)
    {
        return a * b;
    }

    double divide(double a, double b)
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


        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a single key without displaying it
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

        while (restart != 'y' && restart != 'n');

    }
}
