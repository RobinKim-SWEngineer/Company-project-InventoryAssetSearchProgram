using PCZInventory.Interface;
using QueryResultPrinter;
using QueryResultPrinter.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Func<object, bool> IsNull = (obj) => obj == null;

        private Func<TabControl, int> GetLastTabPageIndex = (tabControl) => tabControl.TabPages.Count - 1;


        private void AddToTabControl(Form form)
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = form.Text;

            form.TopLevel = false;
            form.Parent = tabPage;
            form.Dock = DockStyle.Fill;

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectTab(tabPage);
            tabControl.BringToFront();

            form.Show();
        }

        private void ClearTabPageWithContent(Form form)
        {
            EnableGridSelectionCangedEvent(false);
            tabControl.TabPages.Remove(tabControl.SelectedTab);

            if (tabControl.TabPages.Count == 0)
            {
                tabControl.SendToBack();
                return;
            }
            SetLastTabPageAsSelectedTap();
        }

        private void EnableGridSelectionCangedEvent(Boolean selection)
        {   
            if (tabControl.SelectedTab.Controls.Count == 0)
            {
                return;
            }

            ISelectionChangeNoticeControllable selectionChangeNoticeControllable = tabControl.SelectedTab.Controls[0] as ISelectionChangeNoticeControllable;

            if (!IsNull(selectionChangeNoticeControllable))
            {
                switch (selection)
                {
                    case true:
                        selectionChangeNoticeControllable.EnableSelectionChangeNotice();
                        break;

                    case false:
                        selectionChangeNoticeControllable.DisableSelectionChangeNotice();
                        break;
                }
            }
        }

        private void SetAsSelectedTab(Form form)
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Controls[0].Name == form.Name)
                {
                    tabControl.SelectTab(tabPage);
                }
            }
        }

        TotalInventoryStatus totalInventoryStatus;
        private void totalInventoryDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsNull(totalInventoryStatus))
            {
                totalInventoryStatus = new TotalInventoryStatus();

                AddToTabControl(totalInventoryStatus);

                totalInventoryStatus.FormClosed += new FormClosedEventHandler(TotalInventoryFormClosedEventHandler);
            }
            else
            {
                SetAsSelectedTab(totalInventoryStatus);
            }
        }

        private void TotalInventoryFormClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            totalInventoryStatus = null;
            ClearTabPageWithContent(totalInventoryStatus);
        }

        ClosedInventoryStatusForm closedInventoryStatusForm;
        private void closedInventoryStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsNull(closedInventoryStatusForm))
            {
                closedInventoryStatusForm = new ClosedInventoryStatusForm();

                AddToTabControl(closedInventoryStatusForm);

                closedInventoryStatusForm.FormClosed += new FormClosedEventHandler(ClosedInventoryStatusClosedEventHandler);
            }
            else
            {
                SetAsSelectedTab(closedInventoryStatusForm);
            }
        }
        private void ClosedInventoryStatusClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            closedInventoryStatusForm = null;
            ClearTabPageWithContent(closedInventoryStatusForm);
        }

        ProductInOutDetail productInOutDetail;
        private void productInOutDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsNull(productInOutDetail))
            {
                productInOutDetail = new ProductInOutDetail();

                AddToTabControl(productInOutDetail);
                
                productInOutDetail.FormClosed += new FormClosedEventHandler(ProductInOutDetailClosedEventHandler);
            }
            else
            {
                SetAsSelectedTab(productInOutDetail);
            }
        }

        private void ProductInOutDetailClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            productInOutDetail = null;
            ClearTabPageWithContent(productInOutDetail);
        }

        SemiFinishedInOutDetailForm semiFinishedInOutDetailForm;
        private void semifinishedInOutDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsNull(semiFinishedInOutDetailForm))
            {
                semiFinishedInOutDetailForm = new SemiFinishedInOutDetailForm();

                AddToTabControl(semiFinishedInOutDetailForm);

                semiFinishedInOutDetailForm.FormClosed += new FormClosedEventHandler(SemiFinishedInOutDetailFormClosedEventHandler);
            }
            else
            {
                SetAsSelectedTab(semiFinishedInOutDetailForm);
            }
        }

        private void SemiFinishedInOutDetailFormClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            semiFinishedInOutDetailForm = null;
            ClearTabPageWithContent(semiFinishedInOutDetailForm);
        }

        private void SetLastTabPageAsSelectedTap()
        {
            tabControl.SelectedTab = tabControl.TabPages[GetLastTabPageIndex(tabControl)];
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count != 0)
            {
                ISearchable isSearchable = tabControl.SelectedTab.Controls[0] as ISearchable;
                if (isSearchable != null)
                {
                    isSearchable.SummaryDataSearch();
                }
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count != 0)
            {
                IExportable isExportable = tabControl.SelectedTab.Controls[0] as IExportable;

                if (isExportable != null)
                {
                    isExportable.Export();
                }
            }
        }
    }
}
