// See https://aka.ms/new-console-template for more information
/*Cria array de 5 números e imprime cada elemento
Cria uma List<string> com 3 nomes, adiciona mais 1, remove 1, imprime tamanho
*/
int[] numeros = {1,2,3,4,5};

foreach (var item in numeros)
{
    Console.WriteLine (item);
}

List<string> lista = new List<string> {"Ana", "Marco", "Beatriz"};
lista.Add("Leonor");
lista.Remove("Ana");
Console.WriteLine(lista.Count);