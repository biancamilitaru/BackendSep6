using System.Collections.Generic;
using System.Threading.Tasks;
using BackendSep6.Model;

namespace BackendSep6.DataAccess
{

    public interface ICommentDataAccess
    {
        public Task AddCommentAsync(Comment comment);
        public Task<IList<Comment>> GetAllCommentsAsync();

        public Task<IList<Comment>> GetComentsForMovieAsync(int movieId);

        public Task<Comment> GetCommentById(int commentId);
    }
}