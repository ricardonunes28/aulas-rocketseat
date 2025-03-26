namespace Desafio1
{
    public class BoasVindas
    {
        public string InputName()
        {
         
            Console.WriteLine($"Qual seu Nome? ");
  
            return Console.ReadLine();
        }

        public void MensagemBoasVindas(string nome)
        {

            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
            Console.WriteLine("********************************************");

        }
    }
}
