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

        private void comboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            switch(comboBox.SelectedIndex)
            {
                case 0: ChangeTheme.Change("MaterialLight"); break;
                case 1: ChangeTheme.Change("MaterialDark"); break;
                case 2: ChangeTheme.Change("BlueLight"); break;
                case 3: ChangeTheme.Change("BlueDark"); break;
                case 4: ChangeTheme.Change("PinkLight"); break;
                case 5: ChangeTheme.Change("PinkDark"); break;
                case 6: ChangeTheme.Change("RedLight"); break;
                case 7: ChangeTheme.Change("RedDark"); break;
                case 8: ChangeTheme.Change("PurpleLight"); break;
                case 9: ChangeTheme.Change("PurpleDark"); break;
                case 10: ChangeTheme.Change("GreenLight"); break;
                case 11: ChangeTheme.Change("GreenDark"); break;
                case 12: ChangeTheme.Change("OrangeLight"); break;
                case 13: ChangeTheme.Change("OrangeDark"); break;
                case 14: ChangeTheme.Change("BlueGrey"); break;
            }
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
