using System;
using System.Collections.Generic;

namespace DTO
{
    public partial class UsersDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? UserPassword { get; set; }
        public int? UserPermission { get; set; }
    }
}
