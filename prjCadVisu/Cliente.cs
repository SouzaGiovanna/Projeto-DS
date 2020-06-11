using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCadVisu
{
    class Cliente
    {
        private String nome;
        private String cpf;
        private String rg;
        private String endereco;

        //getters and setters

        public string Nome { 
            get => nome; 
            set => nome = value; 
        }

        public string Cpf {
            get => cpf; 
            set => cpf = value; 
        }

        public string Rg { 
            get => rg; 
            set => rg = value; 
        }

        public string Endereco { 
            get => endereco; 
            set => endereco = value; 
        }
    }
}
