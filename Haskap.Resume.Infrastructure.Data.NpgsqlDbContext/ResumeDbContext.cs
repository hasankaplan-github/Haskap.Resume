using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Haskap.DddBase.Infrastructure.Data.EfCoreDbContexts.NpgsqlDbContext;
using Haskap.Resume.Domain.Core.MessageAggregate;
using Haskap.Resume.Domain.Core.UserAggregate;

namespace Haskap.Resume.Infrastructure.Data.NpgsqlDbContext;

public class ResumeDbContext : BaseEfCoreNpgsqlDbContext
{
    public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(ResumeDbContext).Assembly);            
        
        base.OnModelCreating(builder);
    }
}
