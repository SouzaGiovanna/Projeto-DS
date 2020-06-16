using prjCadVisu.Database;
using prjCadVisu.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjCadVisu.DAO
{
    public class SallerDAO
    {
        public readonly Connection connection = new Connection();

        public void Insert(Saller saller)
        {
            connection.ConnetionVoid();

            try
            {
                connection.connection.Open();

                SqlCommand query = new SqlCommand(
                    "INSERT INTO tbSaller(nameSaller, cpfSaller)" +
                        "VALUES(@name, @cpf)", connection.connection);


                query.Parameters.AddWithValue("@name", saller.Name);
                query.Parameters.AddWithValue("@cpf", saller.CPF);
                query.ExecuteNonQuery();
            } catch(Exception)
            {
                MessageBox.Show("Não foi possível realizar o INSERT na tabela de Vendedores.");
            }
            finally
            {
                connection.connection.Close();
            }
        }

        public void SelectAll(DataGridView view)
        {
            connection.ConnetionVoid();

            try
            {
                connection.connection.Open();

                SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM tbSaller", connection.connection);
                DataTable table = new DataTable();

                query.Fill(table);
                table.Columns[0].ColumnName = "ID";
                table.Columns[1].ColumnName = "Name";
                table.Columns[2].ColumnName = "CPF";
                view.DataSource = table;

            } catch(Exception)
            {
                MessageBox.Show("Não foi possível realizar o SELECT na tabela de Vendedores.");
            } 
            finally
            {
                connection.connection.Close();
            }
        }
    }
}
