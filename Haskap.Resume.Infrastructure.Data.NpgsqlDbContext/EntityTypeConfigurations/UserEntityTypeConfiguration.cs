using Haskap.Resume.Domain.Core.UserAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haskap.Resume.Infrastructure.Data.NpgsqlDbContext.EntityTypeConfigurations;

public class UserEntityTypeConfiguration : BaseEntityTypeConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder); // Must call this

        // other configurations here
        builder.Property(x => x.FirstName).IsRequired();
        builder.Property(x => x.LastName).IsRequired();
        builder.Property(x => x.Password).IsRequired();
        builder.Property(x => x.UserName).IsRequired();
    }
}
