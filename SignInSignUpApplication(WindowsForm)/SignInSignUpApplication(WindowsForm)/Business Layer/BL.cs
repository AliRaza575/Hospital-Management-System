using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUpApplication_WindowsForm_.Business_Layer
{
    internal class BL
    {
        private string username;
        private string password;
        private string role;
        public BL(string username,string password,string role) 
        {
            this .username = username;
            this .password = password;
            this .role = role;
        }
        public BL(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.role = "NA";
        }
        public string getUserName()
        {
            return this .username; ;
        }
        public string getPassword()
        {
            return this.password ;
        }
        public string getRole()
        {
            return  this.role;
        }
        bool isAdmin()
        {
            if (role=="Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
