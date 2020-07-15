using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.System.User
{
   public class UserViewRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
