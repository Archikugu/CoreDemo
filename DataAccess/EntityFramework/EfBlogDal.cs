using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(b => b.Category).ToList();
            }
        }
        public List<Blog> GetListWithComment()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(b => b.Comments).ToList();
            }
        }

    }
}
