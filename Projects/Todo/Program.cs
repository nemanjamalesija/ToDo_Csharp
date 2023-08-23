public class TodoList
    {
        readonly List<string> StringList = new();
        private char UserChoiceSARE { get; set; }
        private char UserChoiceTODO { get; set; }


        readonly UserInputManager InputManager = new();
        readonly TodoManager TodoManager = new();

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

                InputManager.AskUserForActionSARE();
                UserChoiceSARE = InputManager.GetUserInput();

                if (!InputManager.ValidateUserChoiceSARE(UserChoiceSARE))

                {

                Console.WriteLine("Please select correct input.");
                InputManager.AskUserForActionSARE();
                UserChoiceSARE = InputManager.GetUserInput();
                }

                if (UserChoiceSARE.ToString().ToUpper() == "S")
                {
                    TodoManager.PrintTodos();
                }
                if (UserChoiceSARE.ToString().ToUpper() == "A")
                {
                    Console.WriteLine("Enter the new todo:");
                    string newTodo = InputManager.GetNewTodoInput();
                    TodoManager.AddTodo(newTodo);
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
                   TodoManager.PrintTodos();
                   UserChoiceTODO = InputManager.GetUserInput();
                   TodoManager.RemoveTodo(UserChoiceTODO);
                }

                if (UserChoiceTODO.ToString().ToUpper() == "E")
                {
                    break; // Exit the loop and end the application
                }
            }
        }
   }
