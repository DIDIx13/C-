using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class User
    {
        private string strUser;

        public User()
        {

        }

        public User(User user)
        {
            getUser(user);
        }

        public void setUser(string user)
        {
            this.strUser = user;
        }

        public string getUser(User user)
        {
            return this.strUser;
        }

        public override string ToString()
        {
            return "Bonjour " + strUser;
        }
    }
}
