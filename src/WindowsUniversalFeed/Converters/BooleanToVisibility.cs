using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace WindowsUniversalFeed.Converters
{
	public class BooleanToVisibility : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			return value != null && (bool)value ? Visibility.Visible : Visibility.Collapsed;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
