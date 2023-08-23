class UserInputValidator
{
    private string UserInput { get; set; } = string.Empty;
    private double Result { get; set; }

    public double ValidateOperandInput()
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


   public void defineOperation(char operation)
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

        while (operation != 'a' && operation != 's' && operation != 'm' && operation != 'd');

    }


    void RestartOrExit()
    {

        Console.WriteLine("Press Y to restart, press N to exit.");


        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Read a single key without displaying it
            Result = char.ToLower(keyInfo.KeyChar);


            if (Result == 'y')
            {
              Calculator calculator = new();
              calculator.initializeProgram();
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