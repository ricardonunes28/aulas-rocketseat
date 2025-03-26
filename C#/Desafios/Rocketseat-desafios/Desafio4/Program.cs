/*
 * Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
 */

Console.WriteLine("Digite uma ou mais palavras: ");

var entradaPalavra = Console.ReadLine();

if(string.IsNullOrWhiteSpace(entradaPalavra))
{
    Console.WriteLine("Nenhuma palavra foi digitda...");
    return;
}

string[] palavras = entradaPalavra.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("\nQuantidade de caracteres por palavra: ");

foreach (var item in palavras)
{
    Console.WriteLine($"'{item}': {item.Length} caracteres");
}





