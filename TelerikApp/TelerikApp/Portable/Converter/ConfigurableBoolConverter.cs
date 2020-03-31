using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TelerikApp.Portable.Converter
{
    class ConfigurableBoolConverter<T> : IValueConverter
    {
        public ConfigurableBoolConverter() { }

        public ConfigurableBoolConverter(T trueResult, T falseResult)
        {
            TrueResult = trueResult;
            FalseResult = falseResult;
        }

        public T TrueResult { get; set; }
        public T FalseResult { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (TrueResult == null || FalseResult == null)
                return !(bool)value;

            return value is bool b && b ? TrueResult : FalseResult;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (TrueResult == null || FalseResult == null)
                return !(bool)value;

            return value is T variable && EqualityComparer<T>.Default.Equals(variable, TrueResult);
        }
    }
}
