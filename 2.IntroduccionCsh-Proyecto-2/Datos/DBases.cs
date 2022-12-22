using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace IntroduccionCsh.Datos
{
    public class DBases
    {
        public static void DisDTV(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.Red;
        }

        public static object Decimales(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0 || e.KeyChar == ',' && (~CajaTexto.Text.IndexOf(",")) != 0)
            {
                e.Handled = true;
            }
            else if(e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if(e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return null;
        }
    }
}
