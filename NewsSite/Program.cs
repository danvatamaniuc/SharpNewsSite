using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSite.main.domain.validators;
using NewsSite.main.manager;
using NewsSite.main.repository;

namespace NewsSite
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepo userRepo = new UserRepo();
            ArticleRepo articleRepo = new ArticleRepo();
            AuthorRepo authorRepo = new AuthorRepo();

            UserValidator userValidator = new UserValidator();
            ArticleValidator articleValidator = new ArticleValidator();
            AuthorValidator authorValidator = new AuthorValidator();

            userRepo.SetValidator(userValidator);
            articleRepo.SetValidator(articleValidator);
            authorRepo.SetValidator(authorValidator);

            Manager manager = new Manager(userRepo, authorRepo, articleRepo);

            ConsoleUI console = new ConsoleUI(manager);
            console.Run();
         }
    }
}
