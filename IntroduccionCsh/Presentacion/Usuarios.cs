using IntroduccionCsh.Datos;
using IntroduccionCsh.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroduccionCsh.Presentacion
{
    public partial class Usuarios : Form
    {
        OpenFileDialog dlg = new OpenFileDialog();

        public Usuarios()
        {
            InitializeComponent();
            show_users();
        }

        private void show_users()
        {
            DataTable dt;
            dUsuarios function = new dUsuarios();
            dt = function.show_users();
            dg_data.DataSource = dt;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            pnl_info.Visible = true;
            btn_save.Visible = true;
            btn_saveChanges.Visible = false;
            tb_usuario.Clear();
            tb_pass.Clear();
        }

        private void pb_foto_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imágenes";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                pb_foto.BackgroundImage = null;
                pb_foto.Image = new Bitmap(dlg.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(tb_usuario.Text != "")
            {
                if(tb_pass.Text != "")
                {
                    save_user();
                    show_users();
                }
                else
                {
                    MessageBox.Show("Ingresa una contraseña", "Sin contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un nombre de usuario", "Sin usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void save_user()
        {
            lUsuarios dt = new lUsuarios();
            dUsuarios function = new dUsuarios();

            dt.User = tb_usuario.Text;
            dt.Pass = tb_pass.Text;
            dt.Status = "Active";

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pb_foto.Image.Save(ms, pb_foto.Image.RawFormat);
            dt.Icon = ms.GetBuffer();
            if (function.insert_users(dt))
            {
                MessageBox.Show("Usuario registrado", "Registro correcto", MessageBoxButtons.OK);
                pnl_info.Visible = false;
            }
        }
    }
}
