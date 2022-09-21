using System;
using System.Collections.Generic;
using System.Text;

namespace HOME_TASK_TO_24_SEP
{
    public class UserReg
    {
        public string UserName { get; set; }
        public int Password { get; set; }


        public UserReg(string username, int password)
        {
            this.UserName = username;
            this.Password = password;
        }

    }
}
