using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace DTO
{
    public partial class Form
    {
        public string file { get; set; }
        public string familyName { get; set; }
        public bool treatments { get; set; }
        public List<string> emails { get; set; }


    }
}
