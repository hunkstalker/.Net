using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IntroduccionCsh.View
{
    public partial class personal : UserControl
    {
        public personal()
        {
            InitializeComponent();
        }

        private void btnAddClick(object sender, EventArgs e)
        {
            uiConfigurationInsertPersonal();
            clean();
        }

        private void uiConfigurationInsertPersonal()
        {
            panelCargos.Visible = false;
            panelPaginado.Visible = false;
            panelRegistros.Visible = true;
            panelRegistros.Dock = DockStyle.Fill;
            BtnSave.Visible = true;
            BtnSaveChanges.Visible = true;
        }

        private void clean()
        {
            tb_nombre_apellidos.Clear();
            tb_id.Clear();
            tb_job_title.Clear();
            tb_salary_per_hour.Clear();
        }
    }
}
