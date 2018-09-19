﻿using System.Data.Entity;

namespace BibleVerseApplication.Models
{
    public class BibleVerseApplicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BibleVerseApplicationContext() : base("name=BibleVerseApplicationContext")
        {
        }

        public System.Data.Entity.DbSet<BibleVerseApplication.Models.BibleUserEntry> BibleUserEntries { get; set; }

        public System.Data.Entity.DbSet<BibleVerseApplication.Models.Login> Logins { get; set; }
    }
}
