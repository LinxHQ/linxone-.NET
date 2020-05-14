using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Application.Address.DataTransferObject
{
    public class PagingRequestBase
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }

    }
}
