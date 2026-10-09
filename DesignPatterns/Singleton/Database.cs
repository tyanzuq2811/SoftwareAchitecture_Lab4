using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Database
    {
        private static Database db;
        private Database() { }
        public static Database GetInstance()
        {
            if (db == null) db = new Database();
            return db;
        }
    }
}
