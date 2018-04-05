using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLoggerRefactored
{
    public class EnumPrintType
    {
        public enum Type
        {
            All = 1,
            OnlyError,
            OnlyWarningError
        }
    }
}
