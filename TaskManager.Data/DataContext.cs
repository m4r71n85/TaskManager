using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TaskManager.Data.Migrations;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class DataContext:DbContext
    {
        public DataContext()
            : base("TaskManagerConnection")
        {

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }

        public IDbSet<Issue> Issues { get; set; }
        public IDbSet<Comment> Comments { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}
