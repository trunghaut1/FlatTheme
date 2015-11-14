using FlatTheme.Code;
using FlatTheme.ControlStyle;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FlatWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            List<SV> l = new List<SV>()
            {
                new SV(false,"Trần Trung Hậu","DCT1121","Quận 5"),
                new SV(false,"Nguyễn Hoài Nam","DCT1121","Quận 5"),
                new SV(false,"Nguyễn Thanh Nam","DCT1122","TP.HCM"),
                new SV(true,"Đỗ Minh Tiến","SGU","TP.HCM")
            };
            dataGrid.ItemsSource = l;
        }

        private void Toggle_Checked(object sender, RoutedEventArgs e)
        {
            // Gọi hàm đổi style từ /FlatTheme.Code (sử dụng class ChangeTheme)
            // Tên theme là tên file theme trong thư mục /FlatTheme/ColorStyle
            ChangeTheme.Change("MaterialDark");
        }

        private void Toggle_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeTheme.Change("MaterialLight");
        }
    }
    public class SV
    {
        public string Ten { get; set; }
        public bool VienChuc { get; set; }
        public string Lop { get; set; }
        public string DiaChi { get; set; }
        
        public SV(bool v, string t, string l, string d)
        {
            VienChuc = v;
            Ten = t;
            Lop = l;
            DiaChi = d;
        }
    }
}
