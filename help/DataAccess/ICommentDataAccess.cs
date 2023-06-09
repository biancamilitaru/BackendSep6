using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{

    public interface ICommentDataAccess
    {
        public Task AddCommentAsync(Comment comment);
        public Task<IList<Comment>> GetAllCommentsAsync();

        public Task<IList<Comment>> GetComentsForMovieAsync(int movieId);

        public Task<Comment> GetCommentById(int commentId);
    }
}