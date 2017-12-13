using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ManagerDataBase : IManagerData
    {
        private IHelper _helper;

        public void Print(string message, int typeMessage, IHelper helper)
        {
            _helper = helper;

            string connectionString = helper.GetConnectionString();
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
            connection.Open();

            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("Insert into LogValues('"+message+"',"+ typeMessage + ")");
            command.ExecuteNonQuery();
        }
    }
}
