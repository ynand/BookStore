using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="Dinosaurs", Author="Ross"},
                new BookModel(){Id=2,Title="Fashion", Author="Rachel"},
                new BookModel(){Id=3,Title="Data Processing", Author="Chandler"},
                new BookModel(){Id=4,Title="Food", Author="Monika"},
                new BookModel(){Id=5,Title="Acting", Author="Joey"},
                new BookModel(){Id=6,Title="Massage", Author="Phoebe"},
                new BookModel(){Id=7,Title="Dinosaurs", Author="Ross"}
            };
        }
    }
}
