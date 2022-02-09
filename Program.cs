using System;
using System.Linq;

namespace ConsoleApplication3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new BlockDbContext())
            {
                db.Database.CreateIfNotExists();
                Create.User("Maxim2", "max12345", "12345");
            }
        }
    }
}