using System;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Register

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterClient registerClient = new RegisterClient();
            registerClient.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterSaller registerSaller = new RegisterSaller();
            registerSaller.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct registerProduct = new RegisterProduct();
            registerProduct.ShowDialog();
        }

        #endregion

        #region Select

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectClient selectClient = new SelectClient();
            selectClient.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectSaller selectSaller = new SelectSaller();
            selectSaller.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectProduct selectProduct = new SelectProduct();
            selectProduct.ShowDialog();
        }

        #endregion
    }
}
