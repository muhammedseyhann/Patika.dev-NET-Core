using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.BookOperations.Commands.DeleteBookCommand
{
    public class DeleteBookCommand
    {
        public DeleteBookModel Model { get; set; }
        public int Id { get; set; }
        private readonly BookStoreDbContext _dbContext;
        public DeleteBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == Id);
            if (book is null)
                throw new InvalidOperationException("Silinecek Kitap Bulunamadı");

            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
    }

    public class DeleteBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
    }
}