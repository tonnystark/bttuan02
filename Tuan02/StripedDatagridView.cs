using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan02
{
    public class StripedDatagridView : DataGridView
    {
        public StripedDatagridView()
        {
            this.CellFormatting += StripedDatagridView_CellFormatting;
        }

        private void StripedDatagridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            StripedDatagridView dgv = (StripedDatagridView)sender;
            if (e.RowIndex % 2 == 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.Green;
            }
        }
    }
}
