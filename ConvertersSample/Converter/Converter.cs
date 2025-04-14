using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertersSample
{
    public class StringToDateTimeConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return DateTime.Now;
            }
            else
            {
                DateTime dateTime;
                DateTime.TryParse((string)value, out dateTime);
                return dateTime;
            }
        }
        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value?.ToString() ?? string.Empty; 
        }
    }
}
