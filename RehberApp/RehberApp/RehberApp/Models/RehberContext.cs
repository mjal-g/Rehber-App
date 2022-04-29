using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RehberApp.Models
{
    public partial class RehberContext : DbContext
    {
        public RehberContext()
            : base("name=RehberContext")
        {
        }

        public virtual DbSet<Directory> Directory { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumber { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Directory)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.userId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Directory1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.recordedUserId);
        }
    }
}
