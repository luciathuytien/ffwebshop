﻿using Abp.Application.Services.Dto;

namespace WebShop.Application
{
    public class DeleteProductMetaRq : BaseRequest
    {
        public ProductMetaDTO Meta { get; set; }
    }
}
