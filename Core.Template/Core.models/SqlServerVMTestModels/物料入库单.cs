using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class 物料入库单
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public string 入库单号 { get; set; }
        public DateTime? 入库日期 { get; set; }
        public string 入库类型 { get; set; }
        public string 客户编码 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 票据号 { get; set; }
        public string 车牌号 { get; set; }
        public string 备注 { get; set; }
    }
}
