namespace Kai
{
    partial class Locations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locations));
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.lblLocationAddress = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.txtLocationAddress = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAddSave = new FontAwesome.Sharp.IconButton();
            this.btnAddCancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddLocationAddress = new System.Windows.Forms.TextBox();
            this.txtAddLocationName = new System.Windows.Forms.TextBox();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.btnUpdateSave = new FontAwesome.Sharp.IconButton();
            this.btnUpdateCancel = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateLocationAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateLocationName = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtMessyText = new System.Windows.Forms.TextBox();
            this.panelDelete.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(755, 410);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 100);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 60;
            this.btnDelete.Location = new System.Drawing.Point(614, 410);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 60;
            this.btnUpdate.Location = new System.Drawing.Point(510, 410);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 60;
            this.btnAdd.Location = new System.Drawing.Point(406, 410);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 60;
            this.btnDown.Location = new System.Drawing.Point(221, 410);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 100);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 60;
            this.btnUp.Location = new System.Drawing.Point(30, 410);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 100);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "UP";
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.ItemHeight = 24;
            this.listBoxLocations.Location = new System.Drawing.Point(30, 51);
            this.listBoxLocations.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(291, 244);
            this.listBoxLocations.TabIndex = 19;
            this.listBoxLocations.SelectedIndexChanged += new System.EventHandler(this.listBoxLocations_SelectedIndexChanged);
            // 
            // lblLocationAddress
            // 
            this.lblLocationAddress.AutoSize = true;
            this.lblLocationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocationAddress.Location = new System.Drawing.Point(64, 107);
            this.lblLocationAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationAddress.Name = "lblLocationAddress";
            this.lblLocationAddress.Size = new System.Drawing.Size(80, 24);
            this.lblLocationAddress.TabIndex = 31;
            this.lblLocationAddress.Text = "Address";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocationName.Location = new System.Drawing.Point(7, 57);
            this.lblLocationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(137, 24);
            this.lblLocationName.TabIndex = 30;
            this.lblLocationName.Text = "Location Name";
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocationID.Location = new System.Drawing.Point(41, 7);
            this.lblLocationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(103, 24);
            this.lblLocationID.TabIndex = 29;
            this.lblLocationID.Text = "Location ID";
            // 
            // txtLocationAddress
            // 
            this.txtLocationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationAddress.Location = new System.Drawing.Point(149, 104);
            this.txtLocationAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocationAddress.Multiline = true;
            this.txtLocationAddress.Name = "txtLocationAddress";
            this.txtLocationAddress.ReadOnly = true;
            this.txtLocationAddress.Size = new System.Drawing.Size(300, 177);
            this.txtLocationAddress.TabIndex = 28;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationName.Location = new System.Drawing.Point(149, 54);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.ReadOnly = true;
            this.txtLocationName.Size = new System.Drawing.Size(300, 29);
            this.txtLocationName.TabIndex = 27;
            // 
            // txtLocationID
            // 
            this.txtLocationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationID.Location = new System.Drawing.Point(149, 4);
            this.txtLocationID.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.ReadOnly = true;
            this.txtLocationID.Size = new System.Drawing.Size(100, 29);
            this.txtLocationID.TabIndex = 26;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.lblLocationAddress);
            this.panelDelete.Controls.Add(this.lblLocationName);
            this.panelDelete.Controls.Add(this.lblLocationID);
            this.panelDelete.Controls.Add(this.txtLocationAddress);
            this.panelDelete.Controls.Add(this.txtLocationName);
            this.panelDelete.Controls.Add(this.txtLocationID);
            this.panelDelete.Location = new System.Drawing.Point(406, 47);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(458, 305);
            this.panelDelete.TabIndex = 32;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.btnAddSave);
            this.panelAdd.Controls.Add(this.btnAddCancel);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.txtAddLocationAddress);
            this.panelAdd.Controls.Add(this.txtAddLocationName);
            this.panelAdd.Location = new System.Drawing.Point(870, 47);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(458, 305);
            this.panelAdd.TabIndex = 33;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAddSave.IconColor = System.Drawing.Color.Black;
            this.btnAddSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSave.IconSize = 36;
            this.btnAddSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddSave.Location = new System.Drawing.Point(149, 252);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(148, 39);
            this.btnAddSave.TabIndex = 33;
            this.btnAddSave.Text = "SAVE";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnAddCancel.IconColor = System.Drawing.Color.Black;
            this.btnAddCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCancel.IconSize = 36;
            this.btnAddCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddCancel.Location = new System.Drawing.Point(300, 252);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(148, 39);
            this.btnAddCancel.TabIndex = 32;
            this.btnAddCancel.Text = "CANCEL";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Location Name";
            // 
            // txtAddLocationAddress
            // 
            this.txtAddLocationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLocationAddress.Location = new System.Drawing.Point(148, 57);
            this.txtAddLocationAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddLocationAddress.Multiline = true;
            this.txtAddLocationAddress.Name = "txtAddLocationAddress";
            this.txtAddLocationAddress.Size = new System.Drawing.Size(300, 177);
            this.txtAddLocationAddress.TabIndex = 28;
            // 
            // txtAddLocationName
            // 
            this.txtAddLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLocationName.Location = new System.Drawing.Point(149, 2);
            this.txtAddLocationName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddLocationName.Name = "txtAddLocationName";
            this.txtAddLocationName.Size = new System.Drawing.Size(300, 29);
            this.txtAddLocationName.TabIndex = 27;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.btnUpdateSave);
            this.panelUpdate.Controls.Add(this.btnUpdateCancel);
            this.panelUpdate.Controls.Add(this.label3);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.txtUpdateLocationAddress);
            this.panelUpdate.Controls.Add(this.txtUpdateLocationName);
            this.panelUpdate.Location = new System.Drawing.Point(1334, 47);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(458, 305);
            this.panelUpdate.TabIndex = 34;
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnUpdateSave.IconColor = System.Drawing.Color.Black;
            this.btnUpdateSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateSave.IconSize = 36;
            this.btnUpdateSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateSave.Location = new System.Drawing.Point(149, 252);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(148, 39);
            this.btnUpdateSave.TabIndex = 35;
            this.btnUpdateSave.Text = "SAVE";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnUpdateCancel.IconColor = System.Drawing.Color.Black;
            this.btnUpdateCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateCancel.IconSize = 36;
            this.btnUpdateCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateCancel.Location = new System.Drawing.Point(300, 252);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(148, 39);
            this.btnUpdateCancel.TabIndex = 34;
            this.btnUpdateCancel.Text = "CANCEL";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(64, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Location Name";
            // 
            // txtUpdateLocationAddress
            // 
            this.txtUpdateLocationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateLocationAddress.Location = new System.Drawing.Point(148, 57);
            this.txtUpdateLocationAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateLocationAddress.Multiline = true;
            this.txtUpdateLocationAddress.Name = "txtUpdateLocationAddress";
            this.txtUpdateLocationAddress.Size = new System.Drawing.Size(300, 177);
            this.txtUpdateLocationAddress.TabIndex = 28;
            // 
            // txtUpdateLocationName
            // 
            this.txtUpdateLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateLocationName.Location = new System.Drawing.Point(149, 2);
            this.txtUpdateLocationName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateLocationName.Name = "txtUpdateLocationName";
            this.txtUpdateLocationName.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateLocationName.TabIndex = 27;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(30, 47);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(291, 276);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 35;
            this.picLogo.TabStop = false;
            // 
            // txtMessyText
            // 
            this.txtMessyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessyText.Location = new System.Drawing.Point(30, 344);
            this.txtMessyText.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessyText.Name = "txtMessyText";
            this.txtMessyText.ReadOnly = true;
            this.txtMessyText.Size = new System.Drawing.Size(300, 29);
            this.txtMessyText.TabIndex = 32;
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtMessyText);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Locations";
            this.Text = "Location Management";
            this.Load += new System.EventHandler(this.Locations_Load);
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.ListBox listBoxLocations;
        private System.Windows.Forms.Label lblLocationAddress;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.TextBox txtLocationAddress;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddLocationAddress;
        private System.Windows.Forms.TextBox txtAddLocationName;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateLocationAddress;
        private System.Windows.Forms.TextBox txtUpdateLocationName;
        private FontAwesome.Sharp.IconButton btnAddSave;
        private FontAwesome.Sharp.IconButton btnAddCancel;
        private FontAwesome.Sharp.IconButton btnUpdateSave;
        private FontAwesome.Sharp.IconButton btnUpdateCancel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtMessyText;
    }
}