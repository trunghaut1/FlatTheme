﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace FlatTheme.Code
{
    public enum MathOperation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public sealed class MathConverter : IValueConverter
    {
        public MathOperation Operation { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double value1, value2;
            if (Double.TryParse(value.ToString(), out value1) && Double.TryParse(parameter.ToString(), out value2))
            {
                switch (Operation)
                {
                    default:
                    case MathOperation.Add:
                        return value1 + value2;
                    case MathOperation.Divide:
                        return value1 / value2;
                    case MathOperation.Multiply:
                        return value1 * value2;
                    case MathOperation.Subtract:
                        return value1 - value2;
                }
            }

            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
