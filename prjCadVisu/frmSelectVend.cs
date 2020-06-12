using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class frmSelectVend : Form
    {
        public frmSelectVend(List<String> dados)
        {
            InitializeComponent();

            addList(dados);
        }



        //Meus métodos
       public void addList(List<String> dados)
        {
            int tam = dados.Count();

            for (int i = 0; i < tam; i++)
            {
                lbDados.Items.Add(dados[i]);
            }
            
        }
    }
}
