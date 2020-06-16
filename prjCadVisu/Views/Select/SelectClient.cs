using prjCadVisu.DAO;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class SelectClient : Form
    {
        public SelectClient()
        {
            InitializeComponent();

            new ClientDAO().SelectAll(dataGridView1);
        }
    }
}
