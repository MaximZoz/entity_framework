using System;
using System.Linq;

namespace ConsoleApplication3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            using (BlockDbContext db = new BlockDbContext())
            {
                // создаем объекты постов
                var p1 = new Post
                {
                    Id = Guid.NewGuid(), Title = "new post learn rider entity framework", Content = "new content",
                    Published = DateTime.Now
                };
                var p2 = new Post
                {
                    Id = Guid.NewGuid(), Title = "new post learn C#", Content = "old content",
                    Published = DateTime.Now
                };
                
                // добавляем их в бд
                
                // db.Posts.Add(p1);
                // db.Posts.Add(p2);
                // db.SaveChanges();
                
                //обновляем объект первый из таблицы
                var firstPost = db.Posts.FirstOrDefault();
                // if (firstPost != null) firstPost.Content = "new content";
                
                // db.SaveChanges();
                
                // получаем объекты из бд, выводим в консоль
                var posts = db.Posts.ToList();
                foreach (var p in posts)
                {
                    Console.WriteLine($@"{p.Title} - {p.Published}");
                    p.Content = "new";
                }
                
                var c1 = new Comment
                {
                    Id = db.Posts.FirstOrDefault().Id, Username = "Maxim", Text = "good work",
                };
                
                db.Comments.Add(c1);
                db.SaveChanges();
            }
        }
    }
}