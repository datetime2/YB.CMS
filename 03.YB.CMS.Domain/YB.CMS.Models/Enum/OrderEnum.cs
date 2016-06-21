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
        public enum OrderTypes
        {
            /// <summary>
            /// 普通卖家订单
            /// </summary>
            [Description("普通卖家订单")]
            Seller = 0,
            /// <summary>
            /// 分销商订单
            /// </summary>
            [Description("分销商订单")]
            Distributor,
            /// <summary>
            /// B2C订单
            /// </summary>
            [Description("B2C订单")]
            B2C,
            /// <summary>
            /// 一般贸易订单
            /// </summary>
            [Description("一般贸易订单")]
            GeneralTrade,
            /// <summary>
            /// 社区推广员订单
            /// </summary>
            [Description("社区推广员订单")]
            CommunityReferrOrders
        }
        public enum InvoiceTypeEnum
        {
            /// <summary>
            /// 不需要发票
            /// </summary>
            [Description("不需要发票")]
            None = 0,
            /// <summary>
            /// 增值税发票
            /// </summary>
            [Description("增值税发票")]
            VATInvoice = 1,

            /// <summary>
            /// 普通发票
            /// </summary>
            [Description("普通发票")]
            OrdinaryInvoices = 2
        }
        /// <summary>
        /// 商家审核状态
        /// </summary>
        public enum OrderRefundAuditStatus
        {
            /// <summary>
            /// 待商家审核
            /// </summary>
            [Description("待商家审核")]
            WaitAudit = 1,

            /// <summary>
            /// 待买家寄货
            /// </summary>
            [Description("待买家寄货")]
            WaitDelivery = 2,

            /// <summary>
            /// 待商家收货
            /// </summary>
            [Description("待商家收货")]
            WaitReceiving = 3,

            /// <summary>
            /// 商家拒绝
            /// </summary>
            [Description("商家拒绝")]
            UnAudit = 4,

            /// <summary>
            /// 商家通过审核
            /// </summary>
            [Description("商家通过审核")]
            Audited = 5
        }

        /// <summary>
        /// 平台确认状态
        /// </summary>
        public enum OrderRefundConfirmStatus
        {
            /// <summary>
            /// 待平台确认
            /// </summary>
            [Description("待平台确认")]
            UnConfirm = 6,

            /// <summary>
            /// 退款成功
            /// </summary>
            [Description("退款成功")]
            Confirmed = 7
        }

        /// <summary>
        /// 退款方式
        /// </summary>
        public enum OrderRefundMode
        {
            /// <summary>
            /// 订单退款
            /// </summary>
            [Description("订单退款")]
            OrderRefund = 1,

            /// <summary>
            /// 货品退款
            /// </summary>
            [Description("货品退款")]
            OrderItemRefund = 2,

            /// <summary>
            /// 退货退款
            /// </summary>
            [Description("退货退款")]
            ReturnGoodsRefund = 3
        }
        public enum OrderQueueOperateType
        {
            /// <summary>
            /// 分佣计算
            /// </summary>
            [Description("分佣计算")]
            Commission = 0,
            /// <summary>
            /// 代发货
            /// </summary>
            [Description("代发货")]
            ERP = 1,
            /// <summary>
            /// 其他
            /// </summary>
            [Description("其他")]
            Other = 2,
            /// <summary>
            /// B2C导入订单
            /// </summary>
            [Description("B2C导入订单")]
            B2C = 50
        }
        public enum ValuationMethodType
        {
            /// <summary>
            /// 按件数
            /// </summary>
            [Description("按件数")]
            Piece,

            /// <summary>
            /// 按重量
            /// </summary>
            [Description("按重量")]
            Weight,
            /// <summary>
            /// 按体积
            /// </summary>
            [Description("按体积")]
            Bulk,
            /// <summary>
            /// 按重量[无城市限制]
            /// </summary>
            [Description("按重量[无城市限制]")]
            WeightNoCity
        }
        public enum FreightTemplateType
        {
            /// <summary>
            /// 自定义
            /// </summary>
            [Description("自定义模板")]
            SelfDefine,
            /// <summary>
            /// 卖家承担运费(免运费)
            /// </summary>
            [Description("卖家承担运费")]
            Free
        }
    }
}
