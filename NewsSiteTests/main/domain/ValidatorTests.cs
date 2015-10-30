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
    public class ValidatorTests
    {

        private Validator validator = new Validator();
        [TestMethod()]
        public void ValidateTest()
        {
            Author author = new Author("ad",-1);
            try
            {
                validator.Validate(author);
                Assert.AreEqual(1, 2);
            }
            catch (Exception)
            {
                Assert.AreEqual(1, 1);
            }

            author.Age = 45;

            try
            {
                validator.Validate(author);
                Assert.AreEqual(1,1);
            }
            catch (Exception)
            {
                Assert.AreEqual(1,2);
            }
        }

        [TestMethod()]
        public void ValidateTest1()
        {
            User user = new User("");
            try
            {
                validator.Validate(user);
                Assert.AreEqual(1, 2);
            }
            catch (Exception)
            {
                Assert.AreEqual(1, 1);
            }

            user.Username = "a";

            try
            {
                validator.Validate(user);
                Assert.AreEqual(1, 1);
            }
            catch (Exception)
            {
                Assert.AreEqual(1, 2);
            }
        }

        [TestMethod()]
        public void ValidateTest2()
        {
            Article article = new Article("", "");
            try
            {
                validator.Validate(article);
                Assert.AreEqual(1, 2);
            }
            catch (Exception)
            {
                Assert.AreEqual(1, 1);
            }

            article.Title = "a";
            article.Content = "a";

            try
            {
                validator.Validate(article);
                Assert.AreEqual(1, 1);
            }
            catch (Exception)
            {
                Assert.AreEqual(1, 2);
            }
        }
    }
}