using System.Globalization;
using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MVVM.App.Converters
{
	class TipoColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string tipo;
			Dictionary<string, Color> tiposColores = new Dictionary<string, Color>()
			{
				{"None", Color.FromHex("#BFC3CA")},
				{"Fuego", Color.FromHex("#FA5C5C")},
				{"Agua", Color.FromHex("#06B6D4")},
				{"Planta", Color.FromHex("#98CF80")},
				{"Eléctrico", Color.FromHex("#FFED85")},
				{"Psíquico", Color.FromHex("#8F8CB4")},
				{"Veneno", Color.FromHex("#BC89CC")},
				{"Volador", Color.FromHex("#ACE6F0")},
				//agregar más tipos y colores si es necesario
			};

			if (value == null) tipo = "None";
			else tipo = (string)value;

			Color color;
			if (tiposColores.TryGetValue(tipo, out color))
			{
				return color;
			}
			else
			{
				return Color.Default;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}