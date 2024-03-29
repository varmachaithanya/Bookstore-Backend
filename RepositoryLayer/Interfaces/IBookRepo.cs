using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interfaces
{
    public interface IBookRepo
    {
        public List<Book> GetAllBooks();

        public Book GetBookById(int id);

        public Book GetBookByTitle(string Title);

        public Book GetBookByAuthor(string Author);

        public Book GetBookByTitleAndAuthor(string title, string author);




    }
}
