using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models
{
    public class AngularTable<T> where T : class
    {
        public AngularTable()
        {
            this.total = 0;
            this.data = new List<T>();
        }
        public long? total { get; set; }
        public List<T> data { get; set; }
    }
}
