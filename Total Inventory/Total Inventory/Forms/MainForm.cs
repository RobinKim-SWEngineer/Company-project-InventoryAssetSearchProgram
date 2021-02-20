using QueryResultPrinter;
using QueryResultPrinter.Forms;
using System;
using System.Windows.Forms;

namespace TotalInventory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
                
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        TotalInventoryStatus totalInventoryStatus;
        private void totalInventoryDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (totalInventoryStatus == null)
            {
                TabPage tabPage = new TabPage();
                totalInventoryStatus = new TotalInventoryStatus()
                {
                    TopLevel = false,
                    Parent = tabPage
                };
                tabPage.Text = totalInventoryStatus.Text;

                totalInventoryStatus.Dock = DockStyle.Fill;

                tabControl.TabPages.Add(tabPage);
                tabControl.SelectedTab = tabPage;
                tabControl.BringToFront();

                totalInventoryStatus.Show();

                totalInventoryStatus.FormClosed += new FormClosedEventHandler(TotalInventoryFormClosedEventHandler);
            }
        }

        private void TotalInventoryFormClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            totalInventoryStatus = null;
            tabControl.TabPages.Remove(tabControl.SelectedTab);

            if (tabControl.TabPages.Count == 0)
            {
                tabControl.SendToBack();
                return;
            }
            SetLastTabPageAsSelectedTap();
        }

        ClosedInventoryStatusForm closedInventoryStatusForm;
        private void closedInventoryStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (closedInventoryStatusForm == null)
            {
                TabPage tabPage = new TabPage();
                closedInventoryStatusForm = new ClosedInventoryStatusForm()
                {
                    TopLevel = false,
                    Parent = tabPage
                };
                tabPage.Text = closedInventoryStatusForm.Text;

                closedInventoryStatusForm.Dock = DockStyle.Fill;

                tabControl.TabPages.Add(tabPage);
                tabControl.SelectedTab = tabPage;
                tabControl.BringToFront();

                closedInventoryStatusForm.Show();

                closedInventoryStatusForm.FormClosed += new FormClosedEventHandler(ClosedInventoryStatusClosedEventHandler);
            }
        }
        private void ClosedInventoryStatusClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            closedInventoryStatusForm = null;
            tabControl.TabPages.Remove(tabControl.SelectedTab);

            if (tabControl.TabPages.Count == 0)
            {
                tabControl.SendToBack();
                return;
            }
            SetLastTabPageAsSelectedTap();
        }

        ProductInOutDetail productInOutDetail;
        private void productInOutDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productInOutDetail == null)
            {
                TabPage tabPage = new TabPage();
                productInOutDetail = new ProductInOutDetail()
                {
                    TopLevel = false,
                    Parent = tabPage
                };
                tabPage.Text = productInOutDetail.Text;

                productInOutDetail.Dock = DockStyle.Fill;

                tabControl.Controls.Add(tabPage);
                tabControl.SelectedTab = tabPage;
                tabControl.BringToFront();
                
                productInOutDetail.Show();

                productInOutDetail.FormClosed += new FormClosedEventHandler(ProductInOutDetailClosedEventHandler);
            }
        }

        private void ProductInOutDetailClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            productInOutDetail = null;
            tabControl.TabPages.Remove(tabControl.SelectedTab);

            if (tabControl.TabPages.Count == 0)
            {
                tabControl.SendToBack();
                return;
            }
            SetLastTabPageAsSelectedTap();
        }

        SemiFinishedInOutDetailForm semiFinishedInOutDetailForm;
        private void semifinishedInOutDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (semiFinishedInOutDetailForm == null)
            {
                TabPage tabPage = new TabPage();
                semiFinishedInOutDetailForm = new SemiFinishedInOutDetailForm()
                {
                    TopLevel = false,
                    Parent = tabPage
                };
                tabPage.Text = semiFinishedInOutDetailForm.Text;

                semiFinishedInOutDetailForm.Dock = DockStyle.Fill;

                tabControl.TabPages.Add(tabPage);
                tabControl.SelectedTab = tabPage;
                tabControl.BringToFront();

                semiFinishedInOutDetailForm.Show();

                semiFinishedInOutDetailForm.FormClosed += new FormClosedEventHandler(SemiFinishedInOutDetailFormClosedEventHandler);
            }
        }

        private void SemiFinishedInOutDetailFormClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            semiFinishedInOutDetailForm = null;
            tabControl.TabPages.Remove(tabControl.SelectedTab);
            
            if (tabControl.TabPages.Count == 0)
            {
                tabControl.SendToBack();
                return;
            }
            SetLastTabPageAsSelectedTap();
        }

        private void SetLastTabPageAsSelectedTap()
        {
            tabControl.SelectedTab = tabControl.TabPages[GetLastTabPageIndex(tabControl)];
        }

        private Func<TabControl, int> GetLastTabPageIndex = (tabControl) => tabControl.TabPages.Count - 1;

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count != 0)
            {
                ISearchable child = tabControl.SelectedTab.Controls[0] as ISearchable;
                if (child != null)
                {
                    child.SummaryDataSearch();
                }
            }
        }
    }
}
