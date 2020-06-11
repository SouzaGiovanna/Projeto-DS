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
    public partial class Form1 : Form
    {
        public int clickFrm;
        public String nomeVend, cpfVend;
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickFrm = 0;
            abrirFrm(clickFrm);
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickFrm = 1;
            abrirFrm(clickFrm);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickFrm = 2;
            abrirFrm(clickFrm);
        }

        //Listagem

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickFrm = 3;
            abrirFrm(clickFrm);
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickFrm = 4;
            abrirFrm(clickFrm);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickFrm = 5;
            abrirFrm(clickFrm);
        }

        //Meus métodos

        public void abrirFrm(int click)
        {
            if(click == 0)
            {
                frmCadast cadast = new frmCadast();
                cadast.ShowDialog();
            }
            if(click == 1)
            {
                frmCadastVend cadastVend = new frmCadastVend();
                cadastVend.ShowDialog();
                nomeVend = cadastVend.nome;
                cpfVend = cadastVend.cpf;
            }
            if(click == 2)
            {
                frmCadastProd cadastProd = new frmCadastProd();
                cadastProd.ShowDialog();
            }
            if(click == 3)
            {
                /*frmListCliente listCliente = new frmListCliente();
                listCliente.ShowDialog();*/
            }
            if(click == 4)
            {
                frmSelectVend listVend = new frmSelectVend(nomeVend, cpfVend);
                listVend.ShowDialog();
            }
            if(click == 5)
            {
                /*frmListProd listProd = new frmListProd();
                listProd.ShowDialog();*/
            }
        }
    }
}
