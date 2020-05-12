using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace linxOne.Data.Entities
{
    public class Ib_account_role
    {
        public int Ib_account_id { get; set; }

        public Ib_account Account { get; set; }

        public int Ib_role_id { get; set; }
        public Ib_role Role { get; set; }


    }
}
