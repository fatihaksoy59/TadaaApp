using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Mappings
{
    class UserOperationClaimMap : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasKey(uop => uop.id);
            builder.Property(uop => uop.id).UseIdentityColumn();

            builder.Property(uop => uop.lastupdated);
            builder.Property(uop => uop.status);
            builder.Property(uop => uop.CreatedDateAndTime);

            builder.Property(uop => uop.userId).IsRequired();
            builder.Property(uop => uop.OperationClaimId).IsRequired();


        }
    }
}
