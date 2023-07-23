using System.Globalization; // para usar o culture info

byte n1 = 125;
int n2 = 1000;
int n3 = 2147483647;
long n4 = 2147483648L; // L no final para indicar que se trabalha com números longos
bool completo = false;
char genero = 'F';
float n5 = 4.5f; //F no final pra sinalizar que é float e não confundir com double
double n6 = 4.6;
string nome = "Maria Green";
double saldo = 10.35784;
int idade = 32;


Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(completo);
Console.WriteLine(genero);
Console.WriteLine(n5);
Console.WriteLine(n6);
Console.WriteLine(nome);
Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //aqui ele desconsidera qualquer formatção


//Concatenando por placeholder                            :F2 aqui serve para limitar as casas decimais no placeholder
Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

//Interpolação
Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

//Concatenação
Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");