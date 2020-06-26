using System;
using System.Collections.Generic;

namespace Core.models.SqlServerVMTestModels
{
    public partial class Wk供应商表
    {
        public string 供应商名称 { get; set; }
        public string 企业类型 { get; set; }
        public string 产品名称 { get; set; }
        public string 公司地址 { get; set; }
        public string 常规联系人 { get; set; }
        public string 职务 { get; set; }
        public string 联系电话 { get; set; }
        public string 第二联系人 { get; set; }
        public string 第二人职务 { get; set; }
        public string 第二人联系电话 { get; set; }
        public string 备注 { get; set; }
        public bool? Locked { get; set; }
        public int Identify { get; set; }
        public string 状态 { get; set; }
        public string 供应商评级 { get; set; }
        public string 供应商简称 { get; set; }
        public string 经办人 { get; set; }
        public DateTime? 经办日期 { get; set; }
        public string 类型 { get; set; }
    }
}
