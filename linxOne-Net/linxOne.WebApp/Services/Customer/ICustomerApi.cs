using linxOne.ViewModel.Common;
using linxOne.ViewModels.Common;
using linxOne.ViewModels.Customer.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linxOne.WebApp.Services.Customer
{
    public interface ICustomerApi
    {
        Task<ApiResult<PageViewModel<CustomerViewRequest>>> GetCustomerPaging(GetCustomerPagingRequest request);
        Task<int> Create(CustomerCreateRequest request);
        Task<ApiResult<CustomerViewRequest>> GetById(int id);

    }
}
