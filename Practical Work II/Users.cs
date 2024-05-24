using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_II
{
    public class User
    {
        private string username;
        private string password;
        private string email;
        private string name;
        private int operations;

        public User(string username, string password, string email, string name)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.name = name;
            this.operations = 0;
        } 

        public void AddOperation()
        {
            this.operations++;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetOperations()
        {
            return this.operations;
        }
    }
}
