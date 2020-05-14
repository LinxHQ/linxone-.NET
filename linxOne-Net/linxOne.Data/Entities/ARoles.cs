using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Entities
{
    public class ARoles : IdentityRole<Guid>
    {
        public string Descriptions { get; set; }

    }
}
