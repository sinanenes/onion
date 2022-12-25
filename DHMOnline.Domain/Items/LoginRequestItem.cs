using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Domain.Items
{
    public class LoginRequestItem
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
