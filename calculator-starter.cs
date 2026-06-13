while (true)
{
    Console.Write("Enter first number (or 'exit' to quit): ");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit")
    {
        break;
    }
    double num1 = double.Parse(input);

    Console.Write("Enter second number: ");
    string input2 = Console.ReadLine();
    if (input2.ToLower() == "exit")
    {
        break;
    }
    double num2 = double.Parse(input2);

    Console.Write("Enter operation (+, -, *, /): ");
    string operation = Console.ReadLine();
    double result = 0;
    if (operation == "exit")
    {
        break;
    }
    else if (operation == "+")
    {
        result = num1 + num2;
    }
    else if (operation == "-")
    {
        result = num1 - num2;
    }
    else if (operation == "*")
    {
        result = num1 * num2;
    }
    else if (operation == "/")
    {
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            continue;
        }

        result = num1 / num2;
    }
    else
    {
        Console.WriteLine("Invalid operation!");
        continue;
    }
    Console.WriteLine("Result: " + result);
    Console.WriteLine("===========================================");
}