using oppguidedpw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_II
{
    public class State
    {
        private byte state;
        private Calculator calculator;
        
        private List<User> users = new List<User>();

        private int userposition;

        public int GetUserPosition()
        {
            return this.userposition;
        }
        
        public void SetUserPosition(int userposition)
        {
            this.userposition = userposition;
        }

        public State()
        {
            this.state = 1;
            this.calculator = new Calculator();
            this.ReadUsers();
        }

        public void ChangeState(byte state)
        {
            this.state = state;
        }

        public byte GetState()
        {
            return this.state;
        }

        public string PerformOperation(string operation)
        {
            
            return this.calculator.PerformOperation(operation).GetValue().ToString();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void ReadUsers()
        {
            StreamReader reader = new StreamReader("users.txt");
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                string[] info = line.Split(',');
                User user = new User(info[0], info[1], info[2], info[3]);
                users.Add(user);
            }
            reader.Close();
        }

        public void LogIn(string username, string password)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].GetUsername() == username && users[i].GetPassword() == password)
                {
                    this.ChangeState(2);
                    this.userposition = i;
                    break;
                }
            }
        }

        public User GetCurrentUser()
        {
            return users[this.userposition];
        }

        public void WriteUsers()
        {
            StreamWriter writer = new StreamWriter("users.txt");
            for (int i = 0; i < users.Count; i++)
            {
                writer.WriteLine(users[i].GetUsername() + "," + users[i].GetPassword() + "," + users[i].GetEmail() + "," + users[i].GetName());
            }
            writer.Close();
        }

        public void ChangeUser(string username, string password, string email, string name)
        {
            users[this.userposition] = new User(username, password, email, name);
        }

        public bool searchUser(string name, string username, string email)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].GetName() == name && users[i].GetUsername() == username && users[i].GetEmail() == email)
                {
                    this.userposition = i;
                    return true;
                }
            }
            return false;
        }
        
    }
}