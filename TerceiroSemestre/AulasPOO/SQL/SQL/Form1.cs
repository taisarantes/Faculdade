using System.Data.SqlClient;

namespace SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (SqlConnection connection = new SQL().connection)
            {
                try{
                    connection.Open();
                    string sql = "SELECT * FROM Estado";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        string nome = (string)reader["estado_nNome"];
                        cmbEstado.Items.Add(nome);
                    }

                }
                catch(Exception ex) 
                {
                    MessageBox.Show("ERRO:" + ex.Message);
                }
            }

        }
    }
}