using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IntroduccionCsh.Logica
{
    public class lconexion
    {
        public static string RutaConexion = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=TimeMachineDB; Integrated Security=true";
        public static SqlConnection Conectar = new SqlConnection(RutaConexion);

        public static void Abrir()
        {
            if(Conectar.State == ConnectionState.Closed)
            {
                Conectar.Open();
            }
        }

        public static void Cerrar()
        {
            if (Conectar.State == ConnectionState.Open)
            {
                Conectar.Close();
            }
        }
    }
}
