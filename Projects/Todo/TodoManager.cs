class TodoManager
{
    private List<string> todoList = new();

    readonly UserInputManager InputManager = new();
    void PrintTodos()
    {
        if (todoList.Count == 0)
        {

            Console.WriteLine("You have no todos.");
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i]}");
        }

        Console.WriteLine();
    }

    void AddTodo(string todo)
    {

        if (todo == "")
        {
            Console.WriteLine("The todo input cannot be empty.");
            Console.WriteLine();
            string newTodo = InputManager.GetNewTodoInput(); ;
            AddTodo(newTodo);

        }

        if (todoList.Contains(todo))
        {

            Console.WriteLine("This todo is already in your list of todos.");
            Console.WriteLine();
            string newTodo = InputManager.GetNewTodoInput();
            AddTodo(newTodo);

        }

        todoList.Add(todo);
        Console.WriteLine("Todo added.");
        Console.WriteLine();
    }

    void RemoveTodo(char todoIndex)
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

        if (parsedTodoIndexInput > todoList.Count)
        {

            Console.WriteLine("That index does not exist. Please provide correct input.");
            char newTodoIndex = InputManager.GetUserInput();
            RemoveTodo(newTodoIndex);
        }


        for (var i = 0; i < todoList.Count; i++)
        {
            if (i == parsedTodoIndexInput - 1)
            {
                removedTodo = todoList[i];
                break;
            }

        }

        todoList.RemoveAt(parsedTodoIndexInput - 1);
        Console.WriteLine("You have succesfully removed the todo: " + removedTodo);
        Console.WriteLine();

    }


}