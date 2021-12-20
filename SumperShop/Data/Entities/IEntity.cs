using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Data.Entities
{
    /// <summary>
    /// Entity Repository for several objects
    /// </summary>
    public interface IEntity
    {
        int Id { get; set; }
        //bool WasDeleted { get; set; }
    }
}
