﻿using System;
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

        public Vendedor(string Nome , string Cpf )
        {
            nome = Nome;
            cpf = Cpf;
        }

        public string Nome { 
            get => nome; 
            set => nome = value; 
        }

        public string Cpf { 
            get => cpf; 
            set => cpf = value; 
        }
    }
}
