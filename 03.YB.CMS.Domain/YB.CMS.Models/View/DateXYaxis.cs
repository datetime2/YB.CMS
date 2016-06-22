using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.View
{
    /// <summary>
    ///图表坐标轴(X轴时间；Y轴数字)
    /// </summary>
    public class DateXYaxis
    {
        public DateTime? X { get; set; }
        public long? Y { get; set; }
    }
}
