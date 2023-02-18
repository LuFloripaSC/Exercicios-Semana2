
namespace Exercicio3
{
    public class MensagemCelular
    {
        private int telefone;
        private string mensagem;
        public int Telefone { get; set; }

        public string Mensagem { get; set; }

        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine($"Telefone {Telefone}, Mensagem {Mensagem}");
        }
        public void Executar()
        {
            Console.WriteLine("Método Executado pelo Console");
            EnviarMensagemAoTelefone();
        }
    }
}