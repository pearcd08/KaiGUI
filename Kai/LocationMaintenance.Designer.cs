namespace Kai
{
    partial class LocationMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationMaintenance));
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
            this.lblPostCodeAdd = new System.Windows.Forms.Label();
            this.txtAddAddress5 = new System.Windows.Forms.TextBox();
            this.lblCityAdd = new System.Windows.Forms.Label();
            this.lblSuburbAdd = new System.Windows.Forms.Label();
            this.lblStreetAddress2Add = new System.Windows.Forms.Label();
            this.txtAddAddress4 = new System.Windows.Forms.TextBox();
            this.btnAddSave = new FontAwesome.Sharp.IconButton();
            this.btnAddCancel = new FontAwesome.Sharp.IconButton();
            this.txtAddAddress3 = new System.Windows.Forms.TextBox();
            this.lblStreetAddress1Add = new System.Windows.Forms.Label();
            this.lblLocationNameAdd = new System.Windows.Forms.Label();
            this.txtAddAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddLocationName = new System.Windows.Forms.TextBox();
            this.txtAddAddress1 = new System.Windows.Forms.TextBox();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.lblPostCodeUpdate = new System.Windows.Forms.Label();
            this.txtUpdateAddress5 = new System.Windows.Forms.TextBox();
            this.lblCItyUpdate = new System.Windows.Forms.Label();
            this.txtUpdateAddress4 = new System.Windows.Forms.TextBox();
            this.lblSuburbUpdate = new System.Windows.Forms.Label();
            this.btnUpdateSave = new FontAwesome.Sharp.IconButton();
            this.lblStreetAddress2 = new System.Windows.Forms.Label();
            this.txtUpdateAddress3 = new System.Windows.Forms.TextBox();
            this.lblStreetAddress1Update = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new FontAwesome.Sharp.IconButton();
            this.txtUpdateAddress2 = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress1 = new System.Windows.Forms.TextBox();
            this.lblLocationNameUpdate = new System.Windows.Forms.Label();
            this.txtUpdateLocationName = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelDelete.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(755, 425);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 100);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 60;
            this.btnDelete.Location = new System.Drawing.Point(614, 425);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 60;
            this.btnUpdate.Location = new System.Drawing.Point(510, 425);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 60;
            this.btnAdd.Location = new System.Drawing.Point(406, 425);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.Control;
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 60;
            this.btnDown.Location = new System.Drawing.Point(231, 425);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 100);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 60;
            this.btnUp.Location = new System.Drawing.Point(40, 425);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 100);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "UP";
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.ItemHeight = 24;
            this.listBoxLocations.Location = new System.Drawing.Point(40, 40);
            this.listBoxLocations.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(291, 292);
            this.listBoxLocations.TabIndex = 19;
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
            this.lblLocationID.Location = new System.Drawing.Point(42, 3);
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
            this.txtLocationAddress.Size = new System.Drawing.Size(300, 172);
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
            this.txtLocationID.Location = new System.Drawing.Point(149, 0);
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
            this.panelDelete.Location = new System.Drawing.Point(406, 38);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(458, 305);
            this.panelDelete.TabIndex = 32;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.lblPostCodeAdd);
            this.panelAdd.Controls.Add(this.txtAddAddress5);
            this.panelAdd.Controls.Add(this.lblCityAdd);
            this.panelAdd.Controls.Add(this.lblSuburbAdd);
            this.panelAdd.Controls.Add(this.lblStreetAddress2Add);
            this.panelAdd.Controls.Add(this.txtAddAddress4);
            this.panelAdd.Controls.Add(this.btnAddSave);
            this.panelAdd.Controls.Add(this.btnAddCancel);
            this.panelAdd.Controls.Add(this.txtAddAddress3);
            this.panelAdd.Controls.Add(this.lblStreetAddress1Add);
            this.panelAdd.Controls.Add(this.lblLocationNameAdd);
            this.panelAdd.Controls.Add(this.txtAddAddress2);
            this.panelAdd.Controls.Add(this.txtAddLocationName);
            this.panelAdd.Controls.Add(this.txtAddAddress1);
            this.panelAdd.Location = new System.Drawing.Point(975, 40);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(458, 305);
            this.panelAdd.TabIndex = 33;
            // 
            // lblPostCodeAdd
            // 
            this.lblPostCodeAdd.AutoSize = true;
            this.lblPostCodeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCodeAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPostCodeAdd.Location = new System.Drawing.Point(55, 195);
            this.lblPostCodeAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostCodeAdd.Name = "lblPostCodeAdd";
            this.lblPostCodeAdd.Size = new System.Drawing.Size(89, 24);
            this.lblPostCodeAdd.TabIndex = 46;
            this.lblPostCodeAdd.Text = "Postcode";
            // 
            // txtAddAddress5
            // 
            this.txtAddAddress5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress5.Location = new System.Drawing.Point(149, 192);
            this.txtAddAddress5.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddAddress5.Name = "txtAddAddress5";
            this.txtAddAddress5.Size = new System.Drawing.Size(100, 29);
            this.txtAddAddress5.TabIndex = 45;
            this.txtAddAddress5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddAddress5_KeyPress);
            // 
            // lblCityAdd
            // 
            this.lblCityAdd.AutoSize = true;
            this.lblCityAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCityAdd.Location = new System.Drawing.Point(104, 159);
            this.lblCityAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCityAdd.Name = "lblCityAdd";
            this.lblCityAdd.Size = new System.Drawing.Size(40, 24);
            this.lblCityAdd.TabIndex = 44;
            this.lblCityAdd.Text = "City";
            // 
            // lblSuburbAdd
            // 
            this.lblSuburbAdd.AutoSize = true;
            this.lblSuburbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburbAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSuburbAdd.Location = new System.Drawing.Point(72, 129);
            this.lblSuburbAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuburbAdd.Name = "lblSuburbAdd";
            this.lblSuburbAdd.Size = new System.Drawing.Size(72, 24);
            this.lblSuburbAdd.TabIndex = 43;
            this.lblSuburbAdd.Text = "Suburb";
            // 
            // lblStreetAddress2Add
            // 
            this.lblStreetAddress2Add.AutoSize = true;
            this.lblStreetAddress2Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress2Add.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStreetAddress2Add.Location = new System.Drawing.Point(-4, 98);
            this.lblStreetAddress2Add.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress2Add.Name = "lblStreetAddress2Add";
            this.lblStreetAddress2Add.Size = new System.Drawing.Size(148, 24);
            this.lblStreetAddress2Add.TabIndex = 42;
            this.lblStreetAddress2Add.Text = "Street Address 2";
            // 
            // txtAddAddress4
            // 
            this.txtAddAddress4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress4.Location = new System.Drawing.Point(149, 159);
            this.txtAddAddress4.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddAddress4.Name = "txtAddAddress4";
            this.txtAddAddress4.Size = new System.Drawing.Size(300, 29);
            this.txtAddAddress4.TabIndex = 41;
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // txtAddAddress3
            // 
            this.txtAddAddress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress3.Location = new System.Drawing.Point(149, 126);
            this.txtAddAddress3.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddAddress3.Name = "txtAddAddress3";
            this.txtAddAddress3.Size = new System.Drawing.Size(300, 29);
            this.txtAddAddress3.TabIndex = 40;
            // 
            // lblStreetAddress1Add
            // 
            this.lblStreetAddress1Add.AutoSize = true;
            this.lblStreetAddress1Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress1Add.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStreetAddress1Add.Location = new System.Drawing.Point(-4, 63);
            this.lblStreetAddress1Add.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress1Add.Name = "lblStreetAddress1Add";
            this.lblStreetAddress1Add.Size = new System.Drawing.Size(148, 24);
            this.lblStreetAddress1Add.TabIndex = 31;
            this.lblStreetAddress1Add.Text = "Street Address 1";
            // 
            // lblLocationNameAdd
            // 
            this.lblLocationNameAdd.AutoSize = true;
            this.lblLocationNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationNameAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocationNameAdd.Location = new System.Drawing.Point(8, 5);
            this.lblLocationNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationNameAdd.Name = "lblLocationNameAdd";
            this.lblLocationNameAdd.Size = new System.Drawing.Size(137, 24);
            this.lblLocationNameAdd.TabIndex = 30;
            this.lblLocationNameAdd.Text = "Location Name";
            // 
            // txtAddAddress2
            // 
            this.txtAddAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress2.Location = new System.Drawing.Point(148, 93);
            this.txtAddAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddAddress2.Name = "txtAddAddress2";
            this.txtAddAddress2.Size = new System.Drawing.Size(300, 29);
            this.txtAddAddress2.TabIndex = 39;
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
            // txtAddAddress1
            // 
            this.txtAddAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress1.Location = new System.Drawing.Point(148, 60);
            this.txtAddAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddAddress1.Name = "txtAddAddress1";
            this.txtAddAddress1.Size = new System.Drawing.Size(300, 29);
            this.txtAddAddress1.TabIndex = 38;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.lblPostCodeUpdate);
            this.panelUpdate.Controls.Add(this.txtUpdateAddress5);
            this.panelUpdate.Controls.Add(this.lblCItyUpdate);
            this.panelUpdate.Controls.Add(this.txtUpdateAddress4);
            this.panelUpdate.Controls.Add(this.lblSuburbUpdate);
            this.panelUpdate.Controls.Add(this.btnUpdateSave);
            this.panelUpdate.Controls.Add(this.lblStreetAddress2);
            this.panelUpdate.Controls.Add(this.txtUpdateAddress3);
            this.panelUpdate.Controls.Add(this.lblStreetAddress1Update);
            this.panelUpdate.Controls.Add(this.btnUpdateCancel);
            this.panelUpdate.Controls.Add(this.txtUpdateAddress2);
            this.panelUpdate.Controls.Add(this.txtUpdateAddress1);
            this.panelUpdate.Controls.Add(this.lblLocationNameUpdate);
            this.panelUpdate.Controls.Add(this.txtUpdateLocationName);
            this.panelUpdate.Location = new System.Drawing.Point(1334, 47);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(458, 305);
            this.panelUpdate.TabIndex = 34;
            // 
            // lblPostCodeUpdate
            // 
            this.lblPostCodeUpdate.AutoSize = true;
            this.lblPostCodeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCodeUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPostCodeUpdate.Location = new System.Drawing.Point(55, 195);
            this.lblPostCodeUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostCodeUpdate.Name = "lblPostCodeUpdate";
            this.lblPostCodeUpdate.Size = new System.Drawing.Size(89, 24);
            this.lblPostCodeUpdate.TabIndex = 47;
            this.lblPostCodeUpdate.Text = "Postcode";
            // 
            // txtUpdateAddress5
            // 
            this.txtUpdateAddress5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAddress5.Location = new System.Drawing.Point(150, 192);
            this.txtUpdateAddress5.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateAddress5.Name = "txtUpdateAddress5";
            this.txtUpdateAddress5.Size = new System.Drawing.Size(100, 29);
            this.txtUpdateAddress5.TabIndex = 47;
            this.txtUpdateAddress5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateAddress5_KeyPress);
            // 
            // lblCItyUpdate
            // 
            this.lblCItyUpdate.AutoSize = true;
            this.lblCItyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCItyUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCItyUpdate.Location = new System.Drawing.Point(104, 159);
            this.lblCItyUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCItyUpdate.Name = "lblCItyUpdate";
            this.lblCItyUpdate.Size = new System.Drawing.Size(40, 24);
            this.lblCItyUpdate.TabIndex = 48;
            this.lblCItyUpdate.Text = "City";
            // 
            // txtUpdateAddress4
            // 
            this.txtUpdateAddress4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAddress4.Location = new System.Drawing.Point(150, 159);
            this.txtUpdateAddress4.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateAddress4.Name = "txtUpdateAddress4";
            this.txtUpdateAddress4.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateAddress4.TabIndex = 37;
            // 
            // lblSuburbUpdate
            // 
            this.lblSuburbUpdate.AutoSize = true;
            this.lblSuburbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburbUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSuburbUpdate.Location = new System.Drawing.Point(72, 129);
            this.lblSuburbUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuburbUpdate.Name = "lblSuburbUpdate";
            this.lblSuburbUpdate.Size = new System.Drawing.Size(72, 24);
            this.lblSuburbUpdate.TabIndex = 47;
            this.lblSuburbUpdate.Text = "Suburb";
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnUpdateSave.UseVisualStyleBackColor = false;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // lblStreetAddress2
            // 
            this.lblStreetAddress2.AutoSize = true;
            this.lblStreetAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStreetAddress2.Location = new System.Drawing.Point(-4, 98);
            this.lblStreetAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress2.Name = "lblStreetAddress2";
            this.lblStreetAddress2.Size = new System.Drawing.Size(148, 24);
            this.lblStreetAddress2.TabIndex = 46;
            this.lblStreetAddress2.Text = "Street Address 2";
            // 
            // txtUpdateAddress3
            // 
            this.txtUpdateAddress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAddress3.Location = new System.Drawing.Point(150, 126);
            this.txtUpdateAddress3.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateAddress3.Name = "txtUpdateAddress3";
            this.txtUpdateAddress3.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateAddress3.TabIndex = 36;
            // 
            // lblStreetAddress1Update
            // 
            this.lblStreetAddress1Update.AutoSize = true;
            this.lblStreetAddress1Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress1Update.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStreetAddress1Update.Location = new System.Drawing.Point(-4, 63);
            this.lblStreetAddress1Update.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress1Update.Name = "lblStreetAddress1Update";
            this.lblStreetAddress1Update.Size = new System.Drawing.Size(148, 24);
            this.lblStreetAddress1Update.TabIndex = 45;
            this.lblStreetAddress1Update.Text = "Street Address 1";
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnUpdateCancel.UseVisualStyleBackColor = false;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtUpdateAddress2
            // 
            this.txtUpdateAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAddress2.Location = new System.Drawing.Point(149, 93);
            this.txtUpdateAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateAddress2.Name = "txtUpdateAddress2";
            this.txtUpdateAddress2.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateAddress2.TabIndex = 35;
            // 
            // txtUpdateAddress1
            // 
            this.txtUpdateAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAddress1.Location = new System.Drawing.Point(149, 60);
            this.txtUpdateAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateAddress1.Name = "txtUpdateAddress1";
            this.txtUpdateAddress1.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateAddress1.TabIndex = 34;
            // 
            // lblLocationNameUpdate
            // 
            this.lblLocationNameUpdate.AutoSize = true;
            this.lblLocationNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationNameUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocationNameUpdate.Location = new System.Drawing.Point(8, 5);
            this.lblLocationNameUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationNameUpdate.Name = "lblLocationNameUpdate";
            this.lblLocationNameUpdate.Size = new System.Drawing.Size(137, 24);
            this.lblLocationNameUpdate.TabIndex = 30;
            this.lblLocationNameUpdate.Text = "Location Name";
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
            this.picLogo.Location = new System.Drawing.Point(40, 40);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(291, 276);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 35;
            this.picLogo.TabStop = false;
            // 
            // LocationMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1806, 561);
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
            this.Name = "LocationMaintenance";
            this.Text = "Location Maintenence";
            this.Load += new System.EventHandler(this.Locations_Load);
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblLocationNameAdd;
        private System.Windows.Forms.TextBox txtAddLocationName;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label lblLocationNameUpdate;
        private System.Windows.Forms.TextBox txtUpdateLocationName;
        private FontAwesome.Sharp.IconButton btnAddSave;
        private FontAwesome.Sharp.IconButton btnAddCancel;
        private FontAwesome.Sharp.IconButton btnUpdateSave;
        private FontAwesome.Sharp.IconButton btnUpdateCancel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtUpdateAddress4;
        private System.Windows.Forms.TextBox txtUpdateAddress3;
        private System.Windows.Forms.TextBox txtUpdateAddress2;
        private System.Windows.Forms.TextBox txtUpdateAddress1;
        private System.Windows.Forms.TextBox txtAddAddress4;
        private System.Windows.Forms.TextBox txtAddAddress3;
        private System.Windows.Forms.TextBox txtAddAddress2;
        private System.Windows.Forms.TextBox txtAddAddress1;
        private System.Windows.Forms.Label lblCityAdd;
        private System.Windows.Forms.Label lblSuburbAdd;
        private System.Windows.Forms.Label lblStreetAddress2Add;
        private System.Windows.Forms.Label lblStreetAddress1Add;
        private System.Windows.Forms.Label lblCItyUpdate;
        private System.Windows.Forms.Label lblSuburbUpdate;
        private System.Windows.Forms.Label lblStreetAddress2;
        private System.Windows.Forms.Label lblStreetAddress1Update;
        private System.Windows.Forms.Label lblPostCodeAdd;
        private System.Windows.Forms.TextBox txtAddAddress5;
        private System.Windows.Forms.Label lblPostCodeUpdate;
        private System.Windows.Forms.TextBox txtUpdateAddress5;
    }
}