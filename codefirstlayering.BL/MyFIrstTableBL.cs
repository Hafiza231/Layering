using codefirstlayering.DL;
using codefirstlayeringEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstlayering.BL
{
    public class MyFIrstTableBL
    {
          public List<MyFirstTable> GetAllDataBL()
        {
            MyFirstTableDL dl = new MyFirstTableDL();
            return dl.GetAllData();
        }
    }
}
