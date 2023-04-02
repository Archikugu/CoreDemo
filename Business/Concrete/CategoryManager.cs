using Business.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryDal _efCategoryDal;

        public CategoryManager(EfCategoryDal efCategoryDal)
        {
            _efCategoryDal = efCategoryDal;
        }

        public void TAdd(Category t)
        {
            _efCategoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _efCategoryDal.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return _efCategoryDal.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _efCategoryDal.GetListAll();
        }

        public void TUpdate(Category t)
        {
            _efCategoryDal.Update(t);
        }
    }
}
