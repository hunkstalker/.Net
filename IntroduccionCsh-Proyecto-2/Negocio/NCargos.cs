using IntroduccionCsh.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntroduccionCsh.Negocio
{
    internal class NCargos
    {
        public bool InsertarCargo(DCargos parametros)
        {
            try
            {
                DConexion.Abrir();
                SqlCommand cmd = new SqlCommand("InsertarCargo", DConexion.Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@cargo", parametros.Cargo);
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

        public bool EditarPersonal(DCargos parametros)
        {
            try
            {
                DConexion.Abrir();
                SqlCommand cmd = new SqlCommand("EditarCargo", DConexion.Conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@id_cargo", parametros.IdCargo);
                cmd.Parameters.AddWithValue("@cargo", parametros.Cargo);
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

        public void BuscarCargo(ref DataTable dt, string buscador)
        {
            try
            {
                DConexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarCargo", DConexion.Conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
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
