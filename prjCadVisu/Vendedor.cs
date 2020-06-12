using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCadVisu
{
    class Vendedor
    {
        private String nome;
        private String cpf;
        private List <String> dados = new List<String>();

        public Vendedor(string Nome , string Cpf )
        {
            nome = Nome;
            cpf = Cpf;

            Dados.Add("Código: " +tamanhoList() + 1+ " - Nome: " +Nome+ " - CPF: " +Cpf);
        }

        public string Nome { 
            get => nome; 
            set => nome = value; 
        }

        public string Cpf { 
            get => cpf; 
            set => cpf = value; 
        }

        public List<string> Dados { 
            get => dados; 
            set => dados = value; 
        }

        public int tamanhoList()
        {
            int tam = Dados.Count();

            if(tam == 0)
            {
                return 0;
            }
            else
            {
                return tam;
            }
        }
    }
}
