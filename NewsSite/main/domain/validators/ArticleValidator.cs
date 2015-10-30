using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyData.domain;
using NewsSite.main.exceptions;

namespace NewsSite.main.domain.validators
{
    public class ArticleValidator : Validator<Article>
    {
        public void Validate(Article article)
        {
            String message = "";
            if (article.Title == "")
            {
                message += "Invalid title!";
//                throw new ValidationException("Invalid title!");
            }

            if (article.Content == "")
            {
                message += "and Invalid content!";
//                throw new ValidationException("Invalid content!");
            }

            if (message != "")
            {
                throw new ValidationException(message);
            }


        }
    }
}
