
namespace QueryResultPrinter
{
    partial class ClosedInventoryStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridClosedMonths = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridClosedMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClosedMonths
            // 
            this.gridClosedMonths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClosedMonths.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridClosedMonths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClosedMonths.Location = new System.Drawing.Point(12, 12);
            this.gridClosedMonths.Name = "gridClosedMonths";
            this.gridClosedMonths.RowHeadersWidth = 51;
            this.gridClosedMonths.RowTemplate.Height = 24;
            this.gridClosedMonths.Size = new System.Drawing.Size(419, 889);
            this.gridClosedMonths.TabIndex = 0;
            // 
            // ClosedInventoryStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 913);
            this.Controls.Add(this.gridClosedMonths);
            this.Name = "ClosedInventoryStatusForm";
            this.Text = "Closed Inventory Status";
            this.Load += new System.EventHandler(this.ClosedInventoryStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClosedMonths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClosedMonths;
    }
}