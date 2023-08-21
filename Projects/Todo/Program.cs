
using System;

public class TodoList
{
    readonly List<string> StringList = new(); 
    private char UserChoiceSARE {  get; set; }
    private char UserChoiceTODO { get; set; }

    public static void Main()
    {
        TodoList todoList = new();
        todoList.RunTodoApp();
    }

    public void RunTodoApp()
    {
        while (true) // Run indefinitely
        {
             Console.WriteLine("What would you want to do ?");
            
             AskUserForActionSARE();
            UserChoiceSARE = GetUserInput();

            if (!(ValidateUserChoiceSARE(UserChoiceSARE)))
            {

                Console.WriteLine("Please select correct input.");
                AskUserForActionSARE();
                UserChoiceSARE = GetUserInput();
            }

            if (UserChoiceSARE.ToString().ToUpper() == "S")
            {
                PrintTodos();
            }
              if (UserChoiceSARE.ToString().ToUpper() == "A")
            {
                Console.WriteLine("Enter the new todo:");
                string newTodo = GetNewTodo();
                AddTodo(newTodo);
            }

            if (UserChoiceSARE.ToString().ToUpper() == "R")
            {
                if (StringList.Count == 0)
                {

                    Console.WriteLine("You have no todos.");
                    RunTodoApp();
                    return;
                }

                Console.WriteLine("Select the index of todo you want to remove:");
                PrintTodos();
                UserChoiceTODO = GetUserInput();
                RemoveTodo(UserChoiceTODO);
            }

            if (UserChoiceTODO.ToString().ToUpper() == "E")
            {
                break; // Exit the loop and end the application
            }
        }
    }

   static char GetUserInput()
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey(true);
        return keyPressed.KeyChar;
    }

    void AskUserForActionSARE()
    {
   
        Console.WriteLine("[S]ee all todos");
        Console.WriteLine("[A]dd todo");
        Console.WriteLine("[R]emove todo");
        Console.WriteLine("[E]xit");
        Console.WriteLine();

    }

   static string GetNewTodo ()
    {
        string newTodo = Console.ReadLine() ?? "";
        return newTodo;
    }

     static bool ValidateUserChoiceSARE(char input)
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

    void PrintTodos()
    {
        if (StringList.Count == 0)
        {

            Console.WriteLine("You have no todos.");
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < StringList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {StringList[i]}");
        }

        Console.WriteLine();
    }

    void AddTodo(string todo)
    {
       
        if (todo == "")
        {
            Console.WriteLine("The todo input cannot be empty.");
            Console.WriteLine();
            string newTodo = GetNewTodo();
            AddTodo(newTodo);

        }

        if (StringList.Contains(todo)) {

            Console.WriteLine("This todo is already in your list of todos.");
            Console.WriteLine();
            string newTodo = GetNewTodo();
            AddTodo(newTodo);

        }

        StringList.Add(todo);
        Console.WriteLine("Todo added.");
        Console.WriteLine();
    }

    void RemoveTodo(char todoIndex)
    {
  
            string removedTodo = "";

            bool successParse = int.TryParse(todoIndex.ToString(), out int number);

            if (!(successParse))
            {

                Console.WriteLine("Not a number. Please provide valid input.");
                char newTodoIndex = GetUserInput();
                RemoveTodo(newTodoIndex);
                return;
            }

            int parsedTodoIndexInput = int.Parse(todoIndex.ToString());

            if (parsedTodoIndexInput > StringList.Count)
            {

                Console.WriteLine("That index does not exist. Please provide correct input.");
                char newTodoIndex = GetUserInput();
                RemoveTodo(newTodoIndex);
            }


            for (var i = 0; i < StringList.Count; i++)
            {
                if (i == parsedTodoIndexInput - 1)
                {
                    removedTodo = StringList[i];
                    break;
                }

            }

            StringList.RemoveAt(parsedTodoIndexInput - 1);
            Console.WriteLine("You have succesfully removed the todo: " + removedTodo);
            Console.WriteLine();

        }

    }




