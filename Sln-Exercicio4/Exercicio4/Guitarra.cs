

namespace Exercicio4
{
    public class Guitarra
    {
        private static string afinacao = "SOL";

        public Guitarra() {
        }
        public void Tocar()
        {
            TomAfinado();
        }
        public void Tocar(string afinacaoAtual)
        {
            afinacao = afinacaoAtual;
            TomAfinado();
        }
        private void TomAfinado() 
        {
            Console.WriteLine("A guitarra esta com afinaçao em " + afinacao);
        }
    }
}
