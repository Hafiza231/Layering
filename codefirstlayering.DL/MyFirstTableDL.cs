using codefirstlayeringEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstlayering.DL
{
    public class MyFirstTableDL
    {
        

        public List<MyFirstTable> GetAllData()
        {
            DBConnection db = new DBConnection();
             return db.MyFirstTable.ToList();
        }

    }
}
