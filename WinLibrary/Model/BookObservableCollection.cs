using System.Collections.ObjectModel;
using System.Data.Entity;
using WinLibrary.DAL;

namespace WinLibrary.Model
{
    public class BookObservableCollection : ObservableCollection<Book>
    {
        public BookObservableCollection(DbSet<Book> booksList)
        {
            BooksCollection = new ObservableCollection<Book>(booksList);
        }

        public ObservableCollection<Book> BooksCollection { get; set; }

        public void Add(Book testBook)
        {
            BooksCollection.Add(testBook);
            BookDal.SaveBook(testBook);
        }
    }
}