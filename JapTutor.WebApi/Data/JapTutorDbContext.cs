using JapTutor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace JapTutor.WebApi.Data;

public class JapTutorDbContext : DbContext
{
    public JapTutorDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<BasicInfo> BasicInfos { get; set; }
}