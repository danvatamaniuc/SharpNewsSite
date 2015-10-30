using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyData.repos;
using NewsSite.main.domain;

namespace NewsSite.main.repository
{
    public class UserRepo : AbstractRepository<User>
    {
        public override void SetEntityId(User e)
        {
            e.Id = LastId;
        }
    }
}
