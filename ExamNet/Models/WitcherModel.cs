using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ExamNet
{
    public partial class WitcherModel : DbContext
    {
        public WitcherModel()
            : base("name=WitcherModel")
        {
        }

        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chapter>()
                .HasMany(e => e.Characters)
                .WithRequired(e => e.Chapter)
                .HasForeignKey(e => e.Chapter_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
