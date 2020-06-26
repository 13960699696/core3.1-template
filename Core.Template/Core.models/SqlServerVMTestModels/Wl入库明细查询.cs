using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl入库明细查询
    {
        public string 入库单号 { get; set; }
        public DateTime? 入库日期 { get; set; }
        public string 仓库名称 { get; set; }
        public string 入库类型 { get; set; }
        public string 供应商名称 { get; set; }
        public int? 供应商id { get; set; }
        public string 入库车牌号 { get; set; }
        public string 入库票据单号 { get; set; }
        public string 入库单备注 { get; set; }
        public string 审核标志 { get; set; }
        public string 入库单经办人 { get; set; }
        public DateTime? 入库单经办日期 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public double? 实收量 { get; set; }
        public string 单位 { get; set; }
        public int? 入库id { get; set; }
        public string 批次号 { get; set; }
        public double? 单价 { get; set; }
        public double? 金额 { get; set; }
        public DateTime? 生产日期 { get; set; }
        public DateTime? 有效期 { get; set; }
        public DateTime? 入单时间 { get; set; }
        public string 质量信息 { get; set; }
        public string 标识 { get; set; }
        public string 入库明细备注 { get; set; }
        public string 一级码 { get; set; }
        public string 二级码 { get; set; }
        public string 三级码 { get; set; }
        public string 使用状态 { get; set; }
        public double? 最低库存 { get; set; }
        public double? 最高库存 { get; set; }
        public int? 订单id { get; set; }
    }
}
