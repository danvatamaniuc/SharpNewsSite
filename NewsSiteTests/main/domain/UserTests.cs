using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsSite.main.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSite.main.domain.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void UserTest()
        {
            User user = new User("username");

            //testing constructor
            Assert.AreEqual("username", user.Username);

            //testing get and set id
            user.Id = 1;
            Assert.AreEqual(1, user.Id);

            //testing get and set username
            user.Username = "test";
            Assert.AreEqual("test", user.Username);
        }
    }
}