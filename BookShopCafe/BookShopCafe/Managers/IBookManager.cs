namespace BookShopCafe.Managers
{
    using ModelLibrary;
    public interface IBookManager
    {
        List<Book> Get();
        Book Create(Book book);
        Book Update(int id, Book book);
        Book Delete(int id);
        Book GetById(int id);

       List<Book> GetByAuthor(string author);
        List<Book> SearchPrice(int? lowPrice, int? highPrice);

    }
}
