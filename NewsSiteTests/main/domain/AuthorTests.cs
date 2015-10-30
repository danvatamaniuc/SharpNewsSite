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
    public class AuthorTests
    {
        [TestMethod()]
        public void AuthorTest()
        {
            Author author = new Author("name", 21);

            //testing the constructor
            Assert.AreEqual("name", author.Name);
            Assert.AreEqual(21, author.Age);

            //testing get and set for id
            author.Id = 1;
            Assert.AreEqual(1, author.Id);

            //testing get and set for name
            author.Name = "test";
            Assert.AreEqual("test", author.Name);

            //testing get and set for age
            author.Age = 1;
            Assert.AreEqual(1, author.Age);
        }
    }
}