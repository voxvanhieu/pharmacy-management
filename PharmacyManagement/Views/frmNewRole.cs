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
    public partial class frmNewRole : DevExpress.XtraEditors.XtraForm
    {
        private UserIdentity userIdentity = new UserIdentity();
        public frmNewRole()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbUsername.ResetText();

        }

        DXErrorProvider errorProvider = new DXErrorProvider();
        private void txbRolename_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;
            var rxPattern = @"^\w[a-z0-9\.]{3,11}";
            var match = Regex.Match(txbUsername.Text, rxPattern, RegexOptions.IgnoreCase);

            if (match.Success) errorProvider.SetError(edit, "");
            else
            {
                errorProvider.SetError(edit, "A good role is:\n> 4-12 characters.\n> Lower case alphabet character\n> Numberic character\n> No space or others", ErrorType.Critical);
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                userIdentity.CreateRole(txbUsername.Text);
                XtraMessageBox.Show("New user created successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmNewRole_Load(object sender, EventArgs e)
        {

        }
    }
}