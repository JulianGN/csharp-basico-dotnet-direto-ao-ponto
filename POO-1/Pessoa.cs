using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    public abstract class Pessoa
    {
        // Pessoa será a classe base e poderá ser herdada por outras
        public Pessoa(string nome, string documento, DateTime dataNascimento)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; protected set; }
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; protected set; }

        public virtual void SeApresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Documento {Documento}, Data de Nascimento: {DataNascimento}");
        }


    }
}
