namespace PharmacyManagement.Migrations
{
    using PharmacyManagement.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PharmacyManagement.Models.PharmacyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PharmacyManagement.Models.PharmacyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //base.Seed(context);

            //context.Roles.AddRange(new List<Role>
            //{
            //    new Role{Name = "Admin"},
            //    new Role{Name = "Staff"}
            //});

            //context.Users.AddRange(new List<User>
            //{
            //    new User
            //    {
            //        UserName = "voxvanhieu",
            //        FullName = "Võ Văn Hiếu",
            //        Address = "Quảng Nam",
            //        Gender = true
            //    }
            //});

            //context.SaveChanges();

            if (!context.Roles.Any())
                using (UserIdentity identityService = new UserIdentity())
                {
                    var roleAdmin = identityService.CreateRole("Admin");
                    var roleStaff = identityService.CreateRole("Staff");
                    identityService.RegisterUser(
                        password: "123@123a", roleName: "Admin",
                        user: new User
                        {
                            UserName = "admin",
                            FullName = "Võ Văn Hiếu",
                            Address = "Không có địa chỉ",
                            Gender = true,
                            Birthday = new DateTime(1989, 8, 21),
                            Image = "",
                            RoleId = roleAdmin
                        });
                    identityService.RegisterUser(
                        password: "123@123a", roleName: "Staff",
                        user: new User
                        {
                            UserName = "voxvanhieu",
                            FullName = "Võ Văn Hiếu",
                            Address = "Quảng Nam",
                            Gender = true,
                            Birthday = new DateTime(1999, 9, 26),
                            Image = "",
                            RoleId = roleAdmin,
                        });
                }

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
