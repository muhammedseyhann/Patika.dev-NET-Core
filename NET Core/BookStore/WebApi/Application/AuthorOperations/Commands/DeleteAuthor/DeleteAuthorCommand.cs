using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.DeleteAuthorCommand
{
    public class DeleteAuthorCommand
    {
        public int AuthorId { get; set; }
        public DeleteAuthorModel Model { get; set; }
        private readonly BookStoreDbContext _context;
        public DeleteAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
                throw new InvalidOperationException("Yazar Bulunamadı");

            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
    public class DeleteAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BornDate { get; set; }
    }
}