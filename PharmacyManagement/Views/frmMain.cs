using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using PharmacyManagement.Models;
using PharmacyManagement.Models.ViewModels;
using PharmacyManagement.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.Views
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        public frmMain()
        {
            InitializeComponent();
        }
        XtraUserControl CreateUserControl(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;

            LabelControl label = new LabelControl();
            label.Parent = result;
            label.Appearance.Font = new Font("Tahoma", 25.25F);
            label.Appearance.ForeColor = Color.Gray;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Text = text;
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
            //dockpnlUser.ShowSliding();
            dockpnlUser.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
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
                if(user != null)
                {
                    lblUsername.Text = user.UserName;
                    lblFullName.Text = user.FullName;
                    lblAddress.Text = user.Address;
                    lblBirthDay.Text = user.Birthday.ToString("D");
                    lblRole.Text = user.Role.Name;
                    picAvatar.Image = (user.Gender) ? global::PharmacyManagement.Properties.Resources._016_man
                                                    : global::PharmacyManagement.Properties.Resources._015_woman;
                }
                else
                {
                    lblUsername.Text = "Sellect a user";
                    lblFullName.Text = "";
                    lblAddress.Text = "";
                    lblBirthDay.Text = "";
                    lblRole.Text = "";
                }
            }
        }

        private void frmPharmacy_Load(object sender, EventArgs e)
        {
            var frmLogin = new frmLogin(this);
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                // OK
                employeesUserControl = CreateUserControl("Employees");
                customersUserControl = CreateUserControl("Customers");
                accordionControl.SelectedElement = employeesAccordionControlElement;
                this.WindowState = FormWindowState.Maximized;
                this.Enabled = true;
                this.Show();
                

                // Clean resource
                frmLogin.Dispose();
                frmLogin = null;    // Help GC to clean this guy
            }
            else
            {
                this.Close();
            }
        }

        private UserGridControl userGridControl;
        private XtraUserControl tabAllUsers;
        private void barbtbAllUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabAllUsers is null || tabAllUsers.IsDisposed)
            {
                tabAllUsers = new XtraUserControl();
                tabAllUsers.Name = "TabAllUsersControl";
                tabAllUsers.Text = "Users";
            }

            if (userGridControl is null || userGridControl.IsDisposed)
            {
                userGridControl = new UserGridControl();

                userGridControl.Dock = DockStyle.Fill;
                userGridControl.Parent = tabAllUsers;
                userGridControl.GridSelectedRowChanged += userGridControl_SelectedRowChanged;
            }

            tabbedView.AddDocument(tabAllUsers);
            tabbedView.ActivateDocument(tabAllUsers);
        }

        private void barbtnNewUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = new frmNewUser().ShowDialog();
            if(result == DialogResult.OK)
            {
                userGridControl?.RefillGrid();
            }
        }

        private void barbtnChangeRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = new frmChangeUserRole().ShowDialog();
            if (result == DialogResult.OK)
            {
                userGridControl?.RefillGrid();
            }
        }

        private void barbtnNewRole_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmNewRole().ShowDialog();
        }

        private void barbtnListRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmListAllRole().ShowDialog();      
        }

        private void barbtnChangeUSerInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = new frmEditUser().ShowDialog();
            if (result == DialogResult.OK)
            {
                userGridControl?.RefillGrid();
            }
        }

        private void barbtnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmChangePassword().ShowDialog();
        }

        private void barButtonLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Enabled = false;
                UserIdentity.SessionUser = null;

                frmPharmacy_Load(sender, e);
            }
        }

        private CommodityUserControl commodityGridControl;
        private XtraUserControl tabAllCommodity;
        private void barbtnLookup_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabAllCommodity is null || tabAllCommodity.IsDisposed)
            {
                tabAllCommodity = new XtraUserControl();
                tabAllCommodity.Name = "TabAllComodityControl";
                tabAllCommodity.Text = "All Comodities";
            }

            if (commodityGridControl is null || commodityGridControl.IsDisposed)
            {
                commodityGridControl = new CommodityUserControl();

                commodityGridControl.Dock = DockStyle.Fill;
                commodityGridControl.Parent = tabAllCommodity;
                //commodityGridControl.GridSelectedRowChanged += userGridControl_SelectedRowChanged;
            }

            tabbedView.AddDocument(tabAllCommodity);
            tabbedView.ActivateDocument(tabAllCommodity);
        }

        private void barbtnNewInstrument_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmNewInstrument().ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabAllCommodity is null || tabAllCommodity.IsDisposed)
            {
                tabAllCommodity = new XtraUserControl();
                tabAllCommodity.Name = "TabAllComodityControl";
                tabAllCommodity.Text = "All Comodities";
            }

            if (commodityGridControl is null || commodityGridControl.IsDisposed)
            {
                commodityGridControl = new CommodityUserControl();

                commodityGridControl.Dock = DockStyle.Fill;
                commodityGridControl.Parent = tabAllCommodity;
                //commodityGridControl.GridSelectedRowChanged += userGridControl_SelectedRowChanged;
            }

            tabbedView.AddDocument(tabAllCommodity);
            tabbedView.ActivateDocument(tabAllCommodity);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmNewInvoice().ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmNewInstrument().ShowDialog();
        }
    }
}