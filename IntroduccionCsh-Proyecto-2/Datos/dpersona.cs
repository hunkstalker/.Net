using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IntroduccionCsh.Datos
{
    public class DPersona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Pais { get; set; }
        public int IdCargo { get; set; }
        public double SueldoPorHora { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }
    }

    //TODO: Habría que hacer una función que controle el set y pase de texto a double o devolver error.
}
