using prjCadVisu.DAO;
using prjCadVisu.Model;
using System;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class RegisterSaller : Form
    {
        public RegisterSaller() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0 || txtCpf.Text.Length == 0)
                MessageBox.Show("Preencha os campos em branco antes de prosseguir");
            else
            {
                MessageBox.Show("Dados salvos com sucesso!!!");

                Add();
                Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) => Clear();

        public void Clear()
        {
            txtNome.Clear();
            txtCpf.Clear();
        }

        public void Add()
        {
            Saller saller = new Saller(txtNome.Text, txtCpf.Text);
            new SallerDAO().Insert(saller);
        }
    }
}
