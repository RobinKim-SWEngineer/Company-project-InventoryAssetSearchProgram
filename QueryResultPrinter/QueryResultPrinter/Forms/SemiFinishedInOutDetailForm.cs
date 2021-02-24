using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotalInventory;

namespace QueryResultPrinter.Forms
{
    public partial class SemiFinishedInOutDetailForm : TotalInventoryStatus
    {
        public SemiFinishedInOutDetailForm()
            : base()
        {
            labelTotalSummary.Text = "Total Semi-finished In/Out Summary";
            labelTotalDetail.Text = "Total Semi-finished In/Out Detail";
            this.Text = "Semi-finished In/Out";
            this.Name = "Semi-finished In/Out";
        }
    }
}
