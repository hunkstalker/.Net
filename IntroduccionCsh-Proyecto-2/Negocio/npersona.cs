using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using IntroduccionCsh.Datos;

namespace IntroduccionCsh.Negocio
{
    public class npersona
    {
        public bool InsertarPersonal(dpersona parametros)
        {
			try
			{
                dconexion.Abrir();
                SqlCommand cmd = new SqlCommand("InsertarPersonal", dconexion.Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
                dconexion.Cerrar();
            }
        }

        public bool EditarPersonal(dpersona parametros)
        {
            try
            {
                dconexion.Abrir();
                SqlCommand cmd = new SqlCommand("EditarPersonal", dconexion.Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
                dconexion.Cerrar();
            }
        }

        public bool EliminarPersonal(dpersona parametros)
        {
            try
            {
                dconexion.Abrir();
                SqlCommand cmd = new SqlCommand("EliminarPersonal", dconexion.Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
                dconexion.Cerrar();
            }
        }

        public void MostrarPersonal(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                dconexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarPersonal", dconexion.Conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dconexion.Cerrar();
            }
        }

        public void BuscarPersonal(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                dconexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonal", dconexion.Conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dconexion.Cerrar();
            }
        }
    }
}
