using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IntroduccionCsh.Datos
{
    public class dpersona
    {
        public int Id_persona { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Pais { get; set; }
        public int Id_cargo { get; set; }
        public double SueldoPorHora { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }
    }
}
