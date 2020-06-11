using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCadVisu
{
    class Produto
    {
        private String desc;
        private Double val;

        public string Desc { 
            get => desc; 
            set => desc = value; 
        }

        public double Val { 
            get => val; 
            set => val = value; 
        }
    }
}
