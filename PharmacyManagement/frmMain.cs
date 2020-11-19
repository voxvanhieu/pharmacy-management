using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using PharmacyManagement.Models;
using PharmacyManagement.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class frmPharmacy : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        UserGridControl userGridControl;

        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public frmPharmacy()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");
            accordionControl.SelectedElement = employeesAccordionControlElement;
        }
        XtraUserControl CreateUserControl(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;

            userGridControl = new UserGridControl();
            userGridControl.Dock = DockStyle.Fill;
            userGridControl.Parent = result;

            //LabelControl label = new LabelControl();
            //label.Parent = result;
            //label.Appearance.Font = new Font("Tahoma", 25.25F);
            //label.Appearance.ForeColor = Color.Gray;
            //label.Dock = System.Windows.Forms.DockStyle.Fill;
            //label.AutoSizeMode = LabelAutoSizeMode.None;
            //label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            //label.Text = text;

            return result;
        }

        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;
            XtraUserControl userControl = e.Element.Text == "Employees" ? employeesUserControl : customersUserControl;
            tabbedView.AddDocument(userControl);
            tabbedView.ActivateDocument(userControl);
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }
        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }
        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            if (tabbedView.Documents.Count != 0)
            {
                if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
                else accordionControl.SelectedElement = employeesAccordionControlElement;
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }
        void RecreateUserControls(DocumentEventArgs e)
        {
            if (e.Document.Caption == "Employees") employeesUserControl = CreateUserControl("Employees");
            else customersUserControl = CreateUserControl("Customers");
        }
        private void userGridControl_SelectedRowChanged(object sender, HieuVVCustomSelectedRowChangedEventArgs e)
        {
            UpdateUserDetails(e.UserName);
        }

        private void UpdateUserDetails(string userName)
        {
            using (var dbContext = PharmacyDbContext.Create())
            {
                var user = dbContext.Users
                                        .Where(u => u.UserName == userName)
                                        .Select(u => new UserViewModel
                                        {
                                            Id = u.Id,
                                            UserName = u.UserName,
                                            Address = u.Address,
                                            Birthday = u.Birthday,
                                            FullName = u.FullName,
                                            Gender = u.Gender,
                                            Image = u.Image,
                                            Created = u.Created,
                                            Role = u.Role
                                        }).FirstOrDefault();
                lblUsername.Text = user.UserName;
                lblFullName.Text = user.FullName;
                lblAddress.Text = user.Address;
                lblBirthDay.Text = user.Birthday.ToString("dd/mm/yyy");
                lblRole.Text = user.Role.Name;
            }
        }

        private void frmPharmacy_Load(object sender, EventArgs e)
        {
            var ctx = PharmacyDbContext.Create();

            //using (UserIdentity uIdentity = new UserIdentity())
            //{
            //    uIdentity.CreateRole("admin");
            //    var user = new User
            //    {
            //        UserName = "admin",
            //        FullName = "Vo Van Hieu",
            //        Address = "Address",
            //        Birthday = DateTime.Now.AddDays(30),
            //        Gender = true
            //    };

            //    uIdentity.RegisterUser(user: user, password: "password", roleName: "admin");
            //}

            //MessageBox.Show(ctx.Users.First().Role.Name);
            //ctx.Users.First();

        }
    }
}