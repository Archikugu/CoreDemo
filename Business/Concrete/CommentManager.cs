using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }



        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public List<Comment> TGetByFilter(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.GetListAll(filter);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetListAll();
        }
        public List<Comment> GetList(int id)
        {
            return _commentDal.GetListAll(x => x.BlogId == id);
        }
        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
