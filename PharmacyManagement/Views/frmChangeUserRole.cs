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
    public partial class frmChangeUserRole : DevExpress.XtraEditors.XtraForm
    {
        PharmacyDbContext context = PharmacyDbContext.Create();
        UserIdentity userIdentity = new UserIdentity();

        private List<string> lstUsername, lstRoles;

        public frmChangeUserRole()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            context.Dispose();
            userIdentity.Dispose();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (context.Users.Any(u => u.UserName == cmbUsername.Text) && context.Roles.Any(r => r.Name == cmbRole.Text))
            {
                if (userIdentity.IsInRole(UserIdentity.SessionUser, "Admin"))
                {
                    if (userIdentity.ChangeRole(cmbUsername.Text, cmbRole.Text)) {
                        XtraMessageBox.Show("Change user Role successfully", "OK");
                        this.DialogResult = DialogResult.OK;
                        context.Dispose();
                        userIdentity.Dispose();
                        this.Close();
                    };

                }
                else
                {
                    XtraMessageBox.Show("You do not have permission to perform this action");
                    btnCancel_Click(this, null);
                }
            }
            else
            {
                XtraMessageBox.Show("Username or Role not found", "Error");
                return;
            }
        }

        private void frmChangeUserRole_Load(object sender, EventArgs e)
        {
            lstRoles = context.Roles.Select(r => r.Name)?.ToList();
            if (lstRoles != null)
            {
                cmbRole.Properties.Items.AddRange(lstRoles);
                cmbRole.Text = lstRoles[0];
            }

            lstUsername = context.Users.Select(u => u.UserName)?.ToList();
            if (lstUsername != null)
            {
                cmbUsername.Properties.Items.AddRange(lstUsername);
                cmbRole.Text = UserIdentity.SessionUser.Role.Name;
            }
        }
    }
}