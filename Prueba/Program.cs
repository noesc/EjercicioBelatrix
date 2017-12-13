using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelatrixRefactored;
using Data;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            JobLogger log = new JobLogger(1,"Hi World", helper);
            log.LogMessage();
        }
    }
}
