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
            {
                context.Database.ExecuteSqlCommand(@"CREATE VIEW [dbo].[V_Comodity] AS"
                                                   + " SELECT [Commodities].Id, [Commodities].Name, [CommodityTypes].Name as Type, Description, Provider, TotalQuantity, BaseUnitName, BaseUnitPrice, ReferenceLink, Created"
                                                   + " FROM [Commodities] INNER JOIN [CommodityTypes] ON [Commodities].Type_Id = [CommodityTypes].Id"
                                                   + " WITH CHECK OPTION;");

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
                    CommodityType typeMedicine, typeOther;

                    if (!context.CommodityTypes.Any())
                    {
                        typeMedicine = context.CommodityTypes.Add(new CommodityType { Name = "Medicine" });
                        typeOther = context.CommodityTypes.Add(new CommodityType { Name = "Other" });
                    }
                    else
                    {
                        typeMedicine = context.CommodityTypes.First(t => t.Name.Equals("Medicine", StringComparison.OrdinalIgnoreCase));
                        typeOther = context.CommodityTypes.First(t => t.Name.Equals("Other", StringComparison.OrdinalIgnoreCase));
                    }
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Augclamox 250",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "Công ty cổ phần dược phẩm Hà Tây",
                        Description = "Amoxicilin (dưới dạng Amoxicilin trihydrat); Acid clavulanic (dưới dạng Kali clavulanat)",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Augclamox-250&VD-21647-14"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Casoran",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "Công ty cổ phần công nghệ cao Traphaco",
                        Description = "Cao hoa hòe (3:1) ; Cao dừa cạn (6:1) ; Cao tâm sen (4:1) ; Cao cúc hoa (3:1)",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Casoran&VD-23889-15"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Docetaxel 20mg",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "Teva Pharmaceutical Works Private Limited Company",
                        Description = "Docetaxel",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Docetaxel-20mg&VN-17674-14"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Hà thủ ô",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "Công ty cổ phần công nghệ cao Traphaco",
                        Description = "Cao đặc rễ hà thủ ô đỏ",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Ha-thu-o&VD-24071-16"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "1-AL",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "FDC Limited",
                        Description = "Levocetirizine (dưới dạng Levocetirizine dihydrochloride)",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/1-AL&VN-17635-14"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "20% Fat Emulsion Injection",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Guangdong Otsuka Pharmaceutical Co., Ltd.",
                        Description = "Soybean oil",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/20%-Fat-Emulsion-Injection&VN-19115-15"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "3B-Medi",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần dược phẩm Me Di Sun",
                        Description = "Vitamin B1; Vitamin B6; Vitamin B12",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/3B-Medi&VD-22915-15"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "3B-Medi tab",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần dược phẩm Me Di Sun",
                        Description = "Vitamin B1 (Thiamin mononitrat) ; Vitamin B6 (Pyridoxin hydroclorid) ; Vitamin B12 (Cyanocobalamin)",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/3B-Medi-tab&VD-26870-17"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "3BTP",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần dược phẩm Hà Tây",
                        Description = "Vitamin B1 (Thiamin nitrat) ; Vitamin B6 (Pyridoxin hydroclorid) ; Vitamin B12 (Cyanocobalamin)",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/3BTP&VD-26140-17"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "3Bpluzs F",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần Dược phẩm Phương Đông",
                        Description = "Vitamin B1; Vitamin B6 ; Vitamin B12; Sắt sulfat",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/3Bpluzs-F&VD-16258-12"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "3Bvit ando",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần dược phẩm Hà Tây",
                        Description = "Vitamin B1; Vitamin B6; Vitamin B12; Vitamin B2; Vitamin PP",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/3Bvit-ando&VD-17429-12"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "4-Epeedo-50",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Naprod Life Sciences Pvt. Ltd.",
                        Description = "Epirubicin hydrochloride",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/4-Epeedo-50&VN2-52-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "4.2% w/v Sodium Bicarbonate",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "B.Braun Melsungen AG",
                        Description = "Natri bicarbonat",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/4.2%-w/v-Sodium-Bicarbonate&VN-18586-15"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "5% Dextrose 500ml inj Infusion",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "Dai Han Pharm. Co., Ltd.",
                        Description = "Dextrose",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/5%-Dextrose-500ml-inj-Infusion&VN-16866-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "5-Fluorouracil \"Ebewe\"",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "Ebewe Pharma Ges.m.b.H.Nfg.KG",
                        Description = "5-Fluorouracil",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/5-Fluorouracil-Ebewe&VN-17422-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "8 Horas",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 10000,
                        Provider = "Laboratorio Elea S.A.C.I.F.yA",
                        Description = "Eszopiclone",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/8-Horas&VN2-112-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "9PM",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Cipla Ltd",
                        Description = "Latanoprost",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/9PM&VN-21186-18"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "A9 - Cerebrazel",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần dược TW Mediplantex",
                        Description = "Meclofenoxat hydroclorid",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/A9---Cerebrazel&VD-18416-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "ABAB 500mg",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần dược phẩm IMEXPHARM",
                        Description = "Acetaminophen",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/ABAB-500mg&VD-20748-14"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "ACC 200 mg",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Lindopharm GmbH",
                        Description = "Acetylcystein",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/ACC-200-mg&VN-19978-16"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "ACM Control 1",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần Dược phẩm 3/2",
                        Description = "Acenocoumarol",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/ACM-Control-1&VD-25107-16"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "ACM Control 4",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần Dược phẩm 3/2",
                        Description = "Acenocoumarol",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/ACM-Control-4&VD-25594-16"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "AG-Ome",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần dược phẩm Agimexpharm",
                        Description = "Omeprazol (Dạng vi hạt bao tan trong ruột)",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/AG-Ome&VD-20653-14"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "AN KHỚP VƯƠNG",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Công ty cổ phần dược phẩm Hà Tây",
                        Description = "Độc hoạt, quế chi, phòng phong, đương quy, tế tân, xuyên khung, tần giao, bạch thược, tang ký sinh, can địa hoàng, đỗ trọng, đảng sâm, ngưu tất, bạch linh, cam thảo",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/AN-KHOP-VUONG&VD-26141-17"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "ATP",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Công ty cổ phần dược phẩm Hà Tây",
                        Description = "Dinatri adenosin triphosphat",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/ATP&VD-17911-12"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Aarmol 100ml",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Shree Krishnakeshav Laboratories Limited",
                        Description = "Paracetamol",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Aarmol-100ml&VN-18861-15"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abacavir Tablets USP 300mg",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Mylan Laboratories Limited",
                        Description = "Abacavir (dưới dạng Abacavir sulfat)",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abacavir-Tablets-USP-300mg&VN2-643-17"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abamune-L Baby",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Cipla Ltd.",
                        Description = "Abacavir; Lamivudin",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abamune-L-Baby&VN3-27-18"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abbsin 200",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "OU Vitale-XD (nơi sản xuất Vitale Pringi)",
                        Description = "Acetylcystein",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abbsin-200&VN-20441-17"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abbsin 600",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "OU Vitale-XD (nơi sản xuất Vitale Pringi)",
                        Description = "Acetylcystein",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abbsin-600&VN-20442-17"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abernil 50mg",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Medochemie Ltd.",
                        Description = "Naltrexone hydroclorid",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abernil-50mg&VN-17095-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abhigrel 75",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Medibios Laboratories Pvt., Ltd.",
                        Description = "Clopidogrel (dưới dạng Clopidogrel bisulphate)",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abhigrel-75&VN-16372-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abilify tablets 15mg",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Korea Otsuka Pharmaceutical Co., Ltd.",
                        Description = "Aripiprazol",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abilify-tablets-15mg&VN3-82-18"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abingem 200",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 15000,
                        Provider = "Naprod Life Sciences Pvt. Ltd.",
                        Description = "Gemcitabine",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abingem-200&VN2-53-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abingem-1gm",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Naprod Life Sciences Pvt. Ltd.",
                        Description = "Gemcitabine (dưới dạng Gemcitabine hydrochloride)",
                        Type = typeOther,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abingem-1gm&VN2-392-15"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abitrax",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Laboratorio Farmaceutico C.T.s.r.l.",
                        Description = "Ceftriaxone (dưới dạng Ceftriaxone natri)",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abitrax&VN-16899-13"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abivina",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Viện Dược liệu",
                        Description = "Cao khô bồ bồ ; Tinh dầu bồ bồ",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abivina&NC49-H12-15"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abochlorphe",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Chi nhánh công ty TNHH SX-TM dược phẩm Thành Nam",
                        Description = "Chlorpheniramin maleat",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abochlorphe&VD-25057-16"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Abrocto",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Công ty cổ phần dược-vật tư y tế Thanh Hoá",
                        Description = "Ambroxol HCl",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Abrocto&VD-18035-12"
                    });
                    context.Commodities.Add(new Commodity
                    {
                        Name = "Acabrose Tablets 50mg",
                        BaseUnitName = "Hộp 10 gói x 1,5g",
                        BaseUnitPrice = 5000,
                        Provider = "Standard Chem. & Pharm. Co., Ltd.",
                        Description = "Acarbose",
                        Type = typeMedicine,
                        ReferenceLink = "https://drugbank.vn/thuoc/Acabrose-Tablets-50mg&VN-21345-18"
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
