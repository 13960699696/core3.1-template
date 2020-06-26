using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl采购物料单价表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public DateTime? 生效日期 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        public string 辅助单位 { get; set; }
        public decimal? 单价 { get; set; }
        public string 单价单位 { get; set; }
        public string 状态 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 一级码 { get; set; }
        public string 二级码 { get; set; }
        public string 三级码 { get; set; }
        public string 备注 { get; set; }
        public int? 供应商id { get; set; }
        public string 供应商简称 { get; set; }
        public string 单价识别码 { get; set; }
        public int? 批次 { get; set; }
    }
}
