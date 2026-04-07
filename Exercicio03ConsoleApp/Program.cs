Console.WriteLine("Digite a temperatura que deseja ser convertida:");
double temperatura = Convert.ToDouble(Console.ReadLine());

double multiplicavel = 1.8;

double formula = 32;

double resultado = temperatura * multiplicavel + formula;

Console.WriteLine($"O resultado da conversão é : {resultado:f2}");





