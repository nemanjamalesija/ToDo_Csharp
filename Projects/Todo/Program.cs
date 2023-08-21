
using System;

public class TodoList
{
    List<string> stringList = new List<string>(); 
    char userChoiceSARE; 
    char userChoiceTODO; 

    public static void Main()
    {
        TodoList todoList = new TodoList();
        todoList.RunTodoApp();
    }

    public void RunTodoApp()
    {
        while (true) // Run indefinitely
        {
             Console.WriteLine("What would you want to do ?");
            
             askUserForActionSARE();
             userChoiceSARE = getUserInput();

            if (!(validateUserChoiceSARE(userChoiceSARE)))
            {

                Console.WriteLine("Please select correct input.");
                askUserForActionSARE();
                userChoiceSARE = getUserInput();
            }

            if (userChoiceSARE.ToString().ToUpper() == "S")
            {
                PrintTodos();
            }
              if (userChoiceSARE.ToString().ToUpper() == "A")
            {
                Console.WriteLine("Enter the new todo:");
                string newTodo = getNewTodo();
                AddTodo(newTodo);
            }

            if (userChoiceSARE.ToString().ToUpper() == "R")
            {
               
                Console.WriteLine("Select the index of todo you want to remove:");
                PrintTodos();
                userChoiceTODO = getUserInput();
                removeTodo(userChoiceTODO);
            }

            if (userChoiceSARE.ToString().ToUpper() == "E")
            {
                break; // Exit the loop and end the application
            }
        }
    }

    char getUserInput()
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey(true);
        return keyPressed.KeyChar;
    }

    void askUserForActionSARE()
    {
   
        Console.WriteLine("[S]ee all todos");
        Console.WriteLine("[A]dd todo");
        Console.WriteLine("[R]emove todo");
        Console.WriteLine("[E]xit");
        Console.WriteLine();

    }

    string getNewTodo ()
    {
        string newTodo = Console.ReadLine() ?? "";
        return newTodo;
    }

    bool validateUserChoiceSARE(char input)
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
        if (stringList.Count == 0)
        {

            Console.WriteLine("You have no todos.");
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < stringList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {stringList[i]}");
        }

        Console.WriteLine();
    }

    void AddTodo(string todo)
    {
       
        if (todo == "")
        {
            Console.WriteLine("The todo input cannot be empty.");
            Console.WriteLine();
            string newTodo = getNewTodo();
            AddTodo(newTodo);

        }

        if (stringList.Contains(todo)) {

            Console.WriteLine("This todo is already in your list of todos.");
            Console.WriteLine();
            string newTodo = getNewTodo();
            AddTodo(newTodo);

        }

        stringList.Add(todo);
        Console.WriteLine("Todo added.");
        Console.WriteLine();
    }

   void removeTodo(char todoIndex)
    {
        string removedTodo = "";
   
        bool successParse = int.TryParse(todoIndex.ToString(), out int number);

        if (!(successParse))
        {

            Console.WriteLine("Not a number. Please provide valid input.");
            char newTodoIndex = getUserInput();
            removeTodo(newTodoIndex);
            return;
        }

         int parsedTodoIndexInput = int.Parse(todoIndex.ToString());
     
         if (parsedTodoIndexInput > stringList.Count) {

            Console.WriteLine("That index does not exist. Please provide correct input.");
            char newTodoIndex = getUserInput();
            removeTodo(newTodoIndex);
        }

        
        for (var i = 0; i < stringList.Count; i++)
        {
            if (i == parsedTodoIndexInput - 1)
            {
                removedTodo = stringList[i];
                break;
            }

        }

         stringList.RemoveAt(parsedTodoIndexInput - 1);
         Console.WriteLine("You have succesfully removed the todo: " + removedTodo);
         Console.WriteLine();

    }
}



