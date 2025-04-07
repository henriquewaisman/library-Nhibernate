using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bibliotecaNhibernate.Models
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Cidade { get; set; }

        public Editora()
        {

        }

        public Editora(string nome, string? cidade = null)
        {
            Nome = nome;
            Cidade = cidade;
        }
    }
}