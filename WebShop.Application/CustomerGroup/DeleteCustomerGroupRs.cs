﻿using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace WebShop.Application
{
    public class DeleteCustomerGroupRs : BaseResponse<CustomerGroupDTO>
    {
        public CustomerGroupDTO Group { get; set; }
    }
}
