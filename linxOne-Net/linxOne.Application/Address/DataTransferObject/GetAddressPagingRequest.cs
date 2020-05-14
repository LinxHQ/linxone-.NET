using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Application.Address.DataTransferObject
{
  public  class GetAddressPagingRequest:PagingRequestBase
    {
        public string keyword { get; set; }
    }
}
