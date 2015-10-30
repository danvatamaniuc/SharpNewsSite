using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSite.main.domain;
using NewsSite.main.repository;

namespace NewsSite.main.manager
{
    public class Manager
    {
        private UserRepo _userGenericRepository;
        private AuthorRepo _authorGenericRepository;
        private ArticleRepo _articleGenericRepository;

        public Manager(UserRepo _userGenericRepository, 
                       AuthorRepo _authorGenericRepository, 
                       ArticleRepo _articleGenericRepository)
        {
            this._userGenericRepository = _userGenericRepository;
            this._authorGenericRepository = _authorGenericRepository;
            this._articleGenericRepository = _articleGenericRepository;
        }

        public void Save(User user)
        {
            _userGenericRepository.Save(user);
        }

        public void Save(Author author)
        {
            _authorGenericRepository.Save(author);
        }

        public void Save(Article article)
        {
            _articleGenericRepository.Save(article);
        }

        public ArrayList GetAllNews()
        {
            return _articleGenericRepository.GetAll();
        }
    }
}
