using Desafio3;

var obterNumeros = new ObterNumeros();
var numeros = obterNumeros.Numeros();

var calculadora = new Calculadora(numeros);

calculadora.Soma();
calculadora.Subtracao();
calculadora.Divisao();
calculadora.Multiplicacao();
calculadora.Media();


