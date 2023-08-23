class TodoManager
{
    private List<string> TodoList = new();

    readonly UserInputManager InputManager = new();
    public void PrintTodos()
    {
        if (TodoList.Count == 0)
        {

            Console.WriteLine("You have no todos.");
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < TodoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {TodoList[i]}");
        }

        Console.WriteLine();
    }

   public void AddTodo(string todo)
    {

        if (todo == "")
        {
            Console.WriteLine("The todo input cannot be empty.");
            Console.WriteLine();
            string newTodo = InputManager.GetNewTodoInput(); ;
            AddTodo(newTodo);

        }

        if (TodoList.Contains(todo))
        {

            Console.WriteLine("This todo is already in your list of todos.");
            Console.WriteLine();
            string newTodo = InputManager.GetNewTodoInput();
            AddTodo(newTodo);

        }

        TodoList.Add(todo);
        Console.WriteLine("Todo added.");
        Console.WriteLine();
    }

    public void RemoveTodo(char todoIndex)
    {

        string removedTodo = "";

        bool successParse = int.TryParse(todoIndex.ToString(), out int number);

        if (!successParse)
        {

            Console.WriteLine("Not a number. Please provide valid input.");
            char newTodoIndex = InputManager.GetUserInput();
            RemoveTodo(newTodoIndex);
            return;
        }

        int parsedTodoIndexInput = int.Parse(todoIndex.ToString());

        if (parsedTodoIndexInput > TodoList.Count)
        {

            Console.WriteLine("That index does not exist. Please provide correct input.");
            char newTodoIndex = InputManager.GetUserInput();
            RemoveTodo(newTodoIndex);
        }


        for (var i = 0; i < TodoList.Count; i++)
        {
            if (i == parsedTodoIndexInput - 1)
            {
                removedTodo = TodoList[i];
                break;
            }

        }

        TodoList.RemoveAt(parsedTodoIndexInput - 1);
        Console.WriteLine("You have succesfully removed the todo: " + removedTodo);
        Console.WriteLine();

    }
}