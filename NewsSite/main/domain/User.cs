using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSite.main.domain
{
    public class User
    {
        private String username;
        private int id;

        public User(string username)
        {
            this.username = username;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
