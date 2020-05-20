using linxOne.Application.Address.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace linxOne.Application.Address
{
    public interface IAddressService
    {
        //business for Manage.
        Task<int> Create(AddressCreateRequest request);
        Task<int> Update(AddressUpdateRequest request);
        Task<int> Delete(int addressId);
        //Task<List<AddressViewRequest>> GetAll();
        Task<PageViewModel<AddressViewRequest>> GetAllPaging(GetAddressPagingRequest request);
        //business for Client.



    }
}
