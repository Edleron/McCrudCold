using Cold.DataAccess.Abstract;
using Cold.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cold.DataAccess.Concrete
{
    public class BookRepository : IBookRepository
    {
        public Book CreateBook(Book book)
        {
            using (var bookDbContext = new BookDBContext())
            {
                bookDbContext.Books.Add(book);
                bookDbContext.SaveChanges();
                return book;
            }
        }

        public void DeleteBook(int id)
        {
            using (var bookDbContext = new BookDBContext())
            {
                var deletedBook = GetBookById(id);

                if (deletedBook != null)
                {
                    bookDbContext.Books.Remove(deletedBook);
                    bookDbContext.SaveChanges();
                }
            }
        }

        public List<Book> GetAllBooks()
        {
            using (var bookDbContext = new BookDBContext())
            {
                return bookDbContext.Books.ToList();
            }
        }

        public Book GetBookById(int id)
        {
            using (var bookDbContext = new BookDBContext())
            {
                return bookDbContext.Books.Find(id);
            }
        }

        public Book UpdateBook(Book book)
        {
            using (var bookDbContext = new BookDBContext())
            {
                bookDbContext.Books.Update(book);
                bookDbContext.SaveChanges();
                return book;
            }
        }
    }
}
