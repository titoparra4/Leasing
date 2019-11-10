using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leasing.Web.Data.Entities
{
    public class Manager
    {
        public int Id { get; set; }

        public User User { get; set; }
    }
}
