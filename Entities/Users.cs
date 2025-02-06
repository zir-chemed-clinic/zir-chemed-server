using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int? UserPermission { get; set; }
    }
}
