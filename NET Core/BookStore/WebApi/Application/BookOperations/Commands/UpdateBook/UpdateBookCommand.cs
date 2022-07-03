using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.BookOperations.Commands.UpdateBookCommand

{
    public class UpdateBookCommand
    {
        public UpdateBookModel Model { get; set; }
        public int Id { get; set; }
        private readonly BookStoreDbContext _dbContext;
        public UpdateBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == Id);
            if (book is null)
                throw new InvalidOperationException("Güncellenecek Kitap Bulunamadı");

            book.GenreId = Model.GenreId != default ? Model.GenreId : book.GenreId;
            book.Title = Model.Title != default ? Model.Title : book.Title;

            _dbContext.SaveChanges();
        }
    }

    public class UpdateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
    }
}