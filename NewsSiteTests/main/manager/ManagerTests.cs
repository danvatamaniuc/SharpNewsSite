using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsSite.main.manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyData.utils;
using NewsSite.main.domain;
using NewsSite.main.domain.validators;
using NewsSite.main.repository;

namespace NewsSite.main.manager.Tests
{
    [TestClass()]
    public class ManagerTests
    {
//        private GenericRepository<User> userRepo = new GenericRepository<User>();
//        private GenericRepository<Author> authorRepo = new GenericRepository<Author>();
//        private GenericRepository<Article> articleRepo = new GenericRepository<Article>();

        private UserRepo userRepo = new UserRepo();
        private ArticleRepo articleRepo = new ArticleRepo();
        private AuthorRepo authorRepo = new AuthorRepo();

        private Manager manager;

        private User user = new User(Constants.StringTest);
        private Author author = new Author(Constants.StringTest, Constants.AgeTest);
        private Article article = new Article(Constants.StringTest, Constants.StringTest);


        UserValidator userValidator = new UserValidator();
        ArticleValidator articleValidator = new ArticleValidator();
        AuthorValidator authorValidator = new AuthorValidator();

        public ManagerTests()
        {
            userRepo.SetValidator(userValidator);
            articleRepo.SetValidator(articleValidator);
            authorRepo.SetValidator(authorValidator);

            manager = new Manager(userRepo, authorRepo, articleRepo);
        }

        [TestMethod()]
        public void SaveTest()
        {
            manager.Save(user);
            ArrayList users = userRepo.GetAll();

            User user2 = (User) users[0];
            Assert.AreEqual(Constants.StringTest, user2.Username);
        }

        [TestMethod()]
        public void SaveTest1()
        {
            manager.Save(author);
            ArrayList authors = authorRepo.GetAll();

            Author author2 = (Author) authors[0];
            Assert.AreEqual(Constants.StringTest, author2.Name);
            Assert.AreEqual(Constants.AgeTest, author2.Age);
        }

        [TestMethod()]
        public void SaveTest2()
        {
            manager.Save(article);
            ArrayList articles = articleRepo.GetAll();

            Article article2 = (Article) articles[0];
            Assert.AreEqual(Constants.StringTest, article2.Title);
            Assert.AreEqual(Constants.StringTest, article2.Content);
        }
    }
}