using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Enum
{
    public class OrderEnum
    {
        public enum OrderOperateStatus
        {
            /// <summary>
            /// 待付款
            /// </summary>
            [Description("待付款")]
            WaitPay = 1,

            /// <summary>
            /// 待发货
            /// </summary>
            [Description("待发货")]
            WaitDelivery,

            /// <summary>
            /// 待收货
            /// </summary>
            [Description("待收货")]
            WaitReceiving,

            /// <summary>
            /// 已完成
            /// </summary>
            [Description("已完成")]
            Finish,

            /// <summary>
            /// 已关闭
            /// </summary>
            [Description("已关闭")]
            Close,
            /// <summary>
            /// 已关闭
            /// </summary>
            [Description("回收站")]
            Rebid
        }
    }
}
