﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;

namespace WebShop.Core
{
    public class ProductStatus : Entity<int>
    {
        public ProductStatus()
        {
            //this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string Notes { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
    }
}
