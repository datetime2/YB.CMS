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
        public enum PlatformType
        {
            /// <summary>
            /// PC
            /// </summary>
            [Description("PC")]
            PC = 0,
            /// <summary>
            /// 微信
            /// </summary>
            [Description("微信")]
            WeiXin = 1,
            /// <summary>
            /// 安卓
            /// </summary>
            [Description("Android")]
            Android = 2,
            /// <summary>
            /// 苹果
            /// </summary>
            [Description("IOS")]
            IOS = 3,
            /// <summary>
            /// 触屏
            /// </summary>
            [Description("触屏")]
            Wap = 4,
            /// <summary>
            /// POS
            /// </summary>
            [Description("POS")]
            POS = 5,
            /// <summary>
            /// 移动端
            /// </summary>
            [Description("移动端")]
            Mobile = 99
        }
    }
}
