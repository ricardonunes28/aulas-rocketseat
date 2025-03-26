/*
 1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso.
 */

using Desafio6;

var dataAtual = new DataAtual();

Console.WriteLine("Escolha uma das opções abaixo: ");
Console.WriteLine("1 -  Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos). ");
Console.WriteLine("2 -  Apenas a data no formato \"01/03/2024\". ");
Console.WriteLine("3 -  Apenas a hora no formato de 24 horas. ");
Console.WriteLine("4 -  A data com o mês por extenso. ");

var opcao = Console.ReadLine();

if (string.IsNullOrWhiteSpace(opcao))
{
    opcao = "1";
}

dataAtual.ExibirDataAtual(opcao!);

