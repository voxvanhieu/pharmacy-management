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

        public frmLogin()
        {
            InitializeComponent();

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userIdentity.Validate(cmbUsername.Text, txbPassword.Text))
            {
                UserIdentity.SessionUser = context.Users.First(u => u.UserName == cmbUsername.Text);

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
    }
}