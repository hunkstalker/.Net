using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinCmps.App.Converters
{
	public class InverseBooleanConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool originalValue)
			{
				return !originalValue;
			}

			throw new ArgumentException("Unable to convert non-boolean value.");
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool invertedValue)
			{
				return !invertedValue;
			}

			throw new ArgumentException("Unable to convert non-boolean value.");
		}
	}

}
