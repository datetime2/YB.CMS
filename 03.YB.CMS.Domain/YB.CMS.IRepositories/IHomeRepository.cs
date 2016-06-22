using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB.CMS.Models.View;

namespace YB.CMS.IRepositories
{
    public interface IHomeRepository
    {
        PlatHomeView PlatHomeModel();
    }
}
