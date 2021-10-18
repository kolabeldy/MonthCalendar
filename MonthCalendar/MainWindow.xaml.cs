using MaterialDesignThemes.Wpf;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MonthCalendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FilterPanel FilterPanelContent { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            FilterPanelContent = new FilterPanel();
            DataContext = this;
        }
        private readonly PaletteHelper _paletteHelper = new PaletteHelper();
        public void SetLightDark(bool isDark)
        {
            ITheme theme = _paletteHelper.GetTheme();
            IBaseTheme baseTheme = isDark ? new MaterialDesignDarkTheme() : (IBaseTheme)new MaterialDesignLightTheme();
            theme.SetBaseTheme(baseTheme);
            _paletteHelper.SetTheme(theme);
        }

        private void ThemeToggle_Click(object sender, RoutedEventArgs e)
        {
            SetLightDark((bool)ThemeToggle.IsChecked);
        }

    }
}
