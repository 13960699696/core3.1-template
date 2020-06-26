using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl出库明细查询
    {
        public string 出库单号 { get; set; }
        public DateTime? 出库日期 { get; set; }
        public string 仓库名称 { get; set; }
        public string 出库类型 { get; set; }
        public string 客户名称 { get; set; }
        public string 出库车牌号 { get; set; }
        public string 出库票据号 { get; set; }
        public int? 客户id { get; set; }
        public string 出库单备注 { get; set; }
        public string 出库单经办人 { get; set; }
        public DateTime? 出库单经办日期 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public double? 领用数量 { get; set; }
        public string 单位 { get; set; }
        public string 用途 { get; set; }
        public string 备注 { get; set; }
        public string 批次号 { get; set; }
        public double? 结算单价 { get; set; }
        public double? 金额 { get; set; }
        public string 标识 { get; set; }
        public string 质量 { get; set; }
        public string 一级码 { get; set; }
        public string 二级码 { get; set; }
        public string 三级码 { get; set; }
        public string 使用状态 { get; set; }
        public double? 最低库存 { get; set; }
        public double? 最高库存 { get; set; }
        public int? 订单id { get; set; }
    }
}
