namespace PharmacyManagement.Migrations
{
    using PharmacyManagement.Models;
    using System;
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

            if (!context.Users.Any())
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

            if (!context.Commodities.Any())
            {
                CommodityType typeMedicine;

                if (!context.CommodityTypes.Any())
                {
                    typeMedicine = context.CommodityTypes.Add(new CommodityType { Name = "Medicine" });
                }
                else
                {
                    typeMedicine = context.CommodityTypes.First(t => t.Name.Equals("Medicine", StringComparison.OrdinalIgnoreCase));
                }
                context.Commodities.Add(new Commodity
                {
                    Name = "Augclamox 250",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Hà Tây",
                    Description = "Amoxicilin (dưới dạng Amoxicilin trihydrat); Acid clavulanic (dưới dạng Kali clavulanat)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Augclamox-250&VD-21647-14"
                });

                context.SaveChanges();
            }

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
