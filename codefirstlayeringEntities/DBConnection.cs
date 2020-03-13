using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstlayeringEntities
{
   public class DBConnection :DbContext
    {
        public DBConnection():base("StringDBContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer
                (new DropCreateDatabaseIfModelChanges<DBConnection>());

        }
        public DbSet<MyFirstTable> MyFirstTable { get; set; }
    }
}
