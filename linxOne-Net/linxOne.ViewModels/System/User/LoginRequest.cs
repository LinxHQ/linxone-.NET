using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace linxOne.ViewModels.System.User
{
    public class LoginRequest
    {
        public string UserName{ get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        
    }
}
