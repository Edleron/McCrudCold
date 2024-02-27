using Cold.Business.Abstract;
using Cold.DataAccess.Abstract;
using Cold.DataAccess.Concrete;
using Cold.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cold.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book CreateBook(Book book)
        {
            return _bookRepository.CreateBook(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }

        public List<Book> GetAllBooks()
        {
           return _bookRepository.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            if (id > 0)
            {
                return _bookRepository.GetBookById(id);
            }

            throw new Exception("id con not be less than 1");
        }

        public Book UpdateBook(Book book)
        {
           return (_bookRepository.UpdateBook(book));
        }
    }
}
