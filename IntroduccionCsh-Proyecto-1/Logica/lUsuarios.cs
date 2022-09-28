using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroduccionCsh.Logica
{
    internal class lUsuarios
    {
        private int id { get; set; }
        private string user { get; set; }
        private string pass { get; set; }
        private byte[] icon { get; set; }
        private string status { get; set; }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string User
        {
            get => user;
            set => user = value;
        }

        public string Pass
        {
            get => pass;
            set => pass = value;
        }

        public byte[] Icon
        {
            get => icon;
            set => icon = value;
        }

        public string Status
        {
            get => status;
            set => status = value;
        }

        public lUsuarios()
        {

        }

        public lUsuarios(int id, string user, string pass, byte[] icon, string status)
        {
            Id = id;
            User = user;
            Pass = pass;
            Icon = icon;
            Status = status;
        }
    }
}
