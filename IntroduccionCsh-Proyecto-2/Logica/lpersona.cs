using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IntroduccionCsh.Datos;
using System.Data;

namespace IntroduccionCsh.Logica
{
    public class lpersona
    {
        public bool InsertarPersonal(dpersona parametros)
        {
			try
			{
                lconexion.Abrir();
                SqlCommand cmd = new SqlCommand("InsertarPersonal", lconexion.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;
			}
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
                return false;
			}
            finally
            {
                lconexion.Cerrar();
            }
        }

        public bool EditarPersonal(dpersona parametros)
        {
            try
            {
                lconexion.Abrir();
                SqlCommand cmd = new SqlCommand("EditarPersonal", lconexion.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_persona", parametros.Id_persona);
                cmd.Parameters.AddWithValue("@nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@sueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                lconexion.Cerrar();
            }
        }

        public bool EliminarPersonal(dpersona parametros)
        {
            try
            {
                lconexion.Abrir();
                SqlCommand cmd = new SqlCommand("EliminarPersonal", lconexion.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_persona", parametros.Id_persona);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                lconexion.Cerrar();
            }
        }


    }
}
