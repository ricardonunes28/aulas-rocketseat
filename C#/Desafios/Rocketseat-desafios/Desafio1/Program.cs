/*
 Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  
 Olá, Welisson! Seja muito bem-vindo!
 */

using Desafio1;

var boasVindas = new BoasVindas();

var nome = boasVindas.InputName();

if(!string.IsNullOrWhiteSpace(nome))
{
    boasVindas.MensagemBoasVindas(nome);
}
else
{
    Console.WriteLine("Você não digitou um nome valido");
}