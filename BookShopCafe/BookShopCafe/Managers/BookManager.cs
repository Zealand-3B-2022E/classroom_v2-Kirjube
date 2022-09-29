using ModelLibrary;
using System.Net;

namespace BookShopCafe.Managers
{
    public class BookManager: IBookManager
    {
        private static List<Book> _books = new List<Book>() { new Book { Id = 1, Titel = "The House In The Cerulean Sea", Author = "T.J Klune", Genre = "Feel-Good", Publisher = "Gyldendal", Resume = "A casworker visits a children's home", Price = 250 },
       new Book { Id = 2, Titel = "All the Young Dudes: Book 1: Year 1-4", Author = "Unknown", Genre = "Feel-BAD", Publisher = "AO3", Resume = "Marauders era ", Price = 176 } };
        public Book Create(Book book)
        {
            _books.Add(book);
            return book;
        }

        public Book Delete(int id)
        {
            Book _deleteBook = GetById(id);
            _books.Remove(_deleteBook);
            return _deleteBook;
        }

        public Book Update(int id, Book book)
        {
            Book _updateBook = GetById(id);

        if(_updateBook is not null)
            {
                _updateBook.Titel = book.Titel;
                _updateBook.Author = book.Author;
                _updateBook.Publisher = book.Publisher;
                _updateBook.Price = book.Price;
                _updateBook.Genre = book.Genre;
                _updateBook.Resume = book.Resume;   
            }

            return _updateBook;
        }

        public List<Book> Get()
        {

            return _books;
        }

        public Book GetById(int id)
        {
            return _books.Find(b => b.Id == id);
        }
        public List<Book> GetByAuthor(string author)
        {
            List<Book> _booksAuthor = new List<Book>();
            foreach( Book book in _books)
            {
                if(book.Author == author)
                {
                    _booksAuthor.Add(book);
                }
            }
            return _booksAuthor;
        }

        public List<Book> SearchPrice(int? lowPrice, int? highPrice)
        {
            //Finde aller biler efter lowPrice
            List<Book> tempBooks = (lowPrice is null) ? _books : _books.Where(b => b.Price >= lowPrice).ToList();
            //Finder alle biler før highPrice
            return (highPrice is null) ? tempBooks : tempBooks.Where(b => b.Price <= highPrice).ToList();
        }
    }
}
