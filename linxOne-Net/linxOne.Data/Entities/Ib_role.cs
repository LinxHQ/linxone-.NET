using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Entities
{
    public class Ib_role
    {
        public int Ib_record_primary_key { get; set; }
        public string Ib_role_name { get; set; }
        public List<Ib_account_role> Role_Account{ get; set; }
    }
}
