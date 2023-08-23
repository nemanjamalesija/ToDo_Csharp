using System.Reflection.Metadata.Ecma335;

class UserInputValidator
{
   
    public double ValidateOperandInput()
    {
        string UserInput;
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


   public char DefineOperation()

    {
        char operation;


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

        while (operation != 'a' && operation != 's' && operation != 'm' && operation != 'd');

        return operation;

    }


    public void RestartOrExit()
    {

        char result;

        Console.WriteLine("Press Y to restart, press N to exit.");


        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a single key without displaying it
            result = char.ToLower(keyInfo.KeyChar);


            if (result == 'y')
            {
              Calculator calculator = new();
              calculator.InitializeProgram();
            }

            if (result == 'n')
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please provide valid input: Y to restart, N to exit.");
            }
        }

        while (result != 'y' && result != 'n');

    }
}