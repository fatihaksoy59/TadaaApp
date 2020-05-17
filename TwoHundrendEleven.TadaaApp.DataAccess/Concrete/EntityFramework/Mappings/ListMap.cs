using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwoHundrendEleven.TadaaApp.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ListMap : IEntityTypeConfiguration<List>
    {
        //Burası şimdilik ilişkisel değil ama ilişkisel yap.
        public void Configure(EntityTypeBuilder<List> builder)
        {
            builder.HasKey(l => l.id);
            builder.Property(l => l.id).UseIdentityColumn();

            builder.Property(l => l.lastupdated);
            builder.Property(l => l.status);
            
            builder.Property(l => l.userId).IsRequired();
            builder.Property(l => l.Name).IsRequired().HasMaxLength(15);
            builder.Property(l => l.CreatedDateAndTime).HasDefaultValue(DateTime.Now);
        }
    }
}
