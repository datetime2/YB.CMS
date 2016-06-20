using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB.CMS.Utility.Log;
using DapperEx;

namespace YB.CMS.Infrastructure
{
    public class DbContext
    {
        public long total = 0;
        public static string connectionName = "YBCMS";
        public static DbBase CreateDbBase()
        {
            return new DbBase(connectionName);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        protected static void QueryDb(Action<DbBase> action)
        {
            using (var context = CreateDbBase())
            {
                try
                {
                    action(context);
                }
                catch (Exception ex)
                {
                    Log.Error("操作失败", ex);
                }
            }
        }
        /// <summary>
        /// 无返回值 使用事务 一般INSERT UPDATE 操作使用
        /// </summary>
        /// <param name="action"></param>
        protected static void QueryDbTran(Action<DbBase> action)
        {
            using (var context = CreateDbBase())
            {
                try
                {
                    action(context);
                    context.DbTransaction.Commit();
                }
                catch (Exception ex)
                {
                    context.DbTransaction.Rollback();
                    Log.Error("操作失败", ex);
                }
                finally
                {
                    context.DbTransaction.Dispose();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        protected static dynamic QueryDb<dynamic>(Func<DbBase, dynamic> func)
        {
            using (var context = CreateDbBase())
            {
                try
                {
                    var v = func(context);
                    return v;
                }
                catch (Exception ex)
                {
                    Log.Error("操作失败", ex);
                    return default(dynamic);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        protected static dynamic QueryDb(Func<DbBase, dynamic> func)
        {
            using (var context = CreateDbBase())
            {
                try
                {
                    var v = func(context);
                    return v;
                }
                catch (Exception ex)
                {
                    Log.Error("操作失败", ex);
                    return false;
                }
            }
        }
        /// <summary>
        /// 事务操作
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        protected static dynamic QueryDbTran(Func<DbBase, dynamic> func)
        {
            using (var context = CreateDbBase())
            {
                try
                {
                    var v = func(context);
                    context.DbTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Log.Error("操作失败", ex);
                    context.DbTransaction.Rollback();
                    return false;
                }
                finally
                {
                    context.DbTransaction.Dispose();
                }
            }
        }
    }
}
