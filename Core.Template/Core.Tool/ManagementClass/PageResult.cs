using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Tool.ManagementClass
{
    public class PageResult<T>
    {
        public int total { get; set; }
        public List<T> rows { get; set; }
    }
}
