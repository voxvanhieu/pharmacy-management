using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;
using PharmacyManagement.Models;

namespace PharmacyManagement.Views
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        PharmacyDbContext context = PharmacyDbContext.Create();
        UserIdentity userIdentity = new UserIdentity();
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textEdit1.ResetText();
            textEdit2.ResetText();
            txbUsername.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && userIdentity.ChangePassword(UserIdentity.SessionUser.UserName, txbUsername.Text, textEdit1.Text))
            {
                XtraMessageBox.Show("Change password successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else XtraMessageBox.Show("Wrong password", "ERROR");
        }

        DXErrorProvider errorProvider = new DXErrorProvider();
        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var input = textEdit2.Text;

            if (hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input)) errorProvider.SetError(edit, "");
            else
            {
                errorProvider.SetError(edit, "A good password is:\n> >=8 characters.\n> At least one upper case alphabet character\n> At least one numberic character", ErrorType.Critical);
                e.Cancel = true;
            }
            
        }

        private void txbNewPassMatch_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;

            if (!textEdit1.Text.Equals(textEdit2.Text))
            {
                errorProvider.SetError(edit, "Your new passwords not match others", ErrorType.Critical);
                e.Cancel = true;
            }
            else errorProvider.SetError(edit, "");
        }
    }
}