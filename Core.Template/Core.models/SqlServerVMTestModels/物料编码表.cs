using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class 物料编码表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        public double? 最高库存 { get; set; }
        public double? 最低库存 { get; set; }
        public string 状态 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 一级码 { get; set; }
        public string 二级码 { get; set; }
    }
}
