using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.Queries.GetGenresDetailQuery
{
    public class GetGenresDetailQuery
    {
        public int GenreId { get; set; }
        private readonly BookStoreDbContext _dbcontext;
        private readonly IMapper _mapper;
        public GetGenresDetailQuery(BookStoreDbContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        public GenreDetailViewModel Handle()
        {
            var genres = _dbcontext.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenreId);
            if (genres is null)
                throw new InvalidOperationException("Kitap Türü Bulunamadı");
            GenreDetailViewModel returnObj = _mapper.Map<GenreDetailViewModel>(genres);
            return returnObj;
        }
    }

    public class GenreDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}