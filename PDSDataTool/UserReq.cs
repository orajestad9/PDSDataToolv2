using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDSDataTool
{
    class UserReq
    {
        public void getUserEntry()
        {
            Console.WriteLine("Please select a combination from the list below:");
            var dataCombo = Console.ReadLine();
        };
    }
}
