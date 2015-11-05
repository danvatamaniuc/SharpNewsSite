using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSite.main.domain
{

    public class Article
    {
        private int     id;
        private String  title;
        private String  content;

        public Article()
        {
        }

        public Article(string title, string content)
        {
            this.title   = title;
            this.content = content;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
