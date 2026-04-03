Console.WriteLine("informe a quilometragem inicial da veiculo: ");
double kminicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe a quilometragem final da veiculo: ");
double kmfinal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe a Quantidade de combustível consumida: ");
double combustível = Convert.ToDouble(Console.ReadLine());

double distancia = kmfinal - kminicial;
double consumo = combustível / distancia;

Console.WriteLine($"o consumo de combustível por quilômetro percorrido foi:{consumo:F2}");
Console.ReadLine();