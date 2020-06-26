using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl入库单
    {
        public string 入库单号 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 入库日期 { get; set; }
        public string 仓库名称 { get; set; }
        public string 入库类型 { get; set; }
        public string 供应商名称 { get; set; }
        public string 审核标志 { get; set; }
        public bool? Locked { get; set; }
        public int Identify { get; set; }
        public int? 供应商id { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 入库车牌号 { get; set; }
        public string 入库票据单号 { get; set; }
        public string 备注 { get; set; }
    }
}
