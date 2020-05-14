using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Application.Address.DataTransferObject
{
   public class PageViewModel<T>
    {
       public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
        
    }
}
