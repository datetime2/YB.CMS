using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using YB.CMS.Infrastructure;
using YB.CMS.IRepositories;
using Dapper;
using DapperExtensions;
namespace YB.CMS.Repositories
{
    /// <summary>
    /// 基础仓储
    /// </summary>
    public abstract class Repository<T> : DbContext, IRepository<T> where T : class
    {
        public bool Create(T model)
        {
            return QueryDb<bool>((context) =>
            {
                return context.Insert(model);
            });
        }
        public T Find(Expression<Func<T, bool>> express)
        {
            return QueryDb<T>((context) =>
            {
                return context.GetList<T>(express).FirstOrDefault();
            });
        }

        public IEnumerable<T> FindAll(PredicateGroup predi)
        {
            return QueryDb<IEnumerable<T>>((context) =>
            {
                return context.GetList<T>(predi);
            });
        }
        public IEnumerable<T> GetPage(Expression<Func<T, bool>> predi, IList<ISort> sort, int page, int pagesize)
        {
            return QueryDb<IEnumerable<T>>((context) =>
            {
                return context.GetPage<T>(predi, sort, page, pagesize);
            });
        }
        public bool Remove(Expression<Func<T, bool>> predi)
        {
            return QueryDb<bool>((context) =>
            {
                return context.Delete(predi);
            });
        }
        public bool Update(T model)
        {
            return QueryDb<bool>((context) =>
            {
                return context.Update<T>(model);
            });
        }
    }
}
