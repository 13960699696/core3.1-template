using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl物料编码表
    {
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 单位 { get; set; }
        public string 一级码 { get; set; }
        public string 二级码 { get; set; }
        public string 三级码 { get; set; }
        public string 使用状态 { get; set; }
        public double? 最低库存 { get; set; }
        public double? 最高库存 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 客户名称 { get; set; }
        public string 备注说明 { get; set; }
        public string 采购周期 { get; set; }
        public string 结存单价 { get; set; }
        public double? 最低采购量 { get; set; }
        public bool? Locked { get; set; }
        public int Identify { get; set; }
        public string 粘度 { get; set; }
        public string 亮度 { get; set; }
    }
}
