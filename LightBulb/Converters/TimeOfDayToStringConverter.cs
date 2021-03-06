﻿using System;
using System.Globalization;
using System.Windows.Data;
using LightBulb.Core;

namespace LightBulb.Converters
{
    [ValueConversion(typeof(TimeOfDay), typeof(string))]
    public class TimeOfDayToStringConverter : IValueConverter
    {
        public static TimeOfDayToStringConverter Instance { get; } = new();

        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            value is TimeOfDay timeOfDay
                ? timeOfDay.ToString(null, culture)
                : default;

        public object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            value is string stringValue
                ? TimeOfDay.TryParse(stringValue, culture)
                : default(TimeOfDay);
    }
}