using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ManagerData
    {
        private IManagerData _manager;
        int _messageType;
        string _message;
        IHelper _helper;

        public ManagerData(IManagerData manager, int messageType, string message, IHelper helper)
        {
            _manager = manager;
            _messageType = messageType;
            _message = message;
            _helper = helper;
        }

        public void PrintMessage()
        {
            _manager.Print(_message, _messageType, _helper);
        }
    }
}
