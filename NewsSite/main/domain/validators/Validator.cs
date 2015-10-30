using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSite.main.exceptions;

namespace NewsSite.main.domain
{
    public class Validator
    {
        public void Validate(Author author)
        {
            if (author.Age < 0)
            {
                throw new ValidationException("Invalid age!");
            }
        }

        public void Validate(User user)
        {
            if (user.Username == "")
            {
                throw new ValidationException("Invalid username!");
            }
        }

        public void Validate(Article article)
        {
            if (article.Title == "")
            {
                throw new ValidationException("Invalid title!");
            }

            if (article.Content == "")
            {
                throw new ValidationException("Invalid content!");
            }
        }
    }
}
