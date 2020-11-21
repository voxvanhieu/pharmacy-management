using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using PharmacyManagement.Models;
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
    public partial class frmLogin : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        PharmacyDbContext context = PharmacyDbContext.Create();
        UserIdentity userIdentity = new UserIdentity();

        frmMain frmMain;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(frmMain frmMain) : this()
        {
            this.frmMain = frmMain;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userIdentity.Validate(cmbUsername.Text, txbPassword.Text))
            {
                UserIdentity.SessionUser = context.Users.First(u => u.UserName == cmbUsername.Text);

                if (!userIdentity.IsInRole(UserIdentity.SessionUser, "Admin"))
                {
                    frmMain.ribbonPageHumanManager.Visible = false;
                }

                UserIdentity.SessionUser = new User
                {
                    Id = UserIdentity.SessionUser.Id,
                    UserName = UserIdentity.SessionUser.UserName,
                    FullName = UserIdentity.SessionUser.FullName,
                    Address = UserIdentity.SessionUser.Address,
                    Birthday = UserIdentity.SessionUser.Birthday,
                    Gender = UserIdentity.SessionUser.Gender,
                    Role = new Role { Name = UserIdentity.SessionUser.Role.Name }
                };

                //Cleanup data
                userIdentity.Dispose();
                context.Dispose();
                context = null;
                userIdentity = null;

                CloseForm(DialogResult.OK);
            }
            else XtraMessageBox.Show("Wrong username or password", "ERROR");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseForm(DialogResult.Abort);
        }

        private void CloseForm(DialogResult dialogResult)
        {
            this.DialogResult = dialogResult;
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var lstUsername = context.Users.Select(u => u.UserName)?.ToList();
            if (lstUsername != null)
            {
                cmbUsername.Properties.Items.AddRange(lstUsername);
                cmbUsername.Text = lstUsername[0];
            }
            else
            {
                XtraMessageBox.Show("There are no user in database", "Error");
                btnExit_Click(this, null);
            }
        }
    }
}