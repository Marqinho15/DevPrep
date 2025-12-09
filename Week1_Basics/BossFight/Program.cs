// See https://aka.ms/new-console-template for more information
/*
Programa que:
    Pede nome e idade
    Armazena num array ou List
    Imprime “Olá, [nome], tens [idade] anos”
*/


class Pessoa
{
    public string nome;
    public int idade;
}

class Program
{
    static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        Pessoa p = new Pessoa();
        p.nome = "Marco";
        p.idade = 29;

        pessoas.Add(p);

        Pessoa p2 = new Pessoa();
        p2.nome = "Ana";
        p2.idade = 30;
        pessoas.Add(p2);

        foreach (Pessoa pessoa in pessoas)
        {
         Console.WriteLine($"O seu nome é: {pessoa.nome} e têm {pessoa.idade} anos");   
        }   
    }
}