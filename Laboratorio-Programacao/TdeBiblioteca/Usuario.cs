using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TdeBiblioteca
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Usuario (string nome, string endereco, string telefone) 
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        public Usuario() {}

    }
}