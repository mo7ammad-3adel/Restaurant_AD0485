using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_AD0485
{
    class user
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public user(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
