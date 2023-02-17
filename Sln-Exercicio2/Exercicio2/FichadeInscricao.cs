using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class FichadeInscricao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }
        public FichadeInscricao(int id, string nome, DateTime dataNascimento, bool menorIdade)

        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;
        }

        public void MostrarCampos()
        {
            Console.WriteLine($"Id{Id}");
            Console.WriteLine($"Nome {Nome}");
            Console.WriteLine($"DataNascimento {DataNascimento}");
                if (MenorIdade == false) Console.WriteLine("Maior de Idade");
                else Console.WriteLine("Menor de Idade");
           
        }
    }
}