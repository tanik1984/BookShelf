using System.Windows;
using BookShelf.ViewModels;
using BookShelf.Views;

namespace BookShelf
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindowViewModel = new MainWindowViewModel();

            var mainWindow = new MainWindow(mainWindowViewModel);

            mainWindow.Show();

            MainWindow = mainWindow;
        }
    }
}