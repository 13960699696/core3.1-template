using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl出库明细表
    {
        public int? 出库id { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public double? 领用数量 { get; set; }
        public double? 当前库存 { get; set; }
        public string 单位 { get; set; }
        public string 用途 { get; set; }
        public string 备注 { get; set; }
        public bool? Locked { get; set; }
        public int Identify { get; set; }
        public string 批次号 { get; set; }
        public double? 结算单价 { get; set; }
        public double? 金额 { get; set; }
        public string 标识 { get; set; }
        public string 质量 { get; set; }
        public string 出库单号 { get; set; }
        public int? 订单id { get; set; }
    }
}
