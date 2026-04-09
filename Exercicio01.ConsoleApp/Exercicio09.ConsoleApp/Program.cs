int A, fatorial = 1;

Console.WriteLine("Digite um valor para A:  ");
A = Convert.ToInt32(Console.ReadLine());

Console.Write(A + "! = ");

for (int i = A; i >= 1; i--)
{
    Console.Write(i + " ");
    fatorial *= i;

    if (i > 1)
    {
        Console.WriteLine("X ");
    }
}

Console.Write("= " + fatorial);

Console.ReadLine();