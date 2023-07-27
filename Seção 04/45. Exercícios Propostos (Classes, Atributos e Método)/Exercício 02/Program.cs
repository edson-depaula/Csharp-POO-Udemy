using Exercício_02;
using System.Globalization;

/*
Fazer um programa para ler os dados de um funcionário (nome, 
salário bruto e imposto). Em seguida, mostrar os dados do 
funcionário (nome e salário líquido). Em seguida, aumentar o salário 
do funcionário com base em uma porcentagem dada (somente o 
salário bruto é afetado pela porcentagem) e mostrar novamente os 
dados do funcionário. Use a classe projetada abaixo.

Nome: Joao Silva
Salário bruto: 6000.00
Imposto: 1000.00
Funcionário: Joao Silva, $ 5000.00
Digite a porcentagem para aumentar o salário: 10.0
Dados atualizados: Joao Silva, $ 5600.00
*/

Funcionario func = new Funcionario();

Console.Write("Digite um nome: ");
func.Nome = Console.ReadLine();
Console.Write("Digite o salário Bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite o valor do Imposto: ");
func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("\nFuncionario: " + func);

Console.Write("\nDigite a porcentagem para aumentar o salário: ");
double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
func.AumentarSalario(porcent);

Console.Write("\nDados atualizados: " + func);