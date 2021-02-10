using System.Collections.Generic;

namespace BookShelf.ViewModels
{
    public class MainWindowViewModel : BaseViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel()
        {
            BookViewModels = new List<IBookViewModel>
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
        }

        public IEnumerable<IBookViewModel> BookViewModels { get; }
    }
}