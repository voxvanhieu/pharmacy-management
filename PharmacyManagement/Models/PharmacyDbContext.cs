using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Models
{
    public class PharmacyDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Commodity> Commodities { get; set; }
        public virtual DbSet<CommodityType> CommodityTypes { get; set; }

        public PharmacyDbContext()
            : base("DefaultDb")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<PharmacyDbContext>());

            //Database.SetInitializer(new DropCreateDatabaseAlways<PharmacyDbContext>());

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<PharmacyDbContext,
                Migrations.Configuration>());
        }

        public static PharmacyDbContext Create() => new PharmacyDbContext();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }

    public class UserIdentity : IDisposable
    {
        private bool _disposed;
        private PharmacyDbContext dbContext;

        public static User SessionUser { get; set; }

        public UserIdentity()
        {
            dbContext = PharmacyDbContext.Create();
        }

        public bool Validate(string username, string password)
        {
            User user = dbContext.Users
                            .Where(u => u.UserName == username)
                            .FirstOrDefault();

            if (user is null) return false;

            return (user.PasswordHash == GetPasswordHash(password));
        }

        public void RegisterUser(User user, string password, string roleName)
        {
            user.PasswordHash = GetPasswordHash(password);
            if (dbContext.Roles.Any(r => r.Name == roleName))
            {
                int roleId = dbContext.Roles.Single(r => r.Name == roleName).Id;
                user.RoleId = roleId;

                dbContext.Users.Add(user);

                dbContext.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"Role {roleName} is not in the database.");
            }
        }

        public int CreateRole(string roleName)
        {
            var role = dbContext.Roles.SingleOrDefault(r => r.Name == roleName);

            if (role is null)
            {
                role = new Role { Name = roleName };
                dbContext.Roles.Add(role);
                dbContext.SaveChanges();
                return role.Id;
            }
            else return role.Id;
        }

        public bool IsInRole(User user, string roleName)
        {
            return user.Role.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase);
        }

        public bool ChangeRole(string username, string roleName)
        {
            var user = dbContext.Users.SingleOrDefault(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (user != null)
            {
                user.Role = dbContext.Roles.SingleOrDefault(r => r.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase));
                if (user.Role != null)
                {
                    dbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            if (Validate(username, oldPassword))
            {
                User user = dbContext.Users
                            .Where(u => u.UserName == username)
                            .FirstOrDefault();

                if (user is null) return false;

                user.PasswordHash = GetPasswordHash(newPassword);

                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        private string GetPasswordHash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            // Dispose of managed resources here.
            if (disposing)
            {
                dbContext?.Dispose();
            }

            // Dispose of any unmanaged resources not wrapped in safe handles.

            _disposed = true;
        }
    }
}
