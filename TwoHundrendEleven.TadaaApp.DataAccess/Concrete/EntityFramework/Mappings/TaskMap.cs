using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwoHundrendEleven.TadaaApp.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TaskMap:IEntityTypeConfiguration<Task>
    {
        //Burası şimdilik ilişkisel değil ama ilişkisel yap.
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(t => t.id);
            builder.Property(t => t.id).UseIdentityColumn();

            builder.Property(t => t.lastupdated);
            builder.Property(t => t.status).HasDefaultValue(1);
            builder.Property(t => t.CreatedDateAndTime);

            builder.Property(t => t.listId).IsRequired();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(15);
            builder.Property(t => t.TaskExplanation);
            builder.Property(t => t.TaskDateAndTime);
            builder.Property(t => t.isCompleted).HasDefaultValue(0);
            builder.Property(t => t.CompletedDateAndTime);
        }

    }
}
