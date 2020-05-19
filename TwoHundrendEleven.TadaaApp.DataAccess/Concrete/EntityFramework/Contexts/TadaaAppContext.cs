using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities.Concrete;
using TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Mappings;
using TwoHundrendEleven.TadaaApp.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Contexts
{
    public class TadaaAppContext : DbContext
    {
        public DbSet<List> Lists { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Şimdilik connectionString i burda tut ama daha sonra , appsettings altına taşı.
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TadaaApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ListMap());
            modelBuilder.ApplyConfiguration(new TaskMap());
            modelBuilder.ApplyConfiguration(new PersonMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new OperationClaimMap());
            modelBuilder.ApplyConfiguration(new UserOperationClaimMap());


        }

    }
}
