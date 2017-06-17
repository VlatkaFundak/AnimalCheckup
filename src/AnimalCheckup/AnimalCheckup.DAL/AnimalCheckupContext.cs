using System.Data.Entity;

namespace AnimalCheckup.DAL
{
    public class AnimalCheckupContext : DbContext
    {
        public AnimalCheckupContext() : base("AnimalCheckup")
        {
        }

        public DbSet<Models.UserEntity> Users { get; set; }

        public DbSet<Models.UserProfileEntity> UsersProfiles { get; set; }

        public DbSet<Models.OwnerEntity> Owners { get; set; }

        public DbSet<Models.AnimalEntity> Animals { get; set; }

        public DbSet<Models.CategoryEntity> Categories { get; set; }

        public DbSet<Models.JobEntity> Jobs { get; set; }
    }
}