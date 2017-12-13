using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ManagerFile : IManagerData
    {
        private IHelper _helper;

        public void Print(string message, int typeMessage, IHelper helper)
        {
            _helper = helper;
            string path = _helper.GetPathFile();
            System.IO.File.WriteAllText(path+"LogFile"+DateTime.Now.ToString("MM-dd-yy") +".txt", message);
        }
    }
}
