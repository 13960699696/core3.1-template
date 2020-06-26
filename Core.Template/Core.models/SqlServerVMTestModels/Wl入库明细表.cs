using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl入库明细表
    {
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public double? 实收量 { get; set; }
        public string 单位 { get; set; }
        public string 备注 { get; set; }
        public int? 入库id { get; set; }
        public bool? Locked { get; set; }
        public int Identify { get; set; }
        public string 批次号 { get; set; }
        public double? 单价 { get; set; }
        public double? 金额 { get; set; }
        public DateTime? 生产日期 { get; set; }
        public DateTime? 有效期 { get; set; }
        public DateTime? 入单时间 { get; set; }
        public string 质量信息 { get; set; }
        public string 入库单号 { get; set; }
        public string 标识 { get; set; }
        public int? 订单id { get; set; }
    }
}
