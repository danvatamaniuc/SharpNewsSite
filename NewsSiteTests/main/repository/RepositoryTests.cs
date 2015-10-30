using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsSite.main.repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSite.main.domain;
using NewsSite.main.domain.validators;
using NewsSite.main.utils;

namespace NewsSite.main.repository.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
//        private GenericRepository<User> _userRepository = new GenericRepository<User>();
//        private GenericRepository<Author> _authorRepository = new GenericRepository<Author>();
//        private GenericRepository<Article> _articleRepository = new GenericRepository<Article>();

        private User user = new User(Constants.StringTest);
        private Author author = new Author(Constants.StringTest, Constants.AgeTest);
        private Article article = new Article(Constants.StringTest, Constants.StringTest);

        private AuthorRepo _authorRepository = new AuthorRepo();
        private ArticleRepo _articleRepository = new ArticleRepo();
        private UserRepo _userRepository = new UserRepo();

        UserValidator userValidator = new UserValidator();
        ArticleValidator articleValidator = new ArticleValidator();
        AuthorValidator authorValidator = new AuthorValidator();

        [TestMethod()]
        public void RepoTest()
        {
            Assert.AreEqual(1,1);

            _userRepository.SetValidator(userValidator);
            _articleRepository.SetValidator(articleValidator);
            _authorRepository.SetValidator(authorValidator);


            _userRepository.Save(user);
            _authorRepository.Save(author);
            _articleRepository.Save(article);

            ArrayList users = _userRepository.GetAll();
            ArrayList authors = _authorRepository.GetAll();
            ArrayList articles = _articleRepository.GetAll();

            Assert.IsNotNull(users[0]);

            User userResult = (User) users[0];
            Author authorResult = (Author) authors[0];
            Article articleResult = (Article) articles[0];


//            Assert.AreEqual(Constants.StringTest, userResult.Username);
//            Assert.AreEqual(Constants.StringTest, authorResult.Name);
//            Assert.AreEqual(Constants.StringTest, articleResult.Title);
        }
    }
}