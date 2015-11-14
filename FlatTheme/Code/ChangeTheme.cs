using System;
using System.Windows;

namespace FlatTheme.Code
{
    public class ChangeTheme
    {
        private static void ChangeThemes(Uri uri) // Hàm load lại style 
        {
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries[0].Clear();
            Application.Current.Resources.MergedDictionaries[0].MergedDictionaries.Add(resourceDict);
        }
        public static void Change(string theme)
        {
            string style = "/FlatTheme;component/ColorStyle/" + theme + ".xaml";
            ChangeThemes(new Uri(style, UriKind.Relative));
        }
    }
}
