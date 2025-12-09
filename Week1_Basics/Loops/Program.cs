// See https://aka.ms/new-console-template for more information
//Usa for para imprimir números de 1 a 10
//Usa while para contar de 10 a 1
//Usa foreach para imprimir todos elementos de um array de strings

int contar = 10;
string[] nomes = {"Ana", "Marco", "Beatriz", "Leonor"};
for(int i=1; i<11; i++)
{
    Console.WriteLine(i);
}
while (contar>0)
{
    Console.WriteLine(contar);
    contar --;
}
foreach (var item in nomes)
{
    Console.WriteLine(item);
}