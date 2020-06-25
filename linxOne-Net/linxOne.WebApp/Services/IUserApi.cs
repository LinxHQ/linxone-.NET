using linxOne.ViewModel.Common;
using linxOne.ViewModels.Common;
using linxOne.ViewModels.System.User;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linxOne.WebApp.Services
{
  public  interface IUserApi
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        //Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<PageViewModel<UserViewRequest>>>GetUserPaging(GetUserPagingRequest request);
       

    }
}
