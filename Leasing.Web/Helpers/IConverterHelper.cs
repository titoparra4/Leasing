﻿using System.Threading.Tasks;
using Leasing.Web.Data.Entities;
using Leasing.Web.Models;

namespace Leasing.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);
    }
}