using prjCadVisu.DAO;
using System.Windows.Forms;

namespace prjCadVisu
{
    public partial class SelectProduct : Form
    {
        public SelectProduct()
        {
            InitializeComponent();

            new ProductDAO().SelectAll(dataGridView1);
        }
    }
}
