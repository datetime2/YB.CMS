using System;
using System.Linq;
using System.Linq.Expressions;
using YB.CMS.Dapper;
using YB.CMS.IRepositories;
using DapperExtensions;
namespace YB.CMS.Repositories
{
    /// <summary>
    /// 基础仓储
    /// </summary>
    public abstract class Repository<T> : BaseRepository, IRepository<T> where T : class
    {
        public T Create(T model)
        {
            string sql = string.Empty;
            return InvokeDB<T>((context, s) =>
            {
                return (T)context.Query<T>(s);
            }, sql);
        }

        public T Find(Expression<Func<T, bool>> express)
        {
            string sql = string.Empty;
            return InvokeDB<T>((context, s) =>
            {
                return (T)context.Query<T>(s);
            }, sql);
        }

        public T Find(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> express)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Expression<Func<T, bool>> predi)
        {
            throw new NotImplementedException();
        }

        public bool Remove(long id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Expression<Func<T, bool>> predi, Expression<Func<T, T>> filed)
        {
            throw new NotImplementedException();
        }
    }
}
