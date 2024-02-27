using Cold.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cold.DataAccess.Abstract
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();

        Book GetBookById(int id);

        Book CreateBook(Book book);

        Book UpdateBook(Book book);

        void DeleteBook(int id);
    }
}
