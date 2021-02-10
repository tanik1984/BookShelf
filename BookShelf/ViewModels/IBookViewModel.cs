namespace BookShelf.ViewModels
{
    public interface IBookViewModel
    {
        string Name { get; }
        string Genre { get; }
        string CreatedAt { get; }
        string Author { get; }
    }
}