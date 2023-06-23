using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Hangman.WpfApp.Converters;

internal class LetterToBorderThicknessConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => value as char? == ' ' ? new Thickness(0, 0, 0, 0) : (object)new Thickness(0, 0, 0, 2);

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}