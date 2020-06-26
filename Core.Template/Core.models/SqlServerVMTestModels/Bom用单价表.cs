using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Bom用单价表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public DateTime? 生效日期 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public float? 平均单价 { get; set; }
        public string 状态 { get; set; }
        public string 备注 { get; set; }
        public string 经办人 { get; set; }
        public string 一级码 { get; set; }
        public string 二级码 { get; set; }
        public string 三级码 { get; set; }
        public string 单位 { get; set; }
        public string 单价单位 { get; set; }
    }
}
