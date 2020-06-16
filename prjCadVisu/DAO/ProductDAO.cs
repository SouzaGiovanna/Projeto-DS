using prjCadVisu.Database;
using prjCadVisu.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjCadVisu.DAO
{
    public class ProductDAO
    {
        public readonly Connection connection = new Connection();

        public void Insert(Product product)
        {
            connection.ConnetionVoid();

            try
            {
                connection.connection.Open();

                SqlCommand query = new SqlCommand(
                    "INSERT INTO tbProduct(descriptionProduct, valueProduct)" +
                        "VALUES(@description, @value)", connection.connection);


                query.Parameters.AddWithValue("@description", product.Description);
                query.Parameters.AddWithValue("@value", product.Value);
                query.ExecuteNonQuery();
            }
            catch (Exception) {
                MessageBox.Show("Não foi possível realizar o INSERT na tabela de Produtos.");
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

                SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM tbProduct", connection.connection);
                DataTable table = new DataTable();

                query.Fill(table);
                table.Columns[0].ColumnName = "ID";
                table.Columns[1].ColumnName = "Description";
                table.Columns[2].ColumnName = "Value";
                view.DataSource = table;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar o SELECT na tabela de Produtos.");
            }
            finally
            {
                connection.connection.Close();
            }
        }

    }
}
