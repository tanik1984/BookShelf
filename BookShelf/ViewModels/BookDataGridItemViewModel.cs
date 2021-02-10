namespace BookShelf.ViewModels
{
    public class BookDataGridItemViewModel : BaseViewModel
    {
        public string Name { get; }
        public string Genre { get; }
        public string CreatedAt { get; }
        public string Author { get; }
    }
}