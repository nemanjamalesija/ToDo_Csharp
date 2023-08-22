
class UserInputManager 
{

    static string GetNewTodo()
    {
        string newTodo = Console.ReadLine() ?? "";
        return newTodo;
    }

    public bool ValidateUserChoiceSARE(char input)
    {
        string comp = input.ToString().ToUpper();

        switch (comp)
        {
            case "S":
            case "A":
            case "R":
            case "E":
                return true;

            default:
                return false;
        }

    }

    public char GetUserInput()
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey(true);
        return keyPressed.KeyChar;
    }

    public void AskUserForActionSARE()
    {

        Console.WriteLine("[S]ee all todos");
        Console.WriteLine("[A]dd todo");
        Console.WriteLine("[R]emove todo");
        Console.WriteLine("[E]xit");
        Console.WriteLine();

    }

}