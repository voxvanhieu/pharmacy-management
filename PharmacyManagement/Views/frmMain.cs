﻿using DevExpress.XtraBars;
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

namespace PharmacyManagement.Views
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        UserGridControl userGridControl;

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

            userGridControl = new UserGridControl();
            userGridControl.Dock = DockStyle.Fill;
            userGridControl.Parent = result;
            userGridControl.GridSelectedRowChanged += userGridControl_SelectedRowChanged;

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
                if(user != null)
                {
                    lblUsername.Text = user.UserName;
                    lblFullName.Text = user.FullName;
                    lblAddress.Text = user.Address;
                    lblBirthDay.Text = user.Birthday.ToString("dd/mm/yyy");
                    lblRole.Text = user.Role.Name;
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
            var frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                XtraMessageBox.Show($"Hello {UserIdentity.SessionUser.UserName}!");
                // OK
                employeesUserControl = CreateUserControl("Employees");
                customersUserControl = CreateUserControl("Customers");
                accordionControl.SelectedElement = employeesAccordionControlElement;
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
    }
}