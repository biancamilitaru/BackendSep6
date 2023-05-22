using System.Collections.Generic;
using System.Threading.Tasks;
using BackendSep6.Model;

namespace BackendSep6.DataAccess
{
    public interface ITopListMovieDataAccess
    {
        public Task AddTopListMoviesAsyncList(TopList topList, List<Movie> movies);
        public Task DeleteTopListMovieByIdAsync(int id);
        
        public Task<IList<Movie>> GetMoviesForATopList(int topListID);
    }
}