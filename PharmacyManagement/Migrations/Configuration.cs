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
                context.Commodities.Add(new Commodity
                {
                    Name = "Casoran",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần công nghệ cao Traphaco",
                    Description = "Cao hoa hòe (3:1) ; Cao dừa cạn (6:1) ; Cao tâm sen (4:1) ; Cao cúc hoa (3:1)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Casoran&VD-23889-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Docetaxel 20mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Teva Pharmaceutical Works Private Limited Company",
                    Description = "Docetaxel",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Docetaxel-20mg&VN-17674-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Hà thủ ô",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần công nghệ cao Traphaco",
                    Description = "Cao đặc rễ hà thủ ô đỏ",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Ha-thu-o&VD-24071-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "1-AL",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "FDC Limited",
                    Description = "Levocetirizine (dưới dạng Levocetirizine dihydrochloride)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/1-AL&VN-17635-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "1-AL",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "FDC Limited",
                    Description = "Levocetirizine Dihydrochloride",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/1-AL&VN-17818-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "20% Fat Emulsion Injection",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Guangdong Otsuka Pharmaceutical Co., Ltd.",
                    Description = "Soybean oil",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/20%-Fat-Emulsion-Injection&VN-19115-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "3B-Medi",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Me Di Sun",
                    Description = "Vitamin B1; Vitamin B6; Vitamin B12",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/3B-Medi&VD-22915-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "3B-Medi tab",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Me Di Sun",
                    Description = "Vitamin B1 (Thiamin mononitrat) ; Vitamin B6 (Pyridoxin hydroclorid) ; Vitamin B12 (Cyanocobalamin)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/3B-Medi-tab&VD-26870-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "3BTP",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Hà Tây",
                    Description = "Vitamin B1 (Thiamin nitrat) ; Vitamin B6 (Pyridoxin hydroclorid) ; Vitamin B12 (Cyanocobalamin)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/3BTP&VD-26140-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "3Bpluzs F",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm Phương Đông",
                    Description = "Vitamin B1; Vitamin B6 ; Vitamin B12; Sắt sulfat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/3Bpluzs-F&VD-16258-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "3Bvit ando",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Hà Tây",
                    Description = "Vitamin B1; Vitamin B6; Vitamin B12; Vitamin B2; Vitamin PP",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/3Bvit-ando&VD-17429-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "4-Epeedo-50",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Naprod Life Sciences Pvt. Ltd.",
                    Description = "Epirubicin hydrochloride",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/4-Epeedo-50&VN2-52-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "4.2% w/v Sodium Bicarbonate",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "B.Braun Melsungen AG",
                    Description = "Natri bicarbonat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/4.2%-w/v-Sodium-Bicarbonate&VN-18586-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "5% Dextrose 500ml inj Infusion",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Dai Han Pharm. Co., Ltd.",
                    Description = "Dextrose",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/5%-Dextrose-500ml-inj-Infusion&VN-16866-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "5-Fluorouracil \"Ebewe\"",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Ebewe Pharma Ges.m.b.H.Nfg.KG",
                    Description = "5-Fluorouracil",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/5-Fluorouracil-Ebewe&VN-17422-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "8 Horas",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Laboratorio Elea S.A.C.I.F.yA",
                    Description = "Eszopiclone",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/8-Horas&VN2-112-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "8 Horas",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Laboratorio Elea S.A.C.I.F.yA",
                    Description = "Eszopiclone",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/8-Horas&VN2-113-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "9PM",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Cipla Ltd",
                    Description = "Latanoprost",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/9PM&VN-21186-18"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "A9 - Cerebrazel",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược TW Mediplantex",
                    Description = "Meclofenoxat hydroclorid",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/A9---Cerebrazel&VD-18416-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "ABAB 500mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm IMEXPHARM",
                    Description = "Acetaminophen",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/ABAB-500mg&VD-20748-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "ABAB 500mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm IMEXPHARM",
                    Description = "Acetaminophen",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/ABAB-500mg&VD-20749-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "ACC 200 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Lindopharm GmbH",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/ACC-200-mg&VN-19978-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "ACM Control 1",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm 3/2",
                    Description = "Acenocoumarol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/ACM-Control-1&VD-25107-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "ACM Control 4",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm 3/2",
                    Description = "Acenocoumarol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/ACM-Control-4&VD-25594-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "AG-Ome",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Agimexpharm",
                    Description = "Omeprazol (Dạng vi hạt bao tan trong ruột)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/AG-Ome&VD-20653-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "AN KHỚP VƯƠNG",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Hà Tây",
                    Description = "Độc hoạt, quế chi, phòng phong, đương quy, tế tân, xuyên khung, tần giao, bạch thược, tang ký sinh, can địa hoàng, đỗ trọng, đảng sâm, ngưu tất, bạch linh, cam thảo",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/AN-KHOP-VUONG&VD-26141-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "ATP",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Hà Tây",
                    Description = "Dinatri adenosin triphosphat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/ATP&VD-17911-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "ATP",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược TW Mediplantex",
                    Description = "Dinatri adenosin triphosphat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/ATP&VD-27208-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aarmol 100ml",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Shree Krishnakeshav Laboratories Limited",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aarmol-100ml&VN-18861-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abacavir Tablets USP 300mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Mylan Laboratories Limited",
                    Description = "Abacavir (dưới dạng Abacavir sulfat)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abacavir-Tablets-USP-300mg&VN2-643-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abamune-L Baby",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Cipla Ltd.",
                    Description = "Abacavir; Lamivudin",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abamune-L-Baby&VN3-27-18"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abbsin 200",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "OU Vitale-XD (nơi sản xuất Vitale Pringi)",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abbsin-200&VN-20441-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abbsin 600",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "OU Vitale-XD (nơi sản xuất Vitale Pringi)",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abbsin-600&VN-20442-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abernil 50mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Medochemie Ltd.",
                    Description = "Naltrexone hydroclorid",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abernil-50mg&VN-17095-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abhigrel 75",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Medibios Laboratories Pvt., Ltd.",
                    Description = "Clopidogrel (dưới dạng Clopidogrel bisulphate)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abhigrel-75&VN-16372-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abilify tablets 15mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Korea Otsuka Pharmaceutical Co., Ltd.",
                    Description = "Aripiprazol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abilify-tablets-15mg&VN3-82-18"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abingem 200",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Naprod Life Sciences Pvt. Ltd.",
                    Description = "Gemcitabine",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abingem-200&VN2-53-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abingem-1gm",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Naprod Life Sciences Pvt. Ltd.",
                    Description = "Gemcitabine (dưới dạng Gemcitabine hydrochloride)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abingem-1gm&VN2-392-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abitrax",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Laboratorio Farmaceutico C.T.s.r.l.",
                    Description = "Ceftriaxone (dưới dạng Ceftriaxone natri)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abitrax&VN-16899-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abivina",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Viện Dược liệu",
                    Description = "Cao khô bồ bồ ; Tinh dầu bồ bồ",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abivina&NC49-H12-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abochlorphe",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Chi nhánh công ty TNHH SX-TM dược phẩm Thành Nam",
                    Description = "Chlorpheniramin maleat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abochlorphe&VD-25057-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Abrocto",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược-vật tư y tế Thanh Hoá",
                    Description = "Ambroxol HCl",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Abrocto&VD-18035-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acabrose Tablets 50mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Standard Chem. & Pharm. Co., Ltd.",
                    Description = "Acarbose",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acabrose-Tablets-50mg&VN-21345-18"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acarfar",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm dược liệu Pharmedic",
                    Description = "Acarbose",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acarfar&VD-24153-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acc Pluzz 200",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Hermes Arzneimittel GmbH",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acc-Pluzz-200&VN-20830-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acc Pluzz 600",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Hermes Arzneimittel GmbH",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acc-Pluzz-600&VN-20831-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Ace kid 150",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Bidiphar 1",
                    Description = "Paracetamol; vitamin C",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Ace-kid-150&VD-17887-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Ace kid 325",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Bidiphar 1",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Ace-kid-325&VD-18248-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acebis - 1,5g",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần tập đoàn Merap",
                    Description = "Cefoperazon; Sulbactam",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acebis---1,5g&VD-16364-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acebis - 1g",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần tập đoàn Merap",
                    Description = "Cefoperazon; Sulbactam",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acebis---1g&VD-16365-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acebis - 2,25g",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần tập đoàn Merap",
                    Description = "Cefoperazon; Sulbactam",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acebis---2,25g&VD-16366-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aceclofenac Stada 100 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty TNHH LD Stada-Việt Nam.",
                    Description = "Aceclofenac",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aceclofenac-Stada-100-mg&VD-20124-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aceclofenac T/H",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược-vật tư y tế Thanh Hoá",
                    Description = "Aceclofenac",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aceclofenac-T/H&VD-21705-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aceclonac",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Rafarm S.A.",
                    Description = "Aceclofenac",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aceclonac&VN-20696-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acectum",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Karnataka Antibiotics & Pharmaceuticals Limited",
                    Description = "Piperacillin (dưới dạng piperacillin natri) ; Tazobactam (dưới dạng Tazobactam natri)",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acectum&VN-21262-18"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acecyst",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Chi nhánh công ty cổ phần dược phẩm Agimexpharm- Nhà máy sản xuất dược phẩm Agimexpharm",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acecyst&VD-25112-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acedolflu",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm 2/9 TP HCM",
                    Description = "Paracetamol; Clorpheniramin maleat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acedolflu&VD-26076-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acefalgan 150",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm Euvipharm - Thành viên tập đoàn Valeant",
                    Description = "Acetaminophen",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acefalgan-150&VD-23527-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acefalgan 250",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm Euvipharm - Thành viên tập đoàn Valeant",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acefalgan-250&VD-25673-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acefalgan 500",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm Euvipharm - Thành viên tập đoàn Valeant",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acefalgan-500&VD-23528-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acefalgan 500",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm Euvipharm - Thành viên tập đoàn Valeant",
                    Description = "Acetaminophen",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acefalgan-500&VD-26134-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acefalgan Codein",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm Euvipharm - Thành viên tập đoàn Valeant",
                    Description = "Paracetamol; Codein phosphat hemihydrat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acefalgan-Codein&VD-26135-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acehasan 100",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty TNHH Ha san - Dermapharm",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acehasan-100&VD-15582-11"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acehasan 200",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty TNHH Ha san - Dermapharm",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acehasan-200&VD-15583-11"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acehasan 200",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty TNHH Ha san - Dermapharm",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acehasan-200&VD-19179-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acemetin",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Hà Tây",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acemetin&VD-27875-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acemol fort",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm 2/9 TP HCM",
                    Description = "Acetaminophen",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acemol-fort&VD-24693-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acemuc",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty TNHH Sanofi-Aventis Việt Nam",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acemuc&VD-18156-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acenac 100",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Cửu Long",
                    Description = "Aceclofenac",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acenac-100&VD-17405-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acepron 250 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Cửu Long",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acepron-250-mg&VD-20678-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acepron 325 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Cửu Long",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acepron-325-mg&VD-20679-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acepron 325mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Cửu Long",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acepron-325mg&VD-16514-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acepron 500 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Cửu Long",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acepron-500-mg&VD-20680-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acepron 650",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Cửu Long",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acepron-650&VD-22822-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acepron Codein",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Cửu Long",
                    Description = "Paracetamol; Codein phosphat hemihydrat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acepron-Codein&VD-20681-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetab 325",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Agimexpharm",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetab-325&VD-22437-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetab 650",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Chi nhánh công ty cổ phần dược phẩm Agimexpharm- Nhà máy sản xuất dược phẩm Agimexpharm",
                    Description = "Paracetamol",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetab-650&VD-26090-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetalvic codein 30",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm trung ương VIDIPHA",
                    Description = "Paracetamol; Codein phosphat",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetalvic-codein-30&VD-17975-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetaphen 500",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm OPV",
                    Description = "Acetaminophen",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetaphen-500&VD-24239-16"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acethepharm",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược-vật tư y tế Thanh Hoá",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acethepharm&VD-20935-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acethepharm",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược-vật tư y tế Thanh Hoá",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acethepharm&VD-20936-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetydona 200 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần sản xuất - thương mại Dược phẩm Đông Nam",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetydona-200-mg&VD-20043-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetyl Cystein",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm Hà Tây",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetyl-Cystein&VD-17430-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetyl Max",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược vật tư y tế Thanh Hoá",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetyl-Max&VD-23150-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcystein",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm 2/9 - Nadyphar",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcystein&VD-17864-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcystein",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm TV. Pharm",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcystein&VD-20260-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcystein",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Chi nhánh công ty TNHH SX-TM dược phẩm Thành Nam",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcystein&VD-27595-17"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcystein",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm 3/2",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcystein&VD-18919-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcystein 200 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược Minh Hải",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcystein-200-mg&VD-22770-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcystein 200 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty CP liên doanh dược phẩm Medipharco Tenamyd BR s.r.l",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcystein-200-mg&VD-17186-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcystein 200 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược Đồng Nai.",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcystein-200-mg&VD-23445-15"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcystein 200mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Chi nhánh công ty cổ phần dược phẩm trung ương Vidipha tại Bình Dương",
                    Description = "Acetylcystein",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcystein-200mg&VD-21910-14"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acetylcysteine 200mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần hoá-dược phẩm Mekophar.",
                    Description = "Acetylcysteine",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acetylcysteine-200mg&VD-20019-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aciclovir",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược phẩm dược liệu Pharmedic",
                    Description = "Aciclovir",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aciclovir&VD-20188-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aciclovir 200 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược Minh Hải",
                    Description = "Acyclovir",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aciclovir-200-mg&VD-16803-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aciclovir 400 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược Minh Hải",
                    Description = "Aciclovir",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aciclovir-400-mg&VD-17856-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aciclovir 5%",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần dược vật tư y tế Hải Dương",
                    Description = "Aciclovir",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aciclovir-5%&VD-18434-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Aciclovir Tablets BP",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Brawn Laboratories Ltd",
                    Description = "Acyclovir",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Aciclovir-Tablets-BP&VN-17013-13"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acid Folic 5 mg",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần Dược phẩm 3/2..",
                    Description = "acid folic",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acid-Folic-5-mg&VD-16826-12"
                });
                context.Commodities.Add(new Commodity
                {
                    Name = "Acid folic MKP",
                    BaseUnit = "Hộp 10 gói x 1,5g",
                    BaseUnitPrice = 5000,
                    Provider = "Công ty cổ phần hoá-dược phẩm Mekophar.",
                    Description = "Acid folic",
                    Type = typeMedicine,
                    ReferenceLink = "https://drugbank.vn/thuoc/Acid-folic-MKP&VD-19107-13"
                });

                context.SaveChanges();
            }

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
