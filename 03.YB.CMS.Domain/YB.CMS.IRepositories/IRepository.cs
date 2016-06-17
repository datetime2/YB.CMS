using System;
using System.Linq;
using System.Linq.Expressions;
namespace YB.CMS.IRepositories
{
    /// <summary>
    /// 基础仓储
    /// </summary>
    /// <typeparam name="T">待操作对象</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        IQueryable<T> FindAll(Expression<Func<T, bool>> express);
        /// <summary>
        /// 获取单个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Find(long id);
        /// <summary>
        /// 获取单个 根据条件表达式
        /// </summary>
        /// <param name="express">条件表达式</param>
        /// <returns></returns>
        T Find(Expression<Func<T, bool>> express);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        T Create(T model);
        /// <summary>
        /// 修改模型中指定字段 
        /// </summary>
        /// <param name="predi">条件表达式</param>
        /// <param name="filed">待修改的字段</param>
        /// <returns></returns>
        bool Update(Expression<Func<T, bool>> predi, Expression<Func<T, T>> filed);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        bool Remove(long id);
        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="predi">条件</param>
        /// <returns></returns>
        bool Remove(Expression<Func<T, bool>> predi);        
    }
}
