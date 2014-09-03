using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP8.Timesheet.Persistencia
{
    public class MyContext
    {
        public static DBContext Context
        {
            get
            {
                DBContext db = new DBContext();
                if (!db.DatabaseExists())
                {
                    db.CreateDatabase();
                }
                db.ObjectTrackingEnabled = true;
                foreach(var item in db.Mapping.GetTables())
                {
                    db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, item);
                    db.SubmitChanges();
                }
                return db;
            }
        }
    }
}
