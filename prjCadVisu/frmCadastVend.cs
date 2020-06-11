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
    public partial class frmCadastVend : Form
    {
        public String nome, cpf;
        public frmCadastVend()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0 || txtCpf.Text.Length == 0)
            {
                MessageBox.Show("Preencha os campos em branco antes de prosseguir");
            }
            else
            {
                MessageBox.Show("Dados salvos com sucesso!!!");

                add();

                clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clear();
        }




        //Meus métodos
        public void clear()
        {
            txtNome.Clear();
            txtCpf.Clear();
        }

        public void add()
        {
            Vendedor vendedor = new Vendedor();
            vendedor.Nome = txtNome.Text;
            vendedor.Cpf = txtCpf.Text;
            
            nome = vendedor.Nome;
            cpf = vendedor.Cpf;

            Console.WriteLine(vendedor.Nome);
            Console.WriteLine(vendedor.Cpf);
        }
    }
}
