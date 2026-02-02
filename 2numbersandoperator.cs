using System;

class Program
{
    static void Main()
    {

        double num1, num2;
        char op;

        Console.Write("Enter first number: ");
     
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        if (op == '+')
        {
            Console.WriteLine("Result = " + (num1 + num2));
        }
        else if (op == '-')
        {
            Console.WriteLine("Result = " + (num1 - num2));
        }
        else if (op == '*')
        {
            Console.WriteLine("Result = " + (num1 * num2));
        }
        else if (op == '/')
        {
            if (num2 != 0)
            {
                Console.WriteLine("Result = " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
        }
        else
        {
            Console.WriteLine("Invalid Operator");
        }
        Console.ReadLine();
    }

}
