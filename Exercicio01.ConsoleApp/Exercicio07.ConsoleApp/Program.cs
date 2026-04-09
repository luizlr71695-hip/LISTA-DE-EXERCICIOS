Console.WriteLine("Digite seu peso em KG:");
decimal peso = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a sua altura em metros: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal imc = peso / (altura * altura);

Console.WriteLine("Seu imc é : " + imc);

if (imc < 18.5m)
{
    Console.WriteLine("Abaixo do peso");
}

else if (imc < 25)
{
    Console.WriteLine("Peso normal");
}

else if (imc < 30)
{
    Console.WriteLine("acima do peso");
}

else
{
    Console.WriteLine("obeso");
}



