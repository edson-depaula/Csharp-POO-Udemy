using Exercício_01;
using System.Globalization;

/*
Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe 
como mostrado no projeto ao lado.

Entre a largura e altura do retângulo:
3.00
4.00
AREA = 12.00
PERÍMETRO = 14.00
DIAGONAL = 5.00
*/
Retangulo r = new Retangulo();

Console.Write("Digite a altura do Triângulo: ");
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("\nDigite a largura do Triângulo: ");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"\nA Área do Triângulo é igual a : {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"O Perímetro do Triângulo é igual a : {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"A Diagonal do Triângulo é igual a : {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");