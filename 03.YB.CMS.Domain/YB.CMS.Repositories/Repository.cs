using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using YB.CMS.Infrastructure;
using YB.CMS.IRepositories;
using Dapper;
using DapperEx;
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
        public T Find(SqlQuery findsql)
        {
            return QueryDb<T>((context) =>
            {
                return context.SingleOrDefault<T>(findsql);
            });
        }
        public bool Remove(Expression<Func<T, bool>> predi)
        {
            return QueryDb<bool>((context) =>
            {
                return context.Delete<T>();
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
