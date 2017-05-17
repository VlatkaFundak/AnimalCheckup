using System.Data.Entity;

namespace AnimalCheckup.DAL
{
    public class AnimalCheckupContext : DbContext
    {
        public AnimalCheckupContext() : base("AnimalCheckup")
        {
        }

        public DbSet<Models.User> Users { get; set; }
    }
}