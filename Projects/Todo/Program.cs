
using System;
/*
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


/*/


/*
Define a Dog class. Each Dog will have a name(string), breed (string), and weight (int) fields.

* This class will have two constructors:
- The first takes name, breed, and weight parameters (in this order).
- The second takes only the name and weight parameters (in this order). 
- In this case, the breed should be assigned the "mixed-breed" value.

* This class will expose a single public method called Describe, returning a string describing the dog.

* For a dog named Lucky, with the breed "german shepherd" and weight of 40, this method should return:
- "This dog is named Lucky, it's a german shepherd, and it weighs 40 kilograms, so it's a large dog."

*For a dog named Tina, with the breed "shar pei" and weight of 25, this method should return:
- "This dog is named Tina, it's a shar pei, and it weighs 25 kilograms, so it's a medium dog."

The rule for translating the dog's weight to the weight description is as follows:
- For dogs lighter than 5 kilos, it is "tiny".
- For dogs of a weight of 5 kilos but less than 30 kilos, it is "medium".
- For other dogs, it is "large".
 * */

var Larry = new Dog("Larry", "Sheppard", 25);
var Tina = new Dog("Tina", "shar-pei", 3);
var Sosomus = new Dog("Sosomus", 50);

Console.WriteLine(Tina.Describe());
Console.WriteLine(Larry.Describe());
Console.WriteLine(Sosomus.Describe());

public class Dog
{
    private string _name;
    private string _breed;
    private int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight) : this(name, "Mixed breed", weight) { }
 
    
    public string Describe()
    {
        string dogSize;

        if (_weight < 5) dogSize = "tiny";
        else if (_weight > 5 && _weight < 30) dogSize = "medium";
        else dogSize = "large";

        return $"Name of the dog is {_name}, its breed is {_breed}, it's weight is {_weight}. This is {dogSize} dog";
    }

}

