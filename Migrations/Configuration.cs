
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ConsoleApplication3.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApplication3.BlockDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}