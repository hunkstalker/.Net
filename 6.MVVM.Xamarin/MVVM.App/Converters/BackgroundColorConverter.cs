using System.Globalization;
using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MVVM.App.Converters
{
	class BackgroundColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string tipo;
			Dictionary<string, Color> tiposColores = new Dictionary<string, Color>()
			{
				{"None", Color.FromHex("#F4F4F4")},
				{"Fuego", Color.FromHex("#FDCECE")},
				{"Agua", Color.FromHex("#ACE6F0")},
				{"Planta", Color.FromHex("#D6F0EA")},
				{"Eléctrico", Color.FromHex("#FFFFC0")},
				{"Psíquico", Color.FromHex("#8F8CB4")},
				{"Veneno", Color.FromHex("#E9BFE6")},
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
