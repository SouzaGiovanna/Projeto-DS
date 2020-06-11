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
    public partial class frmCadastProd : Form
    {
        public Double valor;

        public frmCadastProd()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Length == 0 || txtVal.Text.Length == 0)
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

        private void txtVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtVal.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }





        //Meus métodos

        public void clear()
        {
            txtDesc.Clear();
            txtVal.Clear();
        }

        public void add()
        {
            valor = Convert.ToDouble(txtVal.Text);

            Produto produto = new Produto();
            produto.Desc = txtDesc.Text;
            produto.Val = Math.Round(valor, 2);

            Console.WriteLine(produto.Desc);
            Console.WriteLine(produto.Val);
        }
    }
}
