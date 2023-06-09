﻿using Business.Abstract;
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
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}
		public List<Blog> GetBlogListWithWriter(int id)
		{
			return _blogDal.GetListAll(x => x.WriterId == id);
		}

		public void TAdd(Blog t)
		{
			_blogDal.Insert(t);
		}

		public void TDelete(Blog t)
		{
			_blogDal.Delete(t);
		}

		public List<Blog> TGetByFilter(Expression<Func<Blog, bool>> filter)
		{
			return _blogDal.GetListAll(filter);
		}

		public Blog TGetByID(int id)
		{
			return _blogDal.GetById(id);
		}

		public List<Blog> TGetList()
		{
			return _blogDal.GetListAll();
		}

		public void TUpdate(Blog t)
		{
			_blogDal.Update(t);
		}
	}
}
