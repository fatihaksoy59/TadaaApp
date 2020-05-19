using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Mappings
{
    class OperationClaimMap : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasKey(oc => oc.id);
            builder.Property(oc => oc.id).UseIdentityColumn();

            builder.Property(oc => oc.lastupdated);
            builder.Property(oc => oc.status);
            builder.Property(oc => oc.CreatedDateAndTime);

            builder.Property(oc => oc.Name).IsRequired();

        }
    }
}
