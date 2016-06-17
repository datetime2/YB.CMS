using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using DapperExtensions;

namespace YB.CMS.IRepositories
{
    /// <summary>
    /// 基础仓储
    /// </summary>
    /// <typeparam name="T">待操作对象</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 获取单个
        /// </summary>
        /// <param name="express">条件表达式</param>
        /// <returns></returns>
        T Find(Expression<Func<T, bool>> express);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Create(T model);
        /// <summary>
        /// 修改模型中指定字段 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Update(T model);
        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="predi">条件</param>
        /// <returns></returns>
        bool Remove(Expression<Func<T, bool>> predi);

        IEnumerable<T> GetPage(Expression<Func<T, bool>> predi, IList<ISort> sort, int page, int pagesize);

        IEnumerable<T> FindAll(PredicateGroup predi);
    }
}
