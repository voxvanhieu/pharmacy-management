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
using PharmacyManagement.Models;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;

namespace PharmacyManagement.Views
{
    public partial class frmEditUser : DevExpress.XtraEditors.XtraForm
    {
        private bool _gender = true;
        private List<string> lstRoles;

        private PharmacyDbContext context = PharmacyDbContext.Create();
        private UserIdentity userIdentity = new UserIdentity();
        public frmEditUser()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            txbUsername.Text = UserIdentity.SessionUser.UserName;
            txbFullName.Text = UserIdentity.SessionUser.FullName;
            txbAddress.Text = UserIdentity.SessionUser.Address;
            dateBirthday.Text = UserIdentity.SessionUser.Birthday.ToString("D");
            cmbRole.Text = UserIdentity.SessionUser.Role.Name;
            _gender = UserIdentity.SessionUser.Gender;
            groupControl2.Text = (_gender) ? "Gender: Man" : "Gender: Woman";
            if (UserIdentity.SessionUser.Gender)
            {
                pictureBox1.Image = global::PharmacyManagement.Properties.Resources._016_man;
            }
            else
            {
                pictureBox1.Image = global::PharmacyManagement.Properties.Resources._015_woman;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            groupControl2.Text = (_gender) ? "Gender: Woman" : "Gender: Man";

            pictureBox1.Image = (_gender) ? global::PharmacyManagement.Properties.Resources._015_woman
                                            : global::PharmacyManagement.Properties.Resources._016_man;
            _gender = !_gender;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var user = context.Users
                                    .Where(u => u.UserName.Equals(UserIdentity.SessionUser.UserName, StringComparison.OrdinalIgnoreCase))
                                    .FirstOrDefault();
                if(user != null)
                {
                    user.UserName = txbUsername.Text;
                    user.FullName = txbFullName.Text;
                    user.Address = txbAddress.Text;
                    user.Birthday = dateBirthday.DateTime;
                    user.Gender = _gender;
                    context.SaveChanges();

                    // cap nhat lai session user
                    UserIdentity.SessionUser.UserName = user.UserName;
                    UserIdentity.SessionUser.FullName = user.FullName;
                    UserIdentity.SessionUser.Address = user.Address;
                    UserIdentity.SessionUser.Birthday = user.Birthday;
                    UserIdentity.SessionUser.Gender = user.Gender;
                    UserIdentity.SessionUser.Role.Name = user.Role.Name;
                }
                XtraMessageBox.Show("Edit successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        DXErrorProvider errorProvider = new DXErrorProvider();
        private void txbUsername_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;
            var rxPattern = @"^\w[a-z0-9\.]{3,11}";
            var match = Regex.Match(txbUsername.Text, rxPattern, RegexOptions.IgnoreCase);

            if (match.Success) errorProvider.SetError(edit, "");
            else
            {
                errorProvider.SetError(edit, "A good username is:\n> 4-12 characters.\n> Lower case alphabet character\n> Numberic character\n> No space or others", ErrorType.Critical);
                e.Cancel = true;
            }
        }

        private void cmbRole_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as ComboBoxEdit;
            if (lstRoles.Contains(edit.Text)) errorProvider.SetError(edit, "");
            else
            {
                errorProvider.SetError(edit, "Role not found, create a new role first", ErrorType.Critical);
                e.Cancel = true;
            }
        }

        private void dateBirthday_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as DateEdit;

            if (edit.DateTime < DateTime.Now && edit.DateTime.Year > 1950) errorProvider.SetError(edit, "");
            else
            {
                errorProvider.SetError(edit, "Thời gian kiểu éo gì thế bạn ơi!", ErrorType.Information);
                e.Cancel = true;
            }
        }

        private void NotNull_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;
            if (!string.IsNullOrEmpty(edit.Text) && !string.IsNullOrWhiteSpace(edit.Text)) errorProvider.SetError(edit, "");
            else
            {
                errorProvider.SetError(edit, "This field not null, type some thing", ErrorType.Critical);
                e.Cancel = true;
            }
        }
    }
}