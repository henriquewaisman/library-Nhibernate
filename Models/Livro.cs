using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bibliotecaNhibernate.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
        public Livro()
        {
            
        }
    }
}