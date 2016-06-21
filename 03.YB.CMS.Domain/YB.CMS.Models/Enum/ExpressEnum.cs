using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Enum
{
    public class ExpressEnum
    {
        public enum ExpressStatus
        {
            [Description("监控中")]
            Polling = 0,
            [Description("结束")]
            Shutdown = 1,
            [Description("中止")]
            Abort = 2,
            [Description("重新推送")]
            UpdateAll = 3
        }

        /// <summary>
        /// 快递签收状态
        /// </summary>
        public enum ExpressReceiveStatus
        {
            [Description("在途中")]
            OnPassage = 0,
            [Description("已揽收")]
            Undertake = 1,
            [Description("疑难件")]
            Difficult = 2,
            [Description("已签收")]
            Received = 3,
            [Description("已退签")]
            ReturnSign = 4,
            [Description("同城派送中")]
            CityWideSend = 5,
            [Description("已退回")]
            Return = 6,
            [Description("转单")]
            Exchange = 7,
        }
    }
}
