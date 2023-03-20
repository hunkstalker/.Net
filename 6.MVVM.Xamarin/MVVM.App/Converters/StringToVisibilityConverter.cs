using System;
using System.Globalization;
using Xamarin.Forms;

namespace MVVM.App.Converters
{
    public class StringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
			var inverse = (parameter as string)?.ToLower() == "inverse";
			var val = !string.IsNullOrEmpty((string)value);
			return inverse ? !val : val;
		}

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
