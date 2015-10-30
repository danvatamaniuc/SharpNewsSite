using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyData.domain;
using NewsSite.main.exceptions;

namespace NewsSite.main.domain.validators
{
    public class AuthorValidator : Validator<Author>
    {
        public void Validate(Author author)
        {
            if (author.Age < 0)
            {
                throw new ValidationException("Invalid age!");
            }
        }
    }
}
