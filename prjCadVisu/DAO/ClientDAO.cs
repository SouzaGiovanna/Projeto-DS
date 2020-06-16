using prjCadVisu.Database;
using prjCadVisu.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjCadVisu.DAO
{
    public class ClientDAO
    {
        public readonly Connection connection = new Connection();

        public void Insert(Client client)
        {
            connection.ConnetionVoid();

            try
            {
                connection.connection.Open();

                SqlCommand query = new SqlCommand(
                    "INSERT INTO tbClient(nameClient, cpfClient, rgClient, addressClient)" +
                        "VALUES(@name, @cpf, @rg, @address)", connection.connection);


                query.Parameters.AddWithValue("@name", client.Name);
                query.Parameters.AddWithValue("@cpf", client.CPF);
                query.Parameters.AddWithValue("@rg", client.RG);
                query.Parameters.AddWithValue("@address", client.Address);
                query.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar o INSERT na tabela de Clientes.");
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

                SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM tbClient", connection.connection);
                DataTable table = new DataTable();

                query.Fill(table);
                table.Columns[0].ColumnName = "ID";
                table.Columns[1].ColumnName = "Name";
                table.Columns[2].ColumnName = "CPF";
                table.Columns[3].ColumnName = "RG";
                table.Columns[4].ColumnName = "Address";
                view.DataSource = table;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar o SELECT na tabela de Clientes.");
            }
            finally
            {
                connection.connection.Close();
            }
        }
    }
}
