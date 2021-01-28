using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models.Enums
{
        public enum OrderStatus : int
        {
            Pending = 0,
            Billed = 1,
            Cancelled = 2
        }
}
