using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WetterApp
{
    public class BooleanToVisibilityReverseConverter : IValueConverter
    {
        //WetterEintrag.Aktualisiert -> Progressbar.Visibility
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool boolvalue)
            {
                return boolvalue == true ? Visibility.Collapsed : Visibility.Visible;
            }
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
