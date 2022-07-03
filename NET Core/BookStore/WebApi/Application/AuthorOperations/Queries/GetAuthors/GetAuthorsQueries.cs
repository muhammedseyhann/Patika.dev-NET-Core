using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.GetAuthorsQueries
{
    public class GetAuthorsQueries
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorsQueries(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GetAuthorsViewModel> Handle()
        {
            var bookList = _context.Authors.OrderBy(x => x.Id);
            List<GetAuthorsViewModel> vm = _mapper.Map<List<GetAuthorsViewModel>>(bookList);
            return vm;
        }
    }
    public class GetAuthorsViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BornDate { get; set; }
    }
}