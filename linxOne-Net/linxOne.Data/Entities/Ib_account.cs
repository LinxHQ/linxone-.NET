using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Entities
{
   public class Ib_account
    {
        public int Ib_record_primary_key { get; set; }
        public string Ib_account_password { get; set; }
        public string Ib_account_username { get; set; }
        public List <Ib_account_role> Account_Role  { get; set; }

    }
}
