namespace Desafio3
{
    public class ObterNumeros
    {
        public List<double> Numeros()
        {
            List<double> numeros = new List<double>();

            while (numeros.Count < 2)
            {
                Console.WriteLine("Digite pelo menos dois numeros para as operações");

                Console.WriteLine("************************************************");


                Console.WriteLine("Digite o primeiro numero: ");
                if (double.TryParse(Console.ReadLine(), out double num1))
                {
                    numeros.Add(num1);
                   
                }
                else
                {
                    Console.WriteLine("Insira um nummero valido");
                    continue;
                }


                Console.WriteLine("Digite o segundo numero: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    numeros.Add(num2);
                  
                }
                else
                {
                    Console.WriteLine("Insira um nummero valido");
                    continue;
                }

            }
                return numeros;
        }
    }
}
