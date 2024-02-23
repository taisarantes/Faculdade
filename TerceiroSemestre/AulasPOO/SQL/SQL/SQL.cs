using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class SQL
    {
        public SqlConnection connection = new SqlConnection();
        public SQL()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = @"10.135.0.53\sqledutsi";
            sb.UserID = "aluno";
            sb.Password = "aluno";
            sb.InitialCatalog = "IBGE";
            sb.Encrypt= true; //Dados encriptados
            sb.TrustServerCertificate = true; //Cetificado SSL
            connection.ConnectionString = sb.ConnectionString;
        }

    }
}
