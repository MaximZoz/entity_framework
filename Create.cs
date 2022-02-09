using System;
using System.Linq;

namespace ConsoleApplication3
{
    public class Create
    {
        public static void User(string name, string login, string password)
        {
            using (BlockDbContext db = new BlockDbContext())
            {
                // создаем User
                var users = db.Users.ToList();
                var findUser = users.Exists(u => u.Login == login);
                if (findUser)
                    Console.WriteLine($@"пользователь с логином {login} уже есть");
                else
                {
                    var user = new User
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Password = password,
                        Login = login
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                    Console.WriteLine($@"пользователь с логином {login} создан");
                }
            }
        }
    }
}