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
    public class NewsletterManager : INewsletterService
    {
        INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void TAdd(Newsletter t)
        {
            _newsletterDal.Insert(t);
        }

        public void TDelete(Newsletter t)
        {
            _newsletterDal.Delete(t);
        }

        public List<Newsletter> TGetByFilter(Expression<Func<Newsletter, bool>> filter)
        {
            return _newsletterDal.GetListAll(filter);
        }

        public Newsletter TGetByID(int id)
        {
            return _newsletterDal.GetById(id);
        }

        public List<Newsletter> TGetList()
        {
            return _newsletterDal.GetListAll();
        }

        public void TUpdate(Newsletter t)
        {
            _newsletterDal.Update(t);
        }
    }
}
