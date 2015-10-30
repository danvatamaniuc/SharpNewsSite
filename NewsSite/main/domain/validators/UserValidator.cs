using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyData.domain;
using NewsSite.main.exceptions;

namespace NewsSite.main.domain.validators
{
    public class UserValidator : Validator<User>
    {
        public void Validate(User user)
        {
            if (user.Username == "")
            {
                throw new ValidationException("Invalid username!");
            }
        }
    }
}
