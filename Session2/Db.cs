using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    public class Db
    {
        public static dbEntities db { get; set; }

        static Db()
        {
            db = new dbEntities();
        }
    }
}
