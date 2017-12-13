using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ManagerConsole : IManagerData
    {
        public void Print(string message, int typeMessage, IHelper helper)
        {
            
            switch (typeMessage)
            {
                case (int)EnumMessageType.Type.Message:
                    Console.ForegroundColor=ConsoleColor.White;
                    break;
                case (int)EnumMessageType.Type.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)EnumMessageType.Type.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            Console.WriteLine(DateTime.Now.ToShortDateString()+message);
            //Console.ReadLine();
        }
    }
}
