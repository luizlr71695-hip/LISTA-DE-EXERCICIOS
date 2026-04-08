Console.WriteLine("Digite a Nota da prova 01:");
double Nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite o peso da prova 01: ");
double peso1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a Nota da Prova 02:");
double Nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o peso da prova 02: ");
double peso2 = Convert.ToDouble(Console.ReadLine());

double mediaponderada = (Nota1 * peso1 + Nota2 * peso2) / peso1 + peso2;
Console.WriteLine("a média ponderada é: " + (mediaponderada));
Console.ReadLine();
