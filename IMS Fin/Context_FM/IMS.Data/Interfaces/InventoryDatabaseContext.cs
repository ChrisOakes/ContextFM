using IMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Data.Interfaces
{
    public interface InventoryDatabaseContext
    {
        public DbSet<Inventory> Inventory { get; set; }
    }
}
