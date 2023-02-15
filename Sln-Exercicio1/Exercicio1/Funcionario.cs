using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Funcionario
    {
        private int id;
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public void SalvarFuncionario()
        {
            Console.WriteLine($"Passou por aqui");
            Console.WriteLine($"Id {id}");
        }
        public int GerarCodigo()
        {
            return 123456;
        }


    }
}
