using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class 客户表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public string 客户编码 { get; set; }
        public string 客户类型 { get; set; }
        public string 客户简称 { get; set; }
        public string 客户全称 { get; set; }
        public string 客户地址 { get; set; }
        public string 联系人 { get; set; }
        public string 联系电话 { get; set; }
        public string 状态 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
    }
}
