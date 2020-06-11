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
        public int index;
        public frmSelectVend(String nome, String cpf)
        {
            InitializeComponent();

            Console.WriteLine(nome);
            Console.WriteLine(cpf);

            addList(nome, cpf);
        }

        private void ltbCodVend_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = ltbCodVend.SelectedIndex;
            ltbNomeVend.SetSelected(index, true);
            ltbCpfVend.SetSelected(index, true);
        }

        private void ltbNomeVend_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*index = ltbNomeVend.SelectedIndex;
            //ltbCodVend.SetSelected(index, true);
            ltbCpfVend.SetSelected(index, true);*/
        }

        private void ltbCpfVend_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = ltbCpfVend.SelectedIndex;
            ltbNomeVend.SetSelected(index, true);
            //ltbCodVend.SetSelected(index, true);
        }



        //Meus métodos
        

       public void addList(String nome, String cpf)
        {
            ltbNomeVend.Items.Add(nome);
            ltbCpfVend.Items.Add(cpf);
        }
    }
}
