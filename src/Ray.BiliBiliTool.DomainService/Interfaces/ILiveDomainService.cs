﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ray.BiliBiliTool.DomainService.Interfaces
{
    /// <summary>
    /// 直播中心
    /// </summary>
    public interface ILiveDomainService : IDomainService
    {
        /// <summary>
        /// 签到
        /// </summary>
        void LiveSign();

        /// <summary>
        /// 银瓜子兑换硬币
        /// </summary>
        /// <returns></returns>
        decimal ExchangeSilver2Coin();
    }
}
