using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class 物料单价表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public DateTime? 生效日期 { get; set; }
        public string 单价编码 { get; set; }
        public string 物料编码 { get; set; }
        public double? 单价 { get; set; }
        public string 状态 { get; set; }
        public string 客户编码 { get; set; }
        public string 备注 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
    }
}
