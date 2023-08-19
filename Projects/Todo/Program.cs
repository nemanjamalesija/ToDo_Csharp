// See https://aka.ms/new-console-template for more information


public class TodoList
{
    List<string> stringList = new List<string>();

    public static void Main()
    {
        TodoList todoList = new TodoList();
        todoList.RunTodoApp();
    }

    public void RunTodoApp()
    {
        while (true) // Run indefinitely
        {
            Console.WriteLine("Hello, what would you want to do ?");
            Console.WriteLine("[S]ee all todos");
            Console.WriteLine("[A]dd todo");
            Console.WriteLine("[R]emove todo");
            Console.WriteLine("[E]xit");

            string userChoice = Console.ReadLine();

            if (userChoice == "S")
            {
                PrintTodos();
            }
            else if (userChoice == "A")
            {
                AddTodo();
            }
            else if (userChoice == "E")
            {
                break; // Exit the loop and end the application
            }
        }
    }

    void PrintTodos()
    {
        for (int i = 0; i < stringList.Count; i++)
        {
            Console.WriteLine(stringList[i]);
        }
    }

    void AddTodo()
    {
        Console.WriteLine("Enter the new todo:");
        string newTodo = Console.ReadLine();
        stringList.Add(newTodo);
        Console.WriteLine("Todo added");
    }
}






