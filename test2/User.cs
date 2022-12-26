using System;
using System.Collections.Generic;
using System.Text;

namespace test_26122022
{
    internal class User
    {
       
        
        private string _username;
        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                if (CheckPass(value) && HasLower(value) && HasDigit(value) && HasUpper(value))
                {
                    _password = value;

                }
            }
            

        }

        public string Username
        {
            get => _username;
            set
            {
                if (CheckUser(value) && HasLower(value) && HasDigit(value) && HasUpper(value))
                {
                    _username= value;

                }

            }

        }


        private bool CheckUser(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetterOrDigit(str[i]))
                        return false;
                    else if (str[i] >= 6 && str[i] <= 25)
                    {
                        return true;
                    }
                }
                return true;

            }
            return false;
        }

        private bool CheckPass(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetterOrDigit(str[i]))
                        return false;   
                    else if (str[i] >= 8 && str[i] <= 25)
                    {
                        return true;    
                    }
                }
                return true;

            }
            return false;   
        }

        private bool HasDigit(string str) 
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetterOrDigit(str[i]) == true)
                    return true;

            }
            return false;
        }

        private bool HasUpper(string str) 
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]) == true)
                {
                    return true;
                }

            }
            return false;
            
        }

        private bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]) == true)
                {
                    return true;
                }

            }
            return false;

        }
        public string ShowInfo()
        {
            return $"Username: {_username} - Password: {_password}";
        }

        internal bool ShowUserInfo(string v)
        {
            throw new NotImplementedException( ShowInfo());
        }
    }
}
