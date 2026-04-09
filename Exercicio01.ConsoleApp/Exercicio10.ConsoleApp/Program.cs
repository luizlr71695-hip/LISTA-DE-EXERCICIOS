for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz ");
    }
    else if (i % 3 == 0)
    {
        Console.Write("fizz ");
    }
    else if (i % 5 == 0)
    {
        Console.Write("buzz ");
    }
    else
    {
        Console.Write(Convert.ToString(i) + " ");
    }
}