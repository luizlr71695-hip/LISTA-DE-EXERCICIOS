Console.WriteLine("Digite o valor de A: ");
decimal a = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
decimal b = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor de C: ");
decimal c = Convert.ToDecimal(Console.ReadLine());

if (a + b < c)
{
    Console.WriteLine("A soma do valor A e B é menor que C.");
}

else
{
    Console.WriteLine("A soma do valor de A e B não é menor que C.");
}
