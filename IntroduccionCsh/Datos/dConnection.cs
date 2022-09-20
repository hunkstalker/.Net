using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IntroduccionCsh.Datos
{
    internal static class dConnection
    {
        public static SqlConnection connection = new SqlConnection(@"Data source=localhost\SQLEXPRESS; Initial Catalog=UsuariosDB; Integrated Security=true;");
        public static void Open()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
