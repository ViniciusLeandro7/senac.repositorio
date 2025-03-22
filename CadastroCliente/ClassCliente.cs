using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class ClassCliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string dataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string nomesocial { get; set; }
        public bool estrangeiro { get; set; }
        public TipoCliente Tipo { get; set; }

        public ClassEndereco Endereco { get; set; }

        public Etnia etnia { get; set; }

        public Genero Genero { get; set; }
    }
    
    
   
}
