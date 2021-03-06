﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;

namespace WebShop.Core
{
    public class Product : Entity<int>
    {
        public Product()
        {
            ProductBranch = new HashSet<ProductBranch>();
            ProductCategory = new HashSet<ProductCategory>();
            ProductManufactory = new HashSet<ProductManufactory>();
            ProductStatus = new HashSet<ProductStatus>();
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public int? CategoryId { get; set; }
        public decimal? OriginPrice { get; set; }
        public decimal? SellPrice { get; set; }
        public int? Quantity { get; set; }
        public int? Status { get; set; }
        public int? ManufactoryId { get; set; }
        public int? BranchId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? ImportDate { get; set; }
        public string FeatureImage { get; set; }
        public string ImageList { get; set; }
        public bool? IsActive { get; set; }
        public decimal? Discount { get; set; }

        //[ForeignKey("BranchId")]
        //public virtual ProductBranch ProductBranch { get; set; }
        //[ForeignKey("CategoryId")]
        //public virtual ProductCategory ProductCategory { get; set; }
        //[ForeignKey("Status")]
        //public virtual ProductStatus ProductStatus { get; set; }        
        public virtual ICollection<ProductBranch> ProductBranch { get; set; }
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
        public virtual ICollection<ProductManufactory> ProductManufactory { get; set; }
        public virtual ICollection<ProductStatus> ProductStatus { get; set; }
    }
}
