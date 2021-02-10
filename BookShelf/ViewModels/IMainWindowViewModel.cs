using System.Collections.ObjectModel;

namespace BookShelf.ViewModels
{
    public interface IMainWindowViewModel
    {
        ObservableCollection<IBookViewModel> Books { get; }
        IBookViewModel SelectedBook { get; set; }

        RelayCommand DeleteButtonCommand { get; }
        RelayCommand EditButtonCommand { get; }
    }
}