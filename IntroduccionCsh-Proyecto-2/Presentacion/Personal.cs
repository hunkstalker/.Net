using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntroduccionCsh.Datos;
using IntroduccionCsh.Negocio;

namespace IntroduccionCsh.View
{
    public partial class personal : UserControl
    {
        public personal()
        {
            InitializeComponent();
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            UIConfigurationInsertPersonal();
            Clean(); 
        }

        private void UIConfigurationInsertPersonal()
        {
            panelCargos.Visible = false;
            panelPaginado.Visible = false;
            panelRegistros.Visible = true;
            panelRegistros.Dock = DockStyle.Fill;
            BtnSave.Visible = true;
            BtnSaveChanges.Visible = true;
        }

        private void Clean()
        {
            tb_nombre_apellidos.Clear();
            tb_id.Clear();
            tb_job_title.Clear();
            tb_salary_per_hour.Clear();
            BuscarCargos();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void InsertarPersonal()
        {
            DPersona parametros = new DPersona();
            NPersona function = new NPersona();
            parametros.Nombre = tb_nombre_apellidos.Text;
            parametros.Identificacion = tb_id.Text;
            parametros.Pais = cb_country.Text;
            parametros.SueldoPorHora = Convert.ToDouble(tb_salary_per_hour);
        }

        private void InsertarCargos()
        {
            DCargos parametros = new DCargos();
            NCargos function = new NCargos();
            parametros.Cargo = tb_job_titleG.Text;
            parametros.SueldoPorHora = Convert.ToDouble(tb_salary_per_hourG);
            if (function.InsertarCargo(parametros) == true)
            {
                BuscarCargos();
            }
        }

        private void BuscarCargos()
        {
            DataTable dt = new DataTable();
            NCargos function = new NCargos();
            function.BuscarCargo(ref dt, tb_job_title.Text);
            data_list_cargos.DataSource = dt;
            DBases.DisDTV(ref data_list_cargos);
        }

        private void tb_job_title_TextChanged(object sender, EventArgs e)
        {
            BuscarCargos();
        }

        private void btn_add_job_title_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
            BtnSaveCargo.Visible = true;
            BtnSaveChangesCargo.Visible = false;
        }
    }
}
