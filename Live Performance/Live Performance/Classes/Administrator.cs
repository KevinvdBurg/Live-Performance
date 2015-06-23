using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    class Administrator
    {
        DBtest dBtest = new DBtest();
        public void Connect(int id)
        {
            dBtest.ConnectionTest(id);
        }
    }
}
