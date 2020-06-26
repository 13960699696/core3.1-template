using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wl物料配方表
    {
        public int Identify { get; set; }
        public bool? Locked { get; set; }
        public decimal? SortKey { get; set; }
        public string 配方编码 { get; set; }
        public string 物料编码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public double? 配方标量 { get; set; }
        public string 单位 { get; set; }
        public string 搅拌时间 { get; set; }
        public string 搅拌速度 { get; set; }
        public string 搅拌温度 { get; set; }
        public string 搅拌压力 { get; set; }
        public string 备注 { get; set; }
        public string 配方类型 { get; set; }
    }
}
