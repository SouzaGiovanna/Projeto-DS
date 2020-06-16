using prjCadVisu.DAO;
using prjCadVisu.Model;
using System;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class RegisterProduct : Form
    {
        public RegisterProduct() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Length == 0 || txtVal.Text.Length == 0)
                MessageBox.Show("Preencha os campos em branco antes de prosseguir");
            else
            {
                MessageBox.Show("Dados salvos com sucesso!!!");

                Add();
                Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) => Clear();

        private void txtVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // Troca o . pela virgula
                e.KeyChar = ',';

                // Verifica se já existe alguma vírgula na string, caso exista aborte 
                if (txtVal.Text.Contains(","))
                    e.Handled = true; 
            }

            // Aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char) Keys.Back))
                e.Handled = true;
        }

        public void Clear()
        {
            txtDesc.Clear();
            txtVal.Clear();
        }

        public void Add()
        {
            Product product = 
                new Product(txtDesc.Text, Math.Round(Convert.ToDouble(txtVal.Text), 2));

            new ProductDAO().Insert(product);
        }
    }
}
