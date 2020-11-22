using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using PharmacyManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.Views
{
    public partial class frmNewUser : DevExpress.XtraEditors.XtraForm
    {
        private bool _gender = true;
        private List<string> lstRoles;

        private PharmacyDbContext context = PharmacyDbContext.Create();
        private UserIdentity userIdentity = new UserIdentity();

        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            lstRoles = context.Roles.Select(r => r.Name)?.ToList();
            if (lstRoles != null)
            {
                cmbRole.Properties.Items.AddRange(lstRoles);
                cmbRole.Text = lstRoles[0];
            }
            else
            {
                XtraMessageBox.Show("There are no role in database", "Error");
                context.Dispose();
                userIdentity.Dispose();
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbUsername.ResetText();
            txbFullName.ResetText();
            txbAddress.ResetText();
            dateBirthday.ResetText();
            cmbRole.Text = lstRoles[0];
            pictureBox1.Image = global::PharmacyManagement.Properties.Resources._016_man;
            _gender = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                userIdentity.RegisterUser(new User
                {
                    UserName = txbUsername.Text,
                    FullName = txbFullName.Text,
                    Address = txbAddress.Text,
                    Birthday = dateBirthday.DateTime,
                    Gender = _gender
                }, password: "123@123a", roleName: cmbRole.Text);
                XtraMessageBox.Show("New user created successfully!", "Ngon lành cành đào");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupControl2.Text = (_gender) ? "Gender: Woman" : "Gender: Man";

            pictureBox1.Image = (_gender) ? global::PharmacyManagement.Properties.Resources._015_woman
                                            : global::PharmacyManagement.Properties.Resources._016_man;
            _gender = !_gender;
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