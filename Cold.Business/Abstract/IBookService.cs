using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cold.Entities;

namespace Cold.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAllBooks();

        Book GetBookById(int id);

        Book CreateBook(Book book);

        Book UpdateBook(Book book);

        void DeleteBook(int id);
    }
}
