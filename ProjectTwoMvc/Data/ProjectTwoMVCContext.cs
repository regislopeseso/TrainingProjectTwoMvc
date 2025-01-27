
using Microsoft.EntityFrameworkCore;
using ProjectTwoMVC.Backend.Models.Entities;

namespace ProjectTwoMVC.Data
{
    public class ProjectTwoMVCContext : DbContext
    {
        public ProjectTwoMVCContext(DbContextOptions<ProjectTwoMVCContext> options)
        : base(options)
        {
        }

        public DbSet<Company> Company { get; set; } = default;       
    }
}
