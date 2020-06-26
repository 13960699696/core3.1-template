using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Dd订单请购数量表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public string 订单编号 { get; set; }
        public DateTime? 订单日期 { get; set; }
        public int? 客户id { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public double? 订购数量 { get; set; }
        public string 单位 { get; set; }
        public string 完成状态 { get; set; }
        public double? 完成数量 { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 客户名称 { get; set; }
        public string 备注 { get; set; }
        public string 类别 { get; set; }
        public DateTime? 完成日期 { get; set; }
    }
}
