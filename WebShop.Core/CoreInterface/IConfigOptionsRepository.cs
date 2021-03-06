﻿using System.Collections.Generic;
using Abp.Domain.Repositories;
using System.Threading.Tasks;

namespace WebShop.Core
{
    public interface IConfigOptionsRepository : IRepository<ConfigOptions, int>
    {
        // Declare custom action with database
        Task<ConfigOptions> GetOptionByKeyAsync(string OptionKey);
    }
}
