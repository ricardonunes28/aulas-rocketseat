using System.Globalization;

namespace Desafio6
{
    public class DataAtual
    {
        public void ExibirDataAtual(string opcao)
        {
            DateTime dataAtual = DateTime.Now;

            switch (opcao) 
            {
                case "1":
                    Console.WriteLine($"Data Completa: {dataAtual.ToString("dddd, dd 'de' MMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR"))}");
                    break;
                case "2":
                    Console.WriteLine($"Apenas a data: {dataAtual.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"))}");
                    break;
                case "3":
                    Console.WriteLine($"Apenas a hora: {dataAtual.ToString("HH:mm:ss", new CultureInfo("pt-BR"))}");
                    break;
                case "4":
                    Console.WriteLine($"Data com o mês por extenso: {dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"))}");
                    break;
               default:
                    Console.WriteLine($"Escolha uma opção de 1 a 4");
                    break;
            }
        }
    }
}
