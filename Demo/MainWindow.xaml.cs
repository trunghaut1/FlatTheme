using FlatTheme.ControlStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
