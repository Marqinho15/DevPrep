// See https://aka.ms/new-console-template for more information

/*Cria função Somar(int a, int b)
Chama-a com 2 números e imprime resultado
Cria função Multiplicar com static e imprime
*/


int Somar(int a, int b)
{
    return a + b;
}
int resultado = Somar(3, 4);
Console.WriteLine("A soma dá " + (resultado));

static int Multiplicar (int a, int b)
{
    return a * b;
}
int multiplicacao = Multiplicar(4, 2);
Console.WriteLine("A Multiplicação dá " + (multiplicacao));