namespace BookShelf.ViewModels
{
    public class BookViewModel : BaseViewModel, IBookViewModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string CreatedAt { get; set; }
        public string Author { get; set; }
    }
}