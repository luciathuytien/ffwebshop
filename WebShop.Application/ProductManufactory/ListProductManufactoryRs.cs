﻿using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace WebShop.Application
{
    public class ListProductManufactoryRs : BaseResponse<ProductManufactoryDTO>
    {
        public List<ProductManufactoryDTO> Manufactories { get; set; }
    }
}
