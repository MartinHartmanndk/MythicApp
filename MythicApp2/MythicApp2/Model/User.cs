using System;
using System.Collections.Generic;
using System.Text;

namespace MythicApp2.Model
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password; 
        }

        public bool CheckInformation()
        {
            if(UserName != null && Password != null && UserName != "" && Password != "")
            {
                return true;
            }
            else            
                return false;            
        }
    }
}
