using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Enum
{
    public class UserEnum
    {
        public enum ReferrAuditStatus
        {
            /// <summary>
            /// 不可用
            /// </summary>
            [Description("不可用")]
            Unusable = 1,

            /// <summary>
            /// 待审核
            /// </summary>
            [Description("待审核")]
            WaitAudit = 2,

            /// <summary>
            /// 已审核
            /// </summary>
            [Description("已审核")]
            Usable = 3,

            /// <summary>
            /// 被拒绝
            /// </summary>
            [Description("被拒绝")]
            Refuse = 4

        }
        public enum UserTypes
        {
            /// <summary>
            /// 普通用户
            /// </summary>
            [Description("普通用户")]
            General,

            /// <summary>
            /// 店铺用户
            /// </summary>
            [Description("店铺用户")]
            ShopManager,
        }
        public enum AppIdTypeEnum
        {
            /// <summary>
            /// 支付的Appid
            /// </summary>
            Payment,
            /// <summary>
            /// 一般的Appid
            /// </summary>
            Normal
        }
        public enum TixianStatus
        {

            [Description("待审核")]
            /// <summary>
            /// 待审核
            /// </summary>
            DaiShenhe = 0,

            [Description("已提现")]
            /// <summary>
            /// 已提现
            /// </summary>
            YiTixian = 1,

            [Description("已取消")]
            /// <summary>
            /// 已取消
            /// </summary>
            YiQuxiao = 2
        }
    }
}
