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
    public class NPersona
    {
        public bool InsertarPersonal(DPersona parametros)
        {
			try
			{
                DConexion.Abrir();
                SqlCommand cmd = new SqlCommand("InsertarPersonal", DConexion.Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.IdCargo);
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
                DConexion.Cerrar();
            }
        }

        public bool EditarPersonal(DPersona parametros)
        {
            try
            {
                DConexion.Abrir();
                SqlCommand cmd = new SqlCommand("EditarPersonal", DConexion.Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@id_persona", parametros.IdPersona);
                cmd.Parameters.AddWithValue("@nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.IdCargo);
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
                DConexion.Cerrar();
            }
        }

        public bool EliminarPersonal(DPersona parametros)
        {
            try
            {
                DConexion.Abrir();
                SqlCommand cmd = new SqlCommand("EliminarPersonal", DConexion.Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@id_persona", parametros.IdPersona);
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
                DConexion.Cerrar();
            }
        }

        public void MostrarPersonal(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                DConexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarPersonal", DConexion.Conectar);
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
                DConexion.Cerrar();
            }
        }

        public void BuscarPersonal(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                DConexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonal", DConexion.Conectar);
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
                DConexion.Cerrar();
            }
        }
    }
}
