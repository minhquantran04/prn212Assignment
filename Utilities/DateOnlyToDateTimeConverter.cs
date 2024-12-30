using System;
using System.Globalization;
using System.Windows.Data;

namespace CE181985_Tran_Minh_Quan_Assignment_2.Converters
{
    public class DateOnlyToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateOnly dateOnly)
            {
                return (DateTime?)dateOnly.ToDateTime(TimeOnly.MinValue);
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateTime)
            {
                return (DateOnly?)DateOnly.FromDateTime(dateTime);
            }
            return null;
        }
    }
}
