using System;
using System.Collections;
using NewsSite.main.domain;
using NewsSite.main.manager;

namespace NewsSite
{
    internal class ConsoleUI
    {
        private Manager manager;

        public ConsoleUI(Manager manager)
        {
            this.manager = manager;
        }

        public void Run()
        {
            String command;
            bool work = true;

            while (work)
            {
                DisplayMenu();
                command = Console.ReadLine();
                switch (command)
                {
                    case "x":
                        work = false;
                        break;
                    case "1":
                        AddNews();
                        break;
                    case "2":
                        DisplayAllNews();
                        break;
                }
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("Menu------------------");
            Console.WriteLine("1: Adauga stire");
            Console.WriteLine("2: Afiseaza toate stirile");
            Console.WriteLine("x: Iesire");
        }

        private void AddNews()
        {
            String title;
            String content;

            Console.WriteLine("Titlul:");
            title = Console.ReadLine();

            Console.WriteLine("Content:");
            content = Console.ReadLine();

            Article article = new Article(title, content);

            try
            {
                manager.Save(article);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void DisplayAllNews()
        {
            ArrayList articles = manager.GetAllNews();

            Article article;
            foreach (var item in articles)
            {
                article = (Article) item;

                Console.WriteLine(article.Title);
                Console.WriteLine(article.Content);
            }

            if (articles.Count == 0)
            {
                Console.WriteLine("Nu sunt stiri!");
            }
        }
    }
}