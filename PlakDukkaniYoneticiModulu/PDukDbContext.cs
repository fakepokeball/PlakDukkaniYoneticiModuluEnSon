using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticiModulu
{
    internal class PDukDbContext : DbContext
    {
        public PDukDbContext() : base("conn")
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
