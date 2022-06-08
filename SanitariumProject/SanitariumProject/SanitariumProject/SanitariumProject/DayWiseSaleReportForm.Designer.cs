namespace SanitariumProject
{
    partial class DayWiseSaleReportForm
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
            this.dtpSD = new System.Windows.Forms.DateTimePicker();
            this.dtpED = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvSaleReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSD
            // 
            this.dtpSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSD.Location = new System.Drawing.Point(225, 58);
            this.dtpSD.Name = "dtpSD";
            this.dtpSD.Size = new System.Drawing.Size(375, 30);
            this.dtpSD.TabIndex = 0;
            // 
            // dtpED
            // 
            this.dtpED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpED.Location = new System.Drawing.Point(620, 58);
            this.dtpED.Name = "dtpED";
            this.dtpED.Size = new System.Drawing.Size(375, 30);
            this.dtpED.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(262, 111);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(662, 51);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvSaleReport
            // 
            this.dgvSaleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleReport.Location = new System.Drawing.Point(45, 195);
            this.dgvSaleReport.Name = "dgvSaleReport";
            this.dgvSaleReport.RowTemplate.Height = 24;
            this.dgvSaleReport.Size = new System.Drawing.Size(1220, 474);
            this.dgvSaleReport.TabIndex = 3;
            // 
            // DayWiseSaleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 703);
            this.Controls.Add(this.dgvSaleReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpED);
            this.Controls.Add(this.dtpSD);
            this.Name = "DayWiseSaleReportForm";
            this.Text = "DayWiseSaleReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSD;
        private System.Windows.Forms.DateTimePicker dtpED;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvSaleReport;
    }
}