using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl出库单
    {
        public string 出库单号 { get; set; }
        public string 经办人 { get; set; }
        public string 仓库名称 { get; set; }
        public DateTime? 出库日期 { get; set; }
        public string 出库类型 { get; set; }
        public string 客户名称 { get; set; }
        public string 备注 { get; set; }
        public bool? Locked { get; set; }
        public int Identify { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 出库车牌号 { get; set; }
        public string 出库票据号 { get; set; }
        public int? 客户id { get; set; }
    }
}
