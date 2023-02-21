
namespace Exercicio6
{
    internal class Filme
    {
        public string NomeFilme;
        public string Categoria;
        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
        }
        public void Exibir()
        {
            Console.WriteLine($"Filme {NomeFilme}, Categoria {Categoria}");
        }
    }
      

}
