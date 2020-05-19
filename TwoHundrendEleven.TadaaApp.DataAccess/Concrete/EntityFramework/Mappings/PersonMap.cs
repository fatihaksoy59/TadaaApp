using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwoHundrendEleven.TadaaApp.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        //Burası şimdilik ilişkisel değil ama ilişkisel yap.
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).UseIdentityColumn();

            builder.Property(p => p.lastupdated);
            builder.Property(p => p.status).HasDefaultValue(1);
            builder.Property(p => p.CreatedDateAndTime);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.BirthDate);



        }
    }
}

