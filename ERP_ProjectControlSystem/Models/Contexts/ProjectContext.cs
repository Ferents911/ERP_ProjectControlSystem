using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_ProjectControlSystem.Models
{
    public class ProjectContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public ProjectContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=projectdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillProject>()
                .HasKey(x => new { x.SkillId, x.ProjectId });

            modelBuilder.Entity<SkillProject>()
                .HasOne(sp => sp.Skill)
                .WithMany(s => s.SkillProjects)
                .HasForeignKey(sp => sp.SkillId);

            modelBuilder.Entity<SkillProject>()
                .HasOne(sp => sp.Project)
                .WithMany(p => p.SkillProjects)
                .HasForeignKey(sp => sp.ProjectId);
        }
    }
}
