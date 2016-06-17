using System;
using System.Collections.Generic;
using System.Configuration;
using YB.CMS.Dapper;
namespace YB.CMS.Repositories
{
    public abstract class BaseRepository
    {
        private static readonly string _connctionstring = ConfigurationManager.AppSettings["YBCMS"];
        public BaseRepository()
        {
        }
        /// <summary>
        /// 获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="sql">执行查询的语句</param>
        /// <returns></returns>
        public static T InvokeDB<T>(Func<DbContext, string, T> func,string sql)
        {
            using (var context = new DbContext(_connctionstring))
            {
                return func(context, sql);
            }
        }
        /// <summary>
        /// 数据INSERT UPDATE DELETE
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public static bool InvokeDB(Func<DbContext, bool> func)
        {
            using (var context = new DbContext(_connctionstring))
            {
                using (var scope = context.CreateUnitOfWork())
                {
                    var flag = func(context);
                    scope.SaveChanges();
                    return flag;
                }
            }
        }
    }
}
