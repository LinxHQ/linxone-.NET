using linxOne.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.Customer.DataTransferObject
{
    public class GetCustomerPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
    }
}
