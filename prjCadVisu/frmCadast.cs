using System;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class frmCadast : Form
    {
        public frmCadast()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length == 0 || txtCpfCliente.Text.Length == 0 ||
                txtRg.Text.Length == 0 || txtEndereco.Text.Length == 0)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clear();
        }





        //Meus métodos

        public void clear()
        {
            txtNome.Clear();
            txtCpfCliente.Clear();
            txtEndereco.Clear();
            txtRg.Clear();
        }

        public void add()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpfCliente.Text;
            cliente.Rg = txtRg.Text;
            cliente.Endereco = txtEndereco.Text;

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.Cpf);
            Console.WriteLine(cliente.Rg);
            Console.WriteLine(cliente.Endereco);
        }
    }
}