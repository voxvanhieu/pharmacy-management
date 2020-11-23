using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.Views.UserControls
{
    public class HieuVVCustomSelectedRowChangedEventArgs : EventArgs
    {
        public string UserName { get; set; }
    }

    public partial class UserGridControl
    {
        // declaring an event using built-in EventHandler
        public event EventHandler<HieuVVCustomSelectedRowChangedEventArgs> GridSelectedRowChanged;

        private void _gridSelectedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var data = new HieuVVCustomSelectedRowChangedEventArgs();
            try
            {
                // Process Started!

                // some code here..

                data.UserName = gridView1.GetRowCellValue(e.FocusedRowHandle, "UserName")?.ToString();

                OnGridSelectedRowChanged(data);
            }
            catch (Exception)
            {
                data.UserName = null;
                OnGridSelectedRowChanged(data);
            }
        }

        protected virtual void OnGridSelectedRowChanged(HieuVVCustomSelectedRowChangedEventArgs e)
        {
            GridSelectedRowChanged?.Invoke(this, e);
        }
    }
}
