using linxOne.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModel.Common
{
   public class PageViewModel<T>:PagedResultBase
    {
       public List<T> Items { get; set; }
        //public int TotalRecord { get; set; }
        
    }
}
