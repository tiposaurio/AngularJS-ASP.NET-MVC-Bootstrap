﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSFinancial.Data
{
    public class BSFinancialContext : DbContext
    {
        public BSFinancialContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<BSFinancialContext, BSFinancialMigrationsConfiguration>()
                );
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
//             modelBuilder.Entity<Application>()
//                         .HasRequired(m => m.applicant)
//                         .WithMany(t => t.Applicants)
//                         .HasForeignKey(m => m.ApplicantId)
//                         .WillCascadeOnDelete(false);
// 
//             modelBuilder.Entity<Application>()
//                         .HasRequired(m => m.co_applicant)
//                         .WithMany(t => t.CoApplicants)
//                         .HasForeignKey(m => m.CoApplicantId)
//                         .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }
        public DbSet<ContactModel> Inquiries { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApplicantAddr> ApplicantAddrs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}