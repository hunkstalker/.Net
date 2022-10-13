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
            PanelCargos.Visible = false;
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
            TbJobTitle.Clear();
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
            if (!string.IsNullOrEmpty(TbJobTitleG.Text))
            {
                if (!string.IsNullOrEmpty(TbSalaryPerHourG.Text))
                {
                    DCargos parametros = new DCargos();
                    NCargos function = new NCargos();
                    parametros.Cargo = TbJobTitleG.Text;
                    parametros.SueldoPorHora = Convert.ToDouble(TbSalaryPerHourG.Text);
                    if (function.InsertarCargo(parametros) == true)
                    {
                        TbJobTitle.Clear();
                        BuscarCargos();
                        PanelCargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo salario no puede estar vacío", "Puto Josemon!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El campo cargo no puede estar vacío", "Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarCargos()
        {
            DataTable dt = new DataTable();
            NCargos function = new NCargos();
            function.BuscarCargo(ref dt, TbJobTitle.Text);
            data_list_cargos.DataSource = dt;
            DBases.DisDTV(ref data_list_cargos);
        }

        private void TbJobTitle_TextChanged(object sender, EventArgs e)
        {
            BuscarCargos();
        }

        private void BtnAddJobTitle_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
            BtnSaveCargo.Visible = true;
            BtnSaveChangesCargo.Visible = false;
            TbJobTitleG.Clear();
            TbSalaryPerHourG.Clear();
        }

        private void BtnSaveCargo_Click(object sender, EventArgs e)
        {
            InsertarCargos();
        }

        private void TbSalaryPerHourG_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBases.Decimales(TbSalaryPerHourG, e);
        }
    }
}
