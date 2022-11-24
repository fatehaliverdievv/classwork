using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork.Models
{
    internal class User
    {
        private string _username;
        private string _password;
        private bool _isSignedin;


        public string Username
        {
            get { return _username; }
            set
            {
                value = value.Trim();
                if (value.Length >= 6 && value.Length <= 25)
                {
                    _username = value;
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (HasLower(value) && HasUpper(value) && HasDigit(value) && value.Length >= 8 && value.Length <= 25)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("wrong password");
                }
            }
        }
         
        public bool Checkpassword(string password)
        {
            this.Password = password;
            for (int i = 0; i < password.Length; i++)
            {

            if (HasLower(password) && HasUpper(password) && HasDigit(password) && password.Length >= 8 && password.Length <= 25)
            {
                    return true;
            }
            }
            return false;
        }





        public bool HasDigit(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string Password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (char.IsUpper(Password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasLower(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Issignedin
        {
            get
        }


    }
}
