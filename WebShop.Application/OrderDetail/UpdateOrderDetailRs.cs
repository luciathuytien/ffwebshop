﻿using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace WebShop.Application
{
    public class UpdateOrderDetailRs : BaseResponse<OrderDetailDTO>
    {
        public OrderDetailDTO OrderDetail { get; set; }
    }
}
