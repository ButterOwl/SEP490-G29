using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bcrypt = BCrypt.Net.BCrypt;

namespace InternshipHub.Models
{
    public class LabInternManagementDBcontext : IdentityDbContext<User>
    {
        public LabInternManagementDBcontext() { }

        public LabInternManagementDBcontext(DbContextOptions<LabInternManagementDBcontext> option)
            : base(option) { }

        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Attendance> Attendances { get; set; } = null!;
        public virtual DbSet<IdentityRole> Roles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<IdentityUser>()
                .HasData(
                    new User
                    {
                        Email = "admin@fpt.edu.vn",
                        PasswordHash = Bcrypt.HashPassword("adminlabsu24")
                    },
                    new User
                    {
                        Email = "mentor@fpt.edu.vn",
                        PasswordHash = Bcrypt.HashPassword("mentorlabsu24")
                    },
                    new User
                    {
                        Email = "intern1@fpt.edu.vn",
                        PasswordHash = Bcrypt.HashPassword("internlabsu24"),
                    },
                    new User
                    {
                        Email = "intern2@fpt.edu.vn",
                        PasswordHash = Bcrypt.HashPassword("internlabsu24")
                    },
                    new User
                    {
                        Email = "intern3@fpt.edu.vn",
                        PasswordHash = Bcrypt.HashPassword("internlabsu24"),
                    }
                );
            modelBuilder
                .Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Name = "System Admin" },
                    new IdentityRole { Name = "Mentor" },
                    new IdentityRole { Name = "Member" }
                );
            modelBuilder
                .Entity<IdentityUserRole<int>>()
                .HasData(
                    new IdentityUserRole<int> { RoleId = 1, UserId = 1 },
                    new IdentityUserRole<int> { RoleId = 2, UserId = 2 },
                    new IdentityUserRole<int> { RoleId = 3, UserId = 4 },
                    new IdentityUserRole<int> { RoleId = 3, UserId = 5 },
                    new IdentityUserRole<int> { RoleId = 3, UserId = 6 }
                );
        }
    }
}
