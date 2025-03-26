/*
 * 1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, 
    * seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    
    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
 */

using Desafio5;

var validar = new ValidacaoPlaca();

Console.WriteLine("Digite a placa de seu veiculo: ");

var entradaPlaca = Console.ReadLine();

if (string.IsNullOrWhiteSpace(entradaPlaca))
{
    Console.WriteLine("Você não digitou a placa do seu veiculo: ");
    return;
}

if (validar.ValidarPlaca(entradaPlaca))
{
    Console.WriteLine("***Verdadeiro***");
}
else
{
    Console.WriteLine("***Falso***");
}




