using System.Data.Entity;

namespace BibleVerseApplication.Models
{
    public class BibleVerseApplicationContext : DbContext
    {   
        public BibleVerseApplicationContext() : base("name=BibleVerseApplicationContext")
        {
        }
        public System.Data.Entity.DbSet<BibleVerseApplication.Models.BibleUserEntry> BibleUserEntries { get; set; }
    }
}
