using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.MAUI.Converters
{
	public class CodeToWeatherConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var code = (int)value;
			switch (code)
			{
				case 0:
					return "Cielo despejado";
				case 1:
					return "Mayor. despejado";
				case 2:
					return "Parcial. nublado";
				case 3:
					return "Nublado";
				case 45:
					return "Niebla";
				case 48:
					return "Niebla hel. depositada";
				case 51:
					return "Llovizna: Ligera";
				case 53:
					return "Llovizna: Moderada";
				case 55:
					return "Llovizna: Int. densa";
				case 56:
					return "Llovizna, helada: Ligera";
				case 57:
					return "Llov., hel.: Int. densa";
				case 61:
					return "Lluvia: Ligera";
				case 63:
					return "Lluvia: Moderada";
				case 65:
					return "Lluvia: Int. fuerte";
				case 66:
					return "Lluvia, hel.: Ligera";
				case 67:
					return "Lluvia, hel.: Int. fuer.";
				case 71:
					return "Nieve: Ligera";
				case 73:
					return "Nieve: Moderada";
				case 75:
					return "Nieve: Int. fuerte";
				case 77:
					return "Granos de nieve";
				case 80:
					return "Chub. de lluvia: Lig.";
				case 81:
					return "Chub. de lluvia: Mod.";
				case 82:
					return "Chub. de lluvia: Violentos";
				case 85:
					return "Chub. de nieve: Lig.";
				case 86:
					return "Chub. de nieve: Fuer.";
				case 95:
					return "Tormenta: Lig./mod.";
				case 96:
					return "Torm.: Lig./mod. con granizo";
				case 97:
					return "Tormenta: Int. fuerte";
				case 98:
					return "Tormenta: Sucia";
				case 99:
					return "Torm.: Int. fuer. granizo";
				default:
					return "Desconocido";
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
