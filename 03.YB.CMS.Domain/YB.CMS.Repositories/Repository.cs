using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using YB.CMS.Infrastructure;
using YB.CMS.IRepositories;
using Dapper;
using DapperEx;
using YB.CMS.Models.Query;

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
        public T Find(List<SqlWhereQuery<T>> query)
        {
            return QueryDb<T>((context) =>
            {
                var d = SqlQuery<T>.Builder(context);
                if (query.Any())
                {
                    foreach(var item in query)
                    {
                        d.AndWhere(item.expr, item.operation, item.value);
                    }
                }
                return context.SingleOrDefault<T>(d);
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
