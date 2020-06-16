using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjCadVisu.Database
{
    public class Connection
    {
        public SqlConnection connection;

        public void ConnetionVoid()
        {
            try
            {
                connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=" +
                    "False;Initial Catalog=dbCadVisu;Data Source=ALEQUIS-PC\\SQLEXPRESS");
            }
            catch (Exception) {
                MessageBox.Show("Não foi possível conseguir a conexão com o banco de dados SQL Server.");
            }
        }
    }
}
