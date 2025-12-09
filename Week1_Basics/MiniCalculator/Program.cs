// See https://aka.ms/new-console-template for more information
int a = 10;
int b = 20;
int soma = a + b;
int subtracao = a - b;
int multiplicacao = a * b;
double divisao = (double)a / b;
Console.WriteLine($"A soma de A e B é {soma} , A menos B é  {subtracao} , A multiplicacao é {multiplicacao} , A divisao é  {divisao}");

// divisao a dar 0, gepeto clarificou que quando se divide um int por outro o C# mesmo com variavel da divisao a double retorna inteiro a nao ser que declare a e b como double ou converta um deles a double na variavel "divisao", o que fiz agora.
// double divisao = a / b;