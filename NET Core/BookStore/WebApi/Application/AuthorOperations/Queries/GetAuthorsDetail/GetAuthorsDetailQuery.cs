using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.GetAuthorDetailQuery
{
    public class GetAuthorDetailQuery
    {
        public int AuthorId { get; set; }
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorDetailQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GetAuthorDetailViewModel Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
                throw new InvalidOperationException("Yazar Bulunamadı");

            GetAuthorDetailViewModel viewModel = _mapper.Map<GetAuthorDetailViewModel>(author);
            return viewModel;
        }
    }

    public class GetAuthorDetailViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BornDate { get; set; }
    }
}