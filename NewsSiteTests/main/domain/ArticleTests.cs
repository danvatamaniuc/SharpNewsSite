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
    public class ArticleTests
    {

        [TestMethod()]
        public void ArticleTest()
        {

            Article article = new Article("title","content");

            //testing constructor
            Assert.AreEqual("title", article.Title);
            Assert.AreEqual("content", article.Content);

            //testing set and get for Id
            article.Id = 1;
            Assert.AreEqual(article.Id, 1);

            //testing set and get for Title
            article.Title = "test";
            Assert.AreEqual("test", article.Title);

            //testing set and get for Content
            article.Content = "test";
            Assert.AreEqual("test", article.Content);
        }

    }
}