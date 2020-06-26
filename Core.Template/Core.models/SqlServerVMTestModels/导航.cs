using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class 导航
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public int? 父键 { get; set; }
        public int? 序号 { get; set; }
        public string 分组 { get; set; }
        public string 名称 { get; set; }
        public string 字体颜色 { get; set; }
        public string 提示 { get; set; }
        public string 图标 { get; set; }
        public bool? 可见 { get; set; }
        public bool? 可用 { get; set; }
        public string 代码 { get; set; }
        public string 备注 { get; set; }
    }
}
