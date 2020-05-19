using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Mappings
{
    class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.id);
            builder.Property(u => u.id).UseIdentityColumn();

            builder.Property(u => u.lastupdated);
            builder.Property(u => u.status);
            builder.Property(u => u.CreatedDateAndTime);


            builder.Property(u => u.personId);
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.PasswordSalt).IsRequired();
            builder.Property(u => u.PasswordHash).IsRequired();
        }
    }
}
