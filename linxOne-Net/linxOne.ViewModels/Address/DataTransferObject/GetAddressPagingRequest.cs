using linxOne.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModel.Address.DataTransferObject
{
  public  class GetAddressPagingRequest:PagingRequestBase
    {
        public string keyword { get; set; }
    }
}
