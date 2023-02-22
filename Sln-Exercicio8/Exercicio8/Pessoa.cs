
namespace Exercicio8
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public void MostrarIdade()
        {
            int idade = CalcularIdade();
            Console.WriteLine($"Nome {Nome} tem a Idade de {idade} anos");
        }
        private int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
    }
}
