using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Helper : IHelper
    {
        public int GetConfigurationRestrictionTypeMessage()
        {
           return Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["RestrictionTypeMessage"].ToString());
        }

        public string GetPathFile()
        {
            return System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"].ToString();
        }

        public string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        }
    }
}
