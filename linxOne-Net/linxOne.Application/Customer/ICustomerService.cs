using linxOne.ViewModel.Common;
using linxOne.ViewModels.Customer.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace linxOne.Application.Customer
{
    public interface ICustomerService
    {
        Task<int> Create(CustomerCreateRequest request);
        Task<int> Update(CustomerUpdateRequest request);
        Task<int> Delete(int addressId);
        Task<PageViewModel<CustomerViewRequest>> GetAllPaging(GetCustomerPagingRequest request);

        Task<List<CustomerViewRequest>> GetAll();

        //business for Client.

    }
}
