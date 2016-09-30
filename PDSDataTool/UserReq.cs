using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDSDataTool
{
    class UserReq
    {
        string[] _userEntry;
        public string[] userEntry
        {
            get { return _userEntry; }
            private set { this._userEntry = userEntry; }
        }

        public void getUserEntry()
        {
            Console.WriteLine("Please write the number for each item you select in the list below:");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            var line = Console.ReadLine();
            _userEntry = line.Split(' ');
        }
    }
}
