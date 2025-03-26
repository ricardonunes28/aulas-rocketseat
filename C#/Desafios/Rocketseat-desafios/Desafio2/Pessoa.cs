namespace Desafio2
{
    public class Pessoa
    {
        public string InputNome()
        {
            Console.WriteLine("Digite o seu nome: " );
            return Console.ReadLine();
        }

        public string InputSobreNome()
        {
            Console.WriteLine("Digite o seu sobre nome: ");
            return Console.ReadLine();
        }


        public void ExibiNomeCompleto(string nome, string sobreNome)
        {
            Console.Clear();
            string nomeCompleto = nome + " " + sobreNome;

            Console.WriteLine($"Olá: {nomeCompleto}!!");
        }

    }
}
