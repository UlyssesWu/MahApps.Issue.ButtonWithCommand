using System;
using System.Windows;
using System.Windows.Input;
using ControlzEx.Theming;

namespace MahAppsTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var vm = new MainViewModel();
            DataContext = vm;
            InitializeComponent();
            CharacterDataGrid.ItemsSource = vm.Data;
        }

        private void ThemeToggled(object sender, RoutedEventArgs e)
        {
            var theme = ThemeManager.Current.DetectTheme();
            if (theme != null)
            {
                ThemeManager.Current.ChangeTheme(Application.Current, ThemeManager.Current.GetInverseTheme(theme));
            }
        }

        private void QuickLoad(object sender, ExecutedRoutedEventArgs e)
        {
            this.Title = DateTime.Now.ToString("s");
        }
    }
}
