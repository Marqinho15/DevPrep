// See https://aka.ms/new-console-template for more information

/*
Pede idade ao utilizador
Imprime: “Criança”, “Adolescente” ou “Adulto”
Usa if/else
*/

Console.Write("Indique a idade: ");
string idade = Console.ReadLine();
int idade2 = int.Parse(idade);

if (idade2 >= 18)
{
    Console.WriteLine("Adulto");
}
else if (idade2 >= 13)
{
    Console.WriteLine("Adolescente");
}
else
{
    Console.WriteLine("Criança");
}


// Necessidade de receber primeiro o Console.ReadLine(); como string e converter a int antes de fazer as comparaçoes.