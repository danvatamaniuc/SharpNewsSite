using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyData.repos;
using NewsSite.main.domain;

namespace NewsSite.main.repository
{
    public class ArticleRepo : AbstractRepository<Article>
    {
        public override void SetEntityId(Article e)
        {
            e.Id = LastId;
        }
    }
}
