using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComaxTask.AppSystem
{
public  class UserProfile
    {
        public int User_Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string User_Email { get; set; }

        public DateTime LastConnection { get; set; }
        public DateTime LastDisconnection { get; set; }
        public bool IsConnected { get; set; }
    }
}
