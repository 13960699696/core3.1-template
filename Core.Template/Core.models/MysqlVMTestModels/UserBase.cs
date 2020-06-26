using System;
using System.Collections.Generic;

namespace Core.models.MysqlVMTestModels
{
    public partial class UserBase
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
