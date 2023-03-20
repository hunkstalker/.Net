using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using IntroduccionCsh.Logica;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace IntroduccionCsh.Datos
{
    internal class dUsuarios
    {
        private SqlCommand cmd = new SqlCommand();

        public bool insert_users(lUsuarios dt)
        {
            try
            {
                dConnection.Open();
                cmd = new SqlCommand("insert_users", dConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                // Alternativa
                //cmd = new SqlCommand("insert_users", dConnection.connection)
                //{
                //    CommandType = CommandType.StoredProcedure
                //};

                cmd.Parameters.AddWithValue("@User", dt.User);
                cmd.Parameters.AddWithValue("@Pass", dt.Pass);
                cmd.Parameters.AddWithValue("@Icon", dt.Icon);
                cmd.Parameters.AddWithValue("@Status", dt.Status);
                return (cmd.ExecuteNonQuery() != 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                dConnection.Close();
            }
        }

        public bool edit_users(lUsuarios dt)
        {
            try
            {
                dConnection.Open();
                cmd = new SqlCommand("edit_users", dConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", dt.Id);
                cmd.Parameters.AddWithValue("@User", dt.User);
                cmd.Parameters.AddWithValue("@Pass", dt.Pass);
                cmd.Parameters.AddWithValue("@Icon", dt.Icon);
                cmd.Parameters.AddWithValue("@Status", dt.Status);
                return (cmd.ExecuteNonQuery() != 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                dConnection.Close();
            }
        }

        public bool delete_users(lUsuarios dt)
        {
            try
            {
                dConnection.Open();
                cmd = new SqlCommand("delete_users", dConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", dt.Id);
                return (cmd.ExecuteNonQuery() != 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                dConnection.Close();
            }
        }

        public DataTable show_users()
        {
            try
            {
                dConnection.Open();
                cmd = new SqlCommand("show_users", dConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;

                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                dConnection.Close();
            }
        }

        public DataTable search_users(string param)
        {
            try
            {
                dConnection.Open();
                cmd = new SqlCommand("search_users", dConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@search", param);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                dConnection.Close();
            }
        }
    }
}
