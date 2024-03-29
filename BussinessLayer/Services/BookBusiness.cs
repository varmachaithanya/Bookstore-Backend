using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Interfaces;
using RepositoryLayer.Entity;
using RepositoryLayer.Interfaces;

namespace BussinessLayer.Services
{
    public class BookBusiness:IBookBusiness
    {
        private readonly IBookRepo bookRepo;

        public BookBusiness(IBookRepo bookRepo)
        {
            this.bookRepo = bookRepo;
        }

        public List<Book> GetAllBooks()
        {
            return bookRepo.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            return bookRepo.GetBookById(id);
        }

        public Book GetBookByTitle(string Title)
        {
            return bookRepo.GetBookByTitle(Title);
        }

        public Book GetBookByAuthor(string Author)
        {
            return bookRepo.GetBookByAuthor(Author);
        }

        public Book GetBookByTitleAndAuthor(string title, string author)
        {
            return bookRepo.GetBookByTitleAndAuthor(title, author);
        }








    }
}
