using BookShelf.ViewModels;

namespace BookShelf.Views
{
    public partial class MainWindow
    {
        public MainWindow(IMainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();

            DataContext = mainWindowViewModel;
        }
    }
}