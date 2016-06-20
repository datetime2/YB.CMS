using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Query
{
    public class BaseQuery
    {
        public BaseQuery()
        {
            this.Page = 1;
            this.PageSize = 25;
        }
        /// <summary>
        /// 页码
        /// </summary>
        public int? Page { get; set; }
        /// <summary>
        /// 分页数
        /// </summary>
        public int? PageSize { get; set; }
        /// <summary>
        /// 排序列
        /// </summary>
        public string SortColumn { get; set; }
        /// <summary>
        /// 排序类型(asc,升序;desc,降序)
        /// </summary>
        public string SortOrder { get; set; }
    }
}
