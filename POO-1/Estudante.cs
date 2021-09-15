using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    public class Estudante : Pessoa
    {
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento) : base(nome, documento, dataNascimento)
        {
            // com o : base(), estamos dizendo que usaremos as mesmas propriedades do original (Pessoa)
            Turma = turma;
            Notas = new List<int> { 5, 10, 4, 2, 3, 5 };
        }
        public string Turma { get; private set; }
        public List<int> Notas { get; private set; }

        public override void SeApresentar()
        {
            base.SeApresentar(); // puxa o próprio método original

            var media = Notas.Average();

            Console.WriteLine($"Sou um estudante da turma {Turma}, com Media de Nota: {media}");
        }
    }
}
