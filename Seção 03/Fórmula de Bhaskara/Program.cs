Console.WriteLine("Olá! Hoje irei lhe ajudar com a fórmula de Bhaskara.\n");

double a = 0, b = 0, c = 0, delta = 0, x1 = 0, x2 = 0;

Console.Write("Digite o valor de \"A\": ");
a = double.Parse(Console.ReadLine());
Console.Write("Digite o valor de \"B\": ");
b = double.Parse(Console.ReadLine());
Console.Write("Digite o valor de \"C\": ");
c = double.Parse(Console.ReadLine());

delta = Math.Pow(b, 2.0) - 4.0 * a * c;

if (delta < 0)
{
    Console.WriteLine("\nNão existem raízes reais para a equação.");
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine($"\nO valor de Delta é: {delta}.\n");
    Console.WriteLine($"O valor de \"X1\" é igual a: {x1}.");
    Console.WriteLine($"O valor de \"X2\" é igual a: {x2}.");
}
