﻿/**
 * Copyright (C) 2015 Xiyou Mobile Application Lab.
 * 
 * XiyouMobileFoundation
 * 
 * XYMWebApiUniResult.cs
 * 
 * Created by Yuan Guozheng on 2015-5-5.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiyouMobileFoundation.WebAPI
{
    /// <summary>
    /// 通用返回结果
    /// </summary>
    public class XYMWebApiUniResult
    {
        /// <summary>
        /// 标识是否成功
        /// </summary>
        public bool Result { get; set; }
        
        /// <summary>
        /// 返回详情
        /// </summary>
        public object Detail { get; set; }
    }
}
