using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.ConnectionBD
{
    public class Connection
    {
        //método de conexão com o banco My Sql
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["person"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
