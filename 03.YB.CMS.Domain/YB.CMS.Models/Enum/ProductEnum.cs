using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Enum
{
    public class ProductEnum
    {
        /// <summary>
        /// 商品评论枚举
        /// </summary>
        public enum ProductCommentType
        {
            Good = 0,
            Middle,
            Bad
        }
        public enum ImageSize : int
        {

            /// <summary>
            /// 50*50
            /// </summary>
            [Description("50*50")]
            Size_50 = 50,

            /// <summary>
            /// 100*100
            /// </summary>
            [Description("100*100")]
            Size_100 = 100,

            /// <summary>
            /// 150*150
            /// </summary>
            [Description("150*150")]
            Size_150 = 150,

            /// <summary>
            /// 220*220
            /// </summary>
            [Description("220*220")]
            Size_220 = 220,

            /// <summary>
            /// 350*350
            /// </summary>
            [Description("350*350")]
            Size_350 = 350
        }

        /// <summary>
        /// 销售状态
        /// </summary>
        public enum ProductSaleStatus
        {
            /// <summary>
            /// 原始状态
            /// <para>此状态不可入库，需要取出原数据的销售状态重新补充数据</para>
            /// </summary>
            [Description("原始状态")]
            RawState = 0,
            /// <summary>
            /// 出售中
            /// </summary>
            [Description("出售中")]
            OnSale = 1,

            /// <summary>
            /// 仓库中
            /// </summary>
            [Description("仓库中")]
            InStock = 2,
            /// <summary>
            /// 草稿箱
            /// </summary>
            [Description("草稿箱")]
            InDraft = 3,
            /// <summary>
            /// 已删除
            /// </summary>
            [Description("已删除")]
            InDelete = 4,

            /// <summary>
            /// 库存预警
            /// </summary>
            [Description("库存预警")]
            EarlyWarning = 5,
        }

        /// <summary>
        /// 审核状态
        /// </summary>
        public enum ProductAuditStatus
        {
            /// <summary>
            /// 等待审核
            /// </summary>
            [Description("等待审核")]
            WaitForAuditing = 1,

            /// <summary>
            /// 通过审核
            /// </summary>
            [Description("通过审核")]
            Audited,

            /// <summary>
            /// 未通过(审核失败)
            /// </summary>
            [Description("未通过")]
            AuditFailed,

            /// <summary>
            /// 违规下架
            /// </summary>
            [Description("违规下架")]
            InfractionSaleOff,

            /// <summary>
            /// 未审核
            /// </summary>
            [Description("未审核")]
            UnAudit,

            /// <summary>
            /// 商品审核通过未上架，仓库中
            /// </summary>
            [Description("审核通过但未上架")]
            NoShelves
        }
        public enum ProductEditStatus
        {
            /// <summary>
            /// 正常
            /// <para>修改己生效</para>
            /// </summary>
            [Description("正常")]
            Normal = 0,

            /// <summary>
            /// 己修改
            /// </summary>
            [Description("己修改")]
            Edited = 1,

            /// <summary>
            /// 待审核
            /// </summary>
            [Description("待审核")]
            PendingAudit = 2,

            /// <summary>
            /// 己修改待审核
            /// <para>己修改+待审核</para>
            /// </summary>
            [Description("己修改待审核")]
            EditedAndPending = 3
        }
        public enum LimitTimeMarketAuditStatus : short
        {
            /// <summary>
            /// 等待审核
            /// </summary>
            [Description("待审核")]
            WaitForAuditing = 1,

            /// <summary>
            /// 进行中
            /// </summary>
            [Description("进行中")]
            Ongoing,

            /// <summary>
            /// 未通过(审核失败)
            /// </summary>
            [Description("未通过")]
            AuditFailed,

            /// <summary>
            /// 已结束
            /// </summary>
            [Description("已结束")]
            Ended,

            /// <summary>
            /// 已取消
            /// </summary>
            [Description("已取消")]
            Cancelled
        }
    }
}
