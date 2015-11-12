using System.Windows;
using System.Windows.Controls;

namespace FlatTheme.Code
{
    public class Underline : Control
    {
        static Underline()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Underline), new FrameworkPropertyMetadata(typeof(Underline)));
        }

        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register(
            "IsActive", typeof(bool), typeof(Underline),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
    }
}