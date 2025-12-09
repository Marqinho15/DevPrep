// See https://aka.ms/new-console-template for more information
/*
Cria classe Pessoa com Nome e Idade

Instancia 2 pessoas e imprime os nomes
*/

/*
class Pessoa
{
    public string nome;
    public int idade;

}

Pessoa p = new Pessoa();
p.nome = "Marco";
p.idade = 29;

Pessoa p2 = new Pessoa();
p2.nome = "Ana";
p2.idade = 30;
Console.WriteLine($"O casal é composto por: {p.nome} e: {p2.nome} que têm {p.idade} anos e {p2.idade} anos");

    Codigo acima deu erro: error CS8803: Top-level statements must precede namespace and type declarations. 

*/

// Mesmo código usando Main ():

class Pessoa
{
    public string nome;
    public int idade;
}

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa();
        p.nome = "Marco";
        p.idade = 29;

        Pessoa p2 = new Pessoa();
        p2.nome = "Ana";
        p2.idade = 30;

        Console.WriteLine($"O casal é composto por: {p.nome} e {p2.nome} que têm {p.idade} anos e {p2.idade} anos");
    }
}