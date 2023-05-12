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
					return "Mayormente despejado";
				case 2:
					return "Parcialmente nublado";
				case 3:
					return "Nublado";
				case 45:
					return "Niebla";
				case 48:
					return "Niebla helada depositada";
				case 51:
					return "Llovizna: Ligera";
				case 53:
					return "Llovizna: Moderada";
				case 55:
					return "Llovizna: Intensidad densa";
				case 56:
					return "Llovizna, helada: Ligera";
				case 57:
					return "Llovizna, helada: Intensidad densa";
				case 61:
					return "Lluvia: Ligera";
				case 63:
					return "Lluvia: Moderada";
				case 65:
					return "Lluvia: Intensidad fuerte";
				case 66:
					return "Lluvia, helada: Ligera";
				case 67:
					return "Lluvia, helada: Intensidad fuerte";
				case 71:
					return "Nieve: Ligera";
				case 73:
					return "Nieve: Moderada";
				case 75:
					return "Nieve: Intensidad fuerte";
				case 77:
					return "Granos de nieve";
				case 80:
					return "Chubascos de lluvia: Ligeros";
				case 81:
					return "Chubascos de lluvia: Moderados";
				case 82:
					return "Chubascos de lluvia: Violentos";
				case 85:
					return "Chubascos de nieve: Ligeros";
				case 86:
					return "Chubascos de nieve: Fuertes";
				case 95:
					return "Tormenta: Ligera o moderada";
				case 96:
					return "Tormenta: Ligera o moderada con granizo";
				case 97:
					return "Tormenta: Intensidad fuerte";
				case 98:
					return "Tormenta: Sucia";
				case 99:
					return "Tormenta: Intensidad fuerte con granizo";
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
