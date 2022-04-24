namespace Kai
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.btnGenerateReport = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.ppGenerateReport = new System.Windows.Forms.PrintPreviewDialog();
            this.printEventReport = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerateReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnGenerateReport.IconColor = System.Drawing.Color.Black;
            this.btnGenerateReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerateReport.IconSize = 80;
            this.btnGenerateReport.Location = new System.Drawing.Point(159, 167);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(112, 122);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "GENERATE REPORT";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.iconPrint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(317, 167);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 122);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.iconReturn_Click_1);
            // 
            // ppGenerateReport
            // 
            this.ppGenerateReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppGenerateReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppGenerateReport.ClientSize = new System.Drawing.Size(400, 300);
            this.ppGenerateReport.Enabled = true;
            this.ppGenerateReport.Icon = ((System.Drawing.Icon)(resources.GetObject("ppGenerateReport.Icon")));
            this.ppGenerateReport.Name = "ppGenerateReport";
            this.ppGenerateReport.Visible = false;
            this.ppGenerateReport.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printEventReport
            // 
            this.printEventReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printEventReport_PrintPage);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(588, 456);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnGenerateReport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGenerateReport;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.PrintPreviewDialog ppGenerateReport;
        private System.Drawing.Printing.PrintDocument printEventReport;
    }
}