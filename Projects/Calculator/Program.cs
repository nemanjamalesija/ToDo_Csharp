
public class Calculator
{
    private double FirstOperand;
    private double SecondOperand;
    private char Operation;
    private double Result;

    readonly Operator Operator = new();
    readonly UserInputValidator UserInputValidator = new();



    public static void Main()
    {
        Calculator calculator = new Calculator();
        calculator.InitializeProgram();


    }

        public void InitializeProgram()
    {
        Console.WriteLine("Please enter first number.");
        FirstOperand = UserInputValidator.ValidateOperandInput();

        Console.WriteLine("Please enter second number.");
        SecondOperand =  UserInputValidator.ValidateOperandInput();

        Operation = UserInputValidator.DefineOperation();


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
        UserInputValidator.RestartOrExit();
    }
}
