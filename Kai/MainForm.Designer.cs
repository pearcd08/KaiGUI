namespace Kai
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.iconKai = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconReport = new FontAwesome.Sharp.IconButton();
            this.iconRegistration = new FontAwesome.Sharp.IconButton();
            this.iconLocations = new FontAwesome.Sharp.IconButton();
            this.IconWhanau = new FontAwesome.Sharp.IconButton();
            this.iconEvents = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconKai
            // 
            this.iconKai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconKai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconKai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconKai.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.iconKai.IconColor = System.Drawing.Color.Black;
            this.iconKai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconKai.IconSize = 80;
            this.iconKai.Location = new System.Drawing.Point(66, 155);
            this.iconKai.Margin = new System.Windows.Forms.Padding(2);
            this.iconKai.Name = "iconKai";
            this.iconKai.Size = new System.Drawing.Size(112, 122);
            this.iconKai.TabIndex = 0;
            this.iconKai.Text = "KAI";
            this.iconKai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconKai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconKai.UseVisualStyleBackColor = true;
            this.iconKai.Click += new System.EventHandler(this.iconKai_Click);
            this.iconKai.MouseLeave += new System.EventHandler(this.iconKai_MouseLeave);
            this.iconKai.MouseHover += new System.EventHandler(this.iconKai_MouseHover);
            // 
            // iconButton5
            // 
            this.iconButton5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 80;
            this.iconButton5.Location = new System.Drawing.Point(417, 282);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(112, 122);
            this.iconButton5.TabIndex = 8;
            this.iconButton5.Text = "EXIT";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconReport
            // 
            this.iconReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconReport.IconColor = System.Drawing.Color.Black;
            this.iconReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReport.IconSize = 80;
            this.iconReport.Location = new System.Drawing.Point(183, 282);
            this.iconReport.Margin = new System.Windows.Forms.Padding(2);
            this.iconReport.Name = "iconReport";
            this.iconReport.Size = new System.Drawing.Size(112, 122);
            this.iconReport.TabIndex = 6;
            this.iconReport.Text = "REPORT";
            this.iconReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconReport.UseVisualStyleBackColor = true;
            this.iconReport.Click += new System.EventHandler(this.iconReport_Click);
            // 
            // iconRegistration
            // 
            this.iconRegistration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconRegistration.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.iconRegistration.IconColor = System.Drawing.Color.Black;
            this.iconRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRegistration.IconSize = 80;
            this.iconRegistration.Location = new System.Drawing.Point(66, 282);
            this.iconRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.iconRegistration.Name = "iconRegistration";
            this.iconRegistration.Size = new System.Drawing.Size(112, 122);
            this.iconRegistration.TabIndex = 5;
            this.iconRegistration.Text = "REGISTRATION";
            this.iconRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconRegistration.UseVisualStyleBackColor = true;
            this.iconRegistration.Click += new System.EventHandler(this.iconRegistration_Click);
            // 
            // iconLocations
            // 
            this.iconLocations.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLocations.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.iconLocations.IconColor = System.Drawing.Color.Black;
            this.iconLocations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLocations.IconSize = 80;
            this.iconLocations.Location = new System.Drawing.Point(417, 155);
            this.iconLocations.Margin = new System.Windows.Forms.Padding(2);
            this.iconLocations.Name = "iconLocations";
            this.iconLocations.Size = new System.Drawing.Size(112, 122);
            this.iconLocations.TabIndex = 4;
            this.iconLocations.Text = "LOCATIONS";
            this.iconLocations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconLocations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconLocations.UseVisualStyleBackColor = true;
            // 
            // IconWhanau
            // 
            this.IconWhanau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconWhanau.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.IconWhanau.IconColor = System.Drawing.Color.Black;
            this.IconWhanau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconWhanau.IconSize = 80;
            this.IconWhanau.Location = new System.Drawing.Point(300, 155);
            this.IconWhanau.Margin = new System.Windows.Forms.Padding(2);
            this.IconWhanau.Name = "IconWhanau";
            this.IconWhanau.Size = new System.Drawing.Size(112, 122);
            this.IconWhanau.TabIndex = 3;
            this.IconWhanau.Text = "WHANAU";
            this.IconWhanau.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IconWhanau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconWhanau.UseVisualStyleBackColor = true;
            this.IconWhanau.Click += new System.EventHandler(this.IconWhanau_Click);
            // 
            // iconEvents
            // 
            this.iconEvents.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconEvents.IconColor = System.Drawing.Color.Black;
            this.iconEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEvents.IconSize = 80;
            this.iconEvents.Location = new System.Drawing.Point(183, 155);
            this.iconEvents.Margin = new System.Windows.Forms.Padding(2);
            this.iconEvents.Name = "iconEvents";
            this.iconEvents.Size = new System.Drawing.Size(112, 122);
            this.iconEvents.TabIndex = 2;
            this.iconEvents.Text = "EVENTS";
            this.iconEvents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconEvents.UseVisualStyleBackColor = true;
            this.iconEvents.Click += new System.EventHandler(this.iconEvents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kai.Properties.Resources.cover;
            this.pictureBox1.InitialImage = global::Kai.Properties.Resources.cover;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(588, 456);
            this.Controls.Add(this.iconKai);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconReport);
            this.Controls.Add(this.iconRegistration);
            this.Controls.Add(this.iconLocations);
            this.Controls.Add(this.IconWhanau);
            this.Controls.Add(this.iconEvents);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Kaioordinate - Community Event Management Software";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconKai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconEvents;
        private FontAwesome.Sharp.IconButton IconWhanau;
        private FontAwesome.Sharp.IconButton iconLocations;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconReport;
        private FontAwesome.Sharp.IconButton iconRegistration;
    }
}

