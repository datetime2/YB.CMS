using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Query
{
    public class OrderQuery : BaseQuery
    {
        public long? OrderId { get; set; }
        public DateTime? OrderDateS { get; set; }
        public DateTime? OrderDateE { get; set; }
        public int? DistributorId { get; set; }
    }
}
