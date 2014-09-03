using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP8.Timesheet.Domain;

namespace WP8.Timesheet.Persistencia
{
    public class DBContext : DataContext
    {
        private static string DbConnectionString = "Data Source=isostore:WP8Timesheet.sdf";

        public DBContext() : base(DbConnectionString) {             
        }

        public Table<Configuracao> ConfigSystem{
            get{ return this.GetTable<Configuracao>(); }
        }

        public Table<Usuario> UserProfile{
            get{ return this.GetTable<Usuario>(); }
        }

    }
}
