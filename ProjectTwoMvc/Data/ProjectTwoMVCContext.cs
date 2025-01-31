
using Microsoft.EntityFrameworkCore;
using ProjectTwoMVC.Backend.Models.Entities;

namespace ProjectTwoMVC.Data
{
    public class ProjectTwoMvcContext : DbContext
    {
        public ProjectTwoMvcContext(DbContextOptions<ProjectTwoMvcContext> options)
        : base(options)
        {
        }

        public DbSet<Company> Company { get; set; } = default;       
    }
}
