using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace JobLoggerRefactored
{
    public class JobLogger
    {
        private int _messageType;
        private string _message;
        private  int _opcPrintType;
        private IHelper _helper;

        public JobLogger(int messageType, string message, IHelper helper)
        {
            _message = message;
            _messageType = messageType;
            _helper = helper;
        }

        private void LogMessageToDB()
        {
            ManagerData managerDB = new ManagerData(new ManagerDataBase(), _messageType, _message, _helper);
            managerDB.PrintMessage();
        }

        private void LogMessageToFile()
        {
            ManagerData managerFile = new ManagerData(new ManagerFile(), _messageType, _message, _helper);
            managerFile.PrintMessage();
        }

        private void LogMessageToConsole()
        {
            ManagerData managerConsole = new ManagerData(new ManagerConsole(), _messageType, _message, _helper);
            managerConsole.PrintMessage();
        }

        public void LogMessage()
        {
            if (_message == null || _message.Length == 0)
                throw new Exception("The value of message is invalid");

            _opcPrintType = _helper.GetConfigurationRestrictionTypeMessage();

            if ((_opcPrintType == (int)EnumPrintType.Type.OnlyError && _messageType != (int)EnumMessageType.Type.Error) || (_opcPrintType == (int)EnumPrintType.Type.OnlyWarningError && _messageType != (int)EnumMessageType.Type.Error && _messageType != (int)EnumMessageType.Type.Warning))
                return;

            //LogMessageToDB();
            LogMessageToFile();
            LogMessageToConsole();
        }
    }
}
