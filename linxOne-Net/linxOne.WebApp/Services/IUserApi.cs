using linxOne.ViewModels.Common;
using linxOne.ViewModels.System.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linxOne.WebApp.Services
{
  public  interface IUserApi
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

    }
}
