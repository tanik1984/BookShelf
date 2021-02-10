using System.Collections.Generic;

namespace BookShelf.ViewModels
{
    public interface IMainWindowViewModel
    {
        IEnumerable<IBookViewModel> BookViewModels { get; }
    }
}