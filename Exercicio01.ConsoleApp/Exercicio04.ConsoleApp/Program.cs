//Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário
//base e o total de vendas. A comissão é calculada com um percentual (informado pelo
// usuário) sobre o total de venda



Console.WriteLine("Informe o salario base (R$): ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe o total de vendas (R$):");
double total = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe o percentual de comissão :");
double percentual = Convert.ToDouble(Console.ReadLine());

percentual = total * (percentual / 100);

salario = salario + percentual;

Console.WriteLine($"o salario final é: {salario:f2} R$");




