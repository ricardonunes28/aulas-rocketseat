using System.Text.RegularExpressions;

namespace Desafio5
{
    public class ValidacaoPlaca
    {
        private readonly string padrao = @"^[A-Za-z]{3}\d{4}$";
        public bool ValidarPlaca(string placa)
        {
            return Regex.IsMatch(placa, padrao);
        }
    }
}
