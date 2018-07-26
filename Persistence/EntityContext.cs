using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class EntityContext : DbContext
    {
        public DbSet<MasterEntitiy> MasterEntities { get; set; }
        public DbSet<SlaveEntity> SlaveEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SlaveEntity>().Property(u => u.Attribute2).HasColumnName("display_name");
        }
    }
}
