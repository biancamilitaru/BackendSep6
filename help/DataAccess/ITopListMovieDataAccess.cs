using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface ITopListMovieDataAccess
    {
        public Task AddTopListMoviesAsyncList(TopList topList, List<Movie> movies);
        public Task DeleteTopListMovieByIdAsync(int id);
        
        public Task<IList<Movie>> GetMoviesForATopList(int topListID);
    }
}