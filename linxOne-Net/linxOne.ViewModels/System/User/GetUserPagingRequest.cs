﻿using linxOne.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.System.User
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
