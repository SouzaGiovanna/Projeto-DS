using prjCadVisu.DAO;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class SelectSaller : Form
    {
        public SelectSaller()
        {
            InitializeComponent();

            new SallerDAO().SelectAll(dataGridView1);
        }
    }
}
