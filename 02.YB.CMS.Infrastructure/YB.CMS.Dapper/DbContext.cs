using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using YB.CMS.Utility.Log;

namespace YB.CMS.Infrastructure
{
    public class DbContext
    {
        private static readonly string Connecstring =
            ConfigurationManager.ConnectionStrings["YBCMS"].ConnectionString;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        protected static void QueryDb(Action<IDbConnection> action)
        {
            using (var context = new MySqlConnection(Connecstring))
            {
                try
                {
                    context.Open();
                    action(context);
                    context.Close();
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
        protected static void QueryDbTran(Action<IDbConnection> action)
        {
            using (var context = new MySqlConnection(Connecstring))
            {
                context.Open();
                var tran = context.BeginTransaction();
                try
                {
                    action(context);
                    tran.Commit();
                    context.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Log.Error("操作失败", ex);
                }
                finally
                {
                    tran.Dispose();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        protected static dynamic QueryDb<dynamic>(Func<IDbConnection, dynamic> func)
        {
            using (var context = new MySqlConnection(Connecstring))
            {
                try
                {
                    context.Open();
                    var v = func(context);
                    context.Close();
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
        protected static dynamic QueryDb(Func<IDbConnection, dynamic> func)
        {
            using (var context = new MySqlConnection(Connecstring))
            {
                context.Open();
                try
                {
                    var v = func(context);
                    context.Close();
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
        protected static dynamic QueryDbTran(Func<IDbConnection, dynamic> func)
        {
            using (var context = new MySqlConnection(Connecstring))
            {
                context.Open();
                var tran = context.BeginTransaction();
                try
                {
                    var v = func(context);
                    tran.Commit();
                    context.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Log.Error("操作失败", ex);
                    tran.Rollback();
                    return false;
                }
                finally
                {
                    tran.Dispose();
                }
            }
        }
    }
}
