using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Leasing.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();
    }
}