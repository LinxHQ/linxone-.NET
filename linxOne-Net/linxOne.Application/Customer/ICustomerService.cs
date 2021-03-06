﻿using linxOne.ViewModel.Address.DataTransferObject;
using linxOne.ViewModel.Common;
using linxOne.ViewModels.Common;
using linxOne.ViewModels.Contact.DataTransferObject;
using linxOne.ViewModels.Customer.DataTransferObject;
using linxOne.ViewModels.Invoice.DatatransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace linxOne.Application.Customer
{
    public interface ICustomerService
    {
        Task<int> Create(CustomerCreateRequest request);
        //Task<ApiResult<bool>> Create1(CustomerCreateRequest request);
        Task<int> Update(CustomerUpdateRequest request);
        Task<int> Delete(int customerId);
        Task<ApiResult<PageViewModel<CustomerViewRequest>>> GetAllPaging(GetCustomerPagingRequest request);
        Task<ApiResult<CustomerViewRequest>> GetCustomerById(int id);
        Task<List<CustomerViewRequest>> GetAll();
        Task<List<AddressViewRequest>> GetCustomerAddressByCustomerId(int id);
        Task<List<ContactViewRequest>> GetCustomerContactByCustomerId(int id);
        Task<List<InvoiceViewRequest>> GetCustomerInvoiceCustomerId(int id);


        //business for Client.

    }
}
