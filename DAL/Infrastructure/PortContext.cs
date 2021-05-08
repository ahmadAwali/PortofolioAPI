using Microsoft.EntityFrameworkCore;
using MODELS.PortoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Infrastructure
{
    public class PortContext : DbContext
    {
        public PortContext(DbContextOptions<PortContext> options) : base(options)
        {
            
        }
        public DbSet<PersonInfo> PersonInfos { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Portofolio> Portofolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PersonInfo
            modelBuilder.Entity<PersonInfo>().Property(x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<PersonInfo>().Property(x => x.FamilyName).HasMaxLength(50);
            modelBuilder.Entity<PersonInfo>().Property(x => x.GrandFatharName).HasMaxLength(50);
            modelBuilder.Entity<PersonInfo>().Property(x => x.FamilyName).HasMaxLength(50);
            modelBuilder.Entity<PersonInfo>().Property(x => x.PhoneNmber).HasMaxLength(15);
            modelBuilder.Entity<PersonInfo>().Property(x => x.Email).HasMaxLength(50);
            modelBuilder.Entity<PersonInfo>().Property(x => x.AboutMe).HasMaxLength(1000);
            modelBuilder.Entity<PersonInfo>().Property(x => x.Slogan).HasMaxLength(500);

            //Education
            modelBuilder.Entity<Education>().Property(x => x.OrganizationName).HasMaxLength(50);
            modelBuilder.Entity<Education>().Property(x => x.OrganizationTitle).HasMaxLength(20);
            modelBuilder.Entity<Education>().Property(x => x.Specialty).HasMaxLength(50);
            modelBuilder.Entity<Education>().Property(x => x.Degree).HasMaxLength(20);
            modelBuilder.Entity<Education>().Property(x => x.GraduationProject).HasMaxLength(2000);
            modelBuilder.Entity<Education>().Property(x => x.Certificate).HasMaxLength(2000);
            modelBuilder.Entity<Education>().Property(x => x.Description).HasMaxLength(2000);

            //Experience
            modelBuilder.Entity<Experience>().Property(x => x.Workplace).HasMaxLength(50);
            modelBuilder.Entity<Experience>().Property(x => x.Title).HasMaxLength(50);
            modelBuilder.Entity<Experience>().Property(x => x.Description).HasMaxLength(2000);

            //Image
            modelBuilder.Entity<Image>().Property(x => x.Name).HasMaxLength(50);

            //Portofolio
            modelBuilder.Entity<Portofolio>().Property(x => x.ProjectName).HasMaxLength(50);
            modelBuilder.Entity<Portofolio>().Property(x => x.Role).HasMaxLength(20);
            modelBuilder.Entity<Portofolio>().Property(x => x.Description).HasMaxLength(2000);
            modelBuilder.Entity<Portofolio>().Property(x => x.Link).HasMaxLength(255);

            //Service
            modelBuilder.Entity<Service>().Property(x => x.ServiceIcon).HasMaxLength(50);
            modelBuilder.Entity<Service>().Property(x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<Service>().Property(x => x.Description).HasMaxLength(2000);

            //Skill
            modelBuilder.Entity<Skill>().Property(x => x.SkillName).HasMaxLength(50);
            modelBuilder.Entity<Skill>().Property(x => x.SkillIcon).HasMaxLength(50);
            modelBuilder.Entity<Skill>().Property(x => x.SkillColorIcon).HasMaxLength(50);

            //SocialMedia
            modelBuilder.Entity<SocialMedia>().Property(x => x.Name).HasMaxLength(50);
            modelBuilder.Entity<SocialMedia>().Property(x => x.Link).HasMaxLength(255);
            modelBuilder.Entity<SocialMedia>().Property(x => x.SkillColorIcon).HasMaxLength(50);
            modelBuilder.Entity<SocialMedia>().Property(x => x.SocialMediaIcon).HasMaxLength(50);


        }

    }
}
