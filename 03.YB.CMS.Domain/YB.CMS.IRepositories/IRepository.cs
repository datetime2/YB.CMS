using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using DapperEx;
using YB.CMS.Models.Query;

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
        T Find(List<SqlWhereQuery<T>> query);
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
    }
}
