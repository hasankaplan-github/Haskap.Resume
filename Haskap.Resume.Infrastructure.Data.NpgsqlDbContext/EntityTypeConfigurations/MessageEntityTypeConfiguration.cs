﻿using Haskap.Resume.Domain.Core.MessageAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haskap.Resume.Infrastructure.Data.NpgsqlDbContext.EntityTypeConfigurations;

public class MessageEntityTypeConfiguration : BaseEntityTypeConfiguration<Message>
{
    public override void Configure(EntityTypeBuilder<Message> builder)
    {
        base.Configure(builder); // Must call this

        // other configurations here
    }
}
