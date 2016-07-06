using DapperEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Query
{
    public class SqlWhereQuery<T> where T : class
    {
        public Expression<Func<T, object>> expr { get; set; }
        public OperationMethod operation { get; set; }
        public object value { get; set; }
    }
}
