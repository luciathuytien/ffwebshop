﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;

namespace WebShop.Core
{
    public class CustomerGroup : Entity<int>
    {
        public CustomerGroup()
        {
            //Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
    }
}
