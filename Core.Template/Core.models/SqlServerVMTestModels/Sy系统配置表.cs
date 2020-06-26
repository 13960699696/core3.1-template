using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Sy系统配置表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public string 所属系统 { get; set; }
        public string 配置大类 { get; set; }
        public string 配置中类 { get; set; }
        public string 配置小类 { get; set; }
        public string 配置名称 { get; set; }
        public string 表名称 { get; set; }
        public string 列名称 { get; set; }
        public string 窗口名称 { get; set; }
        public string 控件名称 { get; set; }
        public string 配置数据 { get; set; }
        public bool? 可见状态 { get; set; }
        public bool? 可用状态 { get; set; }
        public string 状态 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
    }
}
