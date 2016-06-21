using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB.CMS.Models.Enum
{
    public class SystemEnum
    {
        public enum Position : int
        {
            /// <summary>
            /// 左
            /// </summary>
            [Description("左1")]
            LeftOne = 1,

            /// <summary>
            /// 顶
            /// </summary>
            [Description("左2")]
            LeftTwo = 2,

            /// <summary>
            /// 中
            /// </summary>
            [Description("中1")]
            MiddleOne = 3,
            /// <summary>
            /// 中
            /// </summary>
            [Description("中2")]
            MiddleTwo = 4,
            /// <summary>
            /// 中
            /// </summary>
            [Description("中3")]
            MiddleThree = 5,

            /// <summary>
            /// 中
            /// </summary>
            [Description("中4")]
            MiddleFour = 6,
            /// <summary>
            /// 中
            /// </summary>
            [Description("中5")]
            MiddleFive = 7,
            /// <summary>
            /// 右
            /// </summary>
            [Description("右1")]
            RightOne = 8,
            /// <summary>
            /// 右
            /// </summary>
            [Description("右2")]
            RightTwo = 9,
            /// <summary>
            /// 右
            /// </summary>
            [Description("右3")]
            RightThree = 10,

            /// <summary>
            /// 底
            /// </summary>
            [Description("文本")]
            Top = 11,
            [Description("右1")]
            ROne = 21,
            [Description("右2")]
            RTwo = 22,
            [Description("右3")]
            RThree = 23,
            [Description("右4")]
            RFour = 24,
            [Description("右5")]
            RFive = 25,
            [Description("右6")]
            RSix = 26,
            [Description("右7")]
            RSeven = 27,
            [Description("右8")]
            REight = 28,
            [Description("轮播图1")]
            ScrollOne = 29,
            [Description("轮播图2")]
            ScrollTwo = 30,
            [Description("轮播图3")]
            ScrollThree = 31,
            [Description("轮播图4")]
            ScrollFour = 32
        }

        public enum SlideAdType
        {
            /// <summary>
            /// 平台首页轮播图
            /// </summary>
            [Description("平台首页轮播图")]
            PlatformHome = 1,

            /// <summary>
            /// 平台限时购轮播图
            /// </summary>
            [Description("平台限时购轮播图")]
            PlatformLimitTime,

            /// <summary>
            /// 店铺首页轮播图
            /// </summary>
            [Description("店铺首页轮播图")]
            ShopHome,

            /// <summary>
            /// 微店轮播图
            /// </summary>
            [Description("微店轮播图")]
            VShopHome,

            [Description("微信首页轮播图")]
            WeixinHome,

            /// <summary>
            /// 触屏版首页轮播图
            /// </summary>
            [Description("触屏版首页轮播图")]
            WapHome,

            /// <summary>
            /// 触屏版微店首页轮播图
            /// </summary>
            [Description("触屏版微店首页轮播图")]
            WapShopHome,
            /// <summary>
            /// 微信主题馆图
            /// </summary>
            [Description("微信主题馆图")]
            ThemeCongfig,
            /// <summary>
            /// 限时购页面广告图
            /// </summary>
            [Description("Wap限时购页面广告图")]
            WapLimitTimeAd,

            [Description("APP首页轮播图")]
            APPHome,
            /// <summary>
            /// 海外直邮pc首页轮播图
            /// </summary>
            [Description("海外直邮首页轮播图")]
            SeasTradeHome,
            /// <summary>
            /// 海外直邮Wap首页轮播图
            /// </summary>
            [Description("海外直邮Wap首页轮播图")]
            SeasTradeWapHome,
            /// <summary>
            /// 海外直邮品牌广告
            /// </summary>
            [Description("海外直邮品牌广告")]
            SeasTradeBandAds,
            /// <summary>
            /// 海外直邮活动广告
            /// </summary>
            [Description("海外直邮活动广告")]
            SeasTradeActivityAds,
            /// <summary>
            /// 直邮商家首页轮播图
            /// </summary>
            [Description("直邮商家首页轮播图")]
            ZYShop,
            /// <summary>
            /// 直邮商家首页背景图
            /// </summary>
            [Description("直邮商家首页背景图")]
            ZYShopBg,
            /// <summary>
            /// 直邮商家WAP首页轮播图
            /// </summary>
            [Description("直邮商家WAP首页轮播图")]
            ZYWapShop,
            /// <summary>
            /// 海外直邮首页轮播图
            /// </summary>
            [Description("APP海外直邮首页轮播图")]
            APPSeasTradeHome,
            /// <summary>
            /// 积分商城首页轮播图
            /// </summary>
            [Description("积分商城首页轮播图")]
            IntegralMallHome,
            /// <summary>
            /// 国内行货品牌广告
            /// </summary>
            [Description("国内行货品牌广告")]
            DomesticTrading,
            /// <summary>
            /// 国内行货pc首页轮播图
            /// </summary>
            [Description("国内行货首页轮播图")]
            DomesticTradeHome,
            /// <summary>
            /// 国内行货活动广告
            /// </summary>
            [Description("国内行货活动广告")]
            DomesticTradeActivityAds,
        }
        public enum UrlTypes
        {
            [Description("")]
            /// <summary>
            /// 不链接
            /// </summary>
            Nothing = 0,

            [Description("首页")]
            /// <summary>
            /// 商城首页
            /// </summary>
            ShopHome = 1,

            [Description("微店")]
            /// <summary>
            /// 微店
            /// </summary>
            WeiStore = 2,

            [Description("分类")]
            /// <summary>
            /// 商城分类
            /// </summary>
            ShopCategory = 3,

            [Description("个人中心")]
            /// <summary>
            /// 个人中心
            /// </summary>
            MemberCenter = 4,
            /// <summary>   
            /// 链接
            /// </summary>
            [Description("")]
            Linkage = 5
        }
        public enum OpinionSource
        {
            [Description("商品相关")]
            Opinion_1 = 1,
            [Description("购物流程")]
            Opinion_2 = 2,
            /// </summary>
            [Description("价格相关")]
            Opinion_3 = 3,
            [Description("板式布局")]
            Opinion_4 = 4,
            [Description("其他")]
            Opinion_5 = 5
        }

        public enum OpinionStatus
        {
            [Description("已解决")]
            Solved = 0,
            [Description("未解决")]
            Unresolved = 1
        }
        public enum CounponStatuses
        {
            [Description("未使用")]
            Unuse,
            [Description("已使用")]
            Used
        }
    }
}
