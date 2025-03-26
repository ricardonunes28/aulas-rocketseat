namespace Desafio3
{
    public class Calculadora
    {
        List<double> Numeros {  get; set; }
        public Calculadora(List<double> numeros)
        {
            Numeros = numeros;
        }
        public void ResultadoDaOperacao(double resultado, string tipoDeOperacao)
        {
           
            Console.WriteLine("****************************************************");
            Console.WriteLine($"O resultado da operação {tipoDeOperacao} é: {resultado}");
            Console.WriteLine("****************************************************");

        }
        public void Soma()
        {
            double resultado = Numeros.Sum();
            ResultadoDaOperacao(resultado, "Soma");
        }

        public void Subtracao()
        {
            double resultado = Numeros[0];
            for (int i = 1; i < Numeros.Count; i++)
            {
                resultado -= Numeros[i];
            }
            ResultadoDaOperacao(resultado, "Subtracao");
        }

        public void Multiplicacao()
        {
            double resultado = 1;
            foreach (var num in Numeros)
            {
                resultado *= num;
            }
            ResultadoDaOperacao(resultado, "Multiplicacao");
        }

        public void Divisao()
        {

            if (Numeros.Contains(0))
            {
                Console.WriteLine("Divisão não é possivel dividir por zero");
                return;
            }
            double resultado = Numeros[0];
            for (int i = 1; i < Numeros.Count; i++)
            {
                resultado /= Numeros[i];
            }

            ResultadoDaOperacao(resultado, "Divisao");
        }

        public void Media()
        {
            double resultado = Numeros.Average();
            ResultadoDaOperacao(resultado, "Media");
        }
    }
}
