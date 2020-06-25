using linxOne.ViewModel.Common;
using linxOne.ViewModels.Common;
using linxOne.ViewModels.System.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace linxOne.Application.System.User
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<PageViewModel<UserViewRequest>> GetUserPaging(GetUserPagingRequest request);

    }
}
