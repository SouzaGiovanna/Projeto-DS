using prjCadVisu.DAO;
using prjCadVisu.Model;
using System;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class RegisterClient : Form
    {
        public RegisterClient() => InitializeComponent();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length == 0 || txtCpfCliente.Text.Length == 0 ||
                txtRg.Text.Length == 0 || txtEndereco.Text.Length == 0)
                MessageBox.Show("Preencha os campos em branco antes de prosseguir");

            else
            {
                MessageBox.Show("Dados salvos com sucesso!!!");

                Add();
                Clear();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtNome.Clear();
            txtCpfCliente.Clear();
            txtEndereco.Clear();
            txtRg.Clear();
        }

        public void Add()
        {
            Client client = new Client(txtNome.Text, txtCpfCliente.Text, txtRg.Text, txtEndereco.Text);
            new ClientDAO().Insert(client);
        }
    }
}