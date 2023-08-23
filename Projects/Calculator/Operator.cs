
class Operator
{

   public double add(double a, double b)
    {
        return a + b;
    }

    public double subtract(double a, double b)
    {
        return a - b;
    }

    public double multiply(double a, double b)
    {
        return a * b;
    }

    public double divide(double a, double b)
    {

        if (a == 0 || b == 0)
        {
            Console.WriteLine("Cannot divide by 0.");
            Calculator calculator = new Calculator();
            calculator.initializeProgram();
        }

        return a / b;
    }


}