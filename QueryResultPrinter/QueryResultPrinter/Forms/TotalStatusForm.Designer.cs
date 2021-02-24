
namespace TotalInventory
{
    partial class TotalInventoryStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSelectedTypes = new System.Windows.Forms.Label();
            this.labelTotalSummary = new System.Windows.Forms.Label();
            this.labelTotalDetail = new System.Windows.Forms.Label();
            this.gridDetailData = new System.Windows.Forms.DataGridView();
            this.labelDatePicker = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gridSummaryData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummaryData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectedTypes
            // 
            this.labelSelectedTypes.AutoSize = true;
            this.labelSelectedTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelSelectedTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedTypes.ForeColor = System.Drawing.Color.Gray;
            this.labelSelectedTypes.Location = new System.Drawing.Point(260, 267);
            this.labelSelectedTypes.Name = "labelSelectedTypes";
            this.labelSelectedTypes.Size = new System.Drawing.Size(0, 20);
            this.labelSelectedTypes.TabIndex = 11;
            // 
            // labelTotalSummary
            // 
            this.labelTotalSummary.AutoSize = true;
            this.labelTotalSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSummary.Location = new System.Drawing.Point(17, 49);
            this.labelTotalSummary.Name = "labelTotalSummary";
            this.labelTotalSummary.Size = new System.Drawing.Size(217, 20);
            this.labelTotalSummary.TabIndex = 26;
            this.labelTotalSummary.Text = "Total Inventory Summary";
            // 
            // labelTotalDetail
            // 
            this.labelTotalDetail.AutoSize = true;
            this.labelTotalDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDetail.Location = new System.Drawing.Point(17, 269);
            this.labelTotalDetail.Name = "labelTotalDetail";
            this.labelTotalDetail.Size = new System.Drawing.Size(288, 20);
            this.labelTotalDetail.TabIndex = 25;
            this.labelTotalDetail.Text = "Inventory Detail By Cost Account";
            // 
            // gridDetailData
            // 
            this.gridDetailData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetailData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridDetailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetailData.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetailData.Location = new System.Drawing.Point(6, 294);
            this.gridDetailData.Name = "gridDetailData";
            this.gridDetailData.RowHeadersWidth = 51;
            this.gridDetailData.RowTemplate.Height = 24;
            this.gridDetailData.Size = new System.Drawing.Size(1990, 749);
            this.gridDetailData.TabIndex = 24;
            // 
            // labelDatePicker
            // 
            this.labelDatePicker.AutoSize = true;
            this.labelDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatePicker.Location = new System.Drawing.Point(18, 17);
            this.labelDatePicker.Name = "labelDatePicker";
            this.labelDatePicker.Size = new System.Drawing.Size(176, 20);
            this.labelDatePicker.TabIndex = 23;
            this.labelDatePicker.Text = "Select month and year";
            this.labelDatePicker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
            this.dateTimePicker.Location = new System.Drawing.Point(200, 17);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(254, 22);
            this.dateTimePicker.TabIndex = 22;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // gridSummaryData
            // 
            this.gridSummaryData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSummaryData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridSummaryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSummaryData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSummaryData.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.gridSummaryData.Location = new System.Drawing.Point(6, 72);
            this.gridSummaryData.Name = "gridSummaryData";
            this.gridSummaryData.RowHeadersWidth = 51;
            this.gridSummaryData.RowTemplate.Height = 24;
            this.gridSummaryData.Size = new System.Drawing.Size(1990, 180);
            this.gridSummaryData.TabIndex = 19;
            this.gridSummaryData.SelectionChanged += new System.EventHandler(this.gridSummaryData_SelectionChanged);
            // 
            // TotalInventoryStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2002, 1048);
            this.Controls.Add(this.labelTotalSummary);
            this.Controls.Add(this.labelTotalDetail);
            this.Controls.Add(this.gridDetailData);
            this.Controls.Add(this.labelDatePicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.gridSummaryData);
            this.Controls.Add(this.labelSelectedTypes);
            this.Name = "TotalInventoryStatus";
            this.Text = "Total Inventory";
            this.Load += new System.EventHandler(this.TotalInventoryStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSummaryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelSelectedTypes;
        public System.Windows.Forms.Label labelTotalSummary;
        public System.Windows.Forms.Label labelTotalDetail;
        public System.Windows.Forms.DataGridView gridDetailData;
        public System.Windows.Forms.Label labelDatePicker;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.DataGridView gridSummaryData;
        public bool IsDetailDataShowUpAllowed = false;
    }
}

