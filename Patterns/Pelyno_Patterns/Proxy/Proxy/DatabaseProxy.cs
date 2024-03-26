using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class DatabaseProxy : IDatabase
    {
        private Database _database;
        private string _username;
        private string _password;

        public DatabaseProxy(string username, string password)
        {
            _database = new Database();
            _username = username;
            _password = password;
        }

        public void UpdateData(object newData)
        {
            if (Authentificate())
            {
                _database.UpdateData(newData);
            }
            else
            {
                Console.WriteLine("Error: not correct data");
            }
        }

        private bool Authentificate()
        {
            return _username == "admin" && _password == "admin123";
        }
    }
}
