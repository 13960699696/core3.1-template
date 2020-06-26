using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class 物料出库明细表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public string 出库单号 { get; set; }
        public string 物料编码 { get; set; }
        public string 批次号 { get; set; }
        public double? 出库数量 { get; set; }
        public double? 出库单价 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 备注 { get; set; }
    }
}
