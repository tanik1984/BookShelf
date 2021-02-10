using System.Collections.ObjectModel;

namespace BookShelf.ViewModels
{
    public class MainWindowViewModel : BaseViewModel, IMainWindowViewModel
    {
        private IBookViewModel _selectedBookViewModel;

        public MainWindowViewModel()
        {
            Books = new ObservableCollection<IBookViewModel>
            {
                new BookViewModel
                {
                    Name = "kolobok",
                    Author = "ded moroz",
                    CreatedAt = "01.01.1900",
                    Genre = "thriller"
                },
                new BookViewModel
                {
                    Name = "petushok",
                    Author = "narod",
                    CreatedAt = "02.01.1800",
                    Genre = "skazka"
                }
            };

            DeleteButtonCommand = new RelayCommand(DeleteBook, CanModifySelectedBook);
            EditButtonCommand = new RelayCommand(EditBook, CanModifySelectedBook);
        }

        public ObservableCollection<IBookViewModel> Books { get; }

        public IBookViewModel SelectedBook
        {
            get => _selectedBookViewModel;
            set
            {
                _selectedBookViewModel = value;

                DeleteButtonCommand.RaiseCanExecuteChanged();
                EditButtonCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand DeleteButtonCommand { get; }
        public RelayCommand EditButtonCommand { get; }

        private void EditBook(object obj)
        {
        }

        private bool CanModifySelectedBook(object arg)
        {
            return SelectedBook != null;
        }

        private void DeleteBook(object obj)
        {
            Books.Remove(SelectedBook);
        }
    }
}