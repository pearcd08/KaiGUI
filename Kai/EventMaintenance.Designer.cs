namespace Kai
{
    partial class EventMaintenance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventMaintenance));
            this.btnAddSave = new FontAwesome.Sharp.IconButton();
            this.btnAddCancel = new FontAwesome.Sharp.IconButton();
            this.lblLocationAdd = new System.Windows.Forms.Label();
            this.lblEventNameAdd = new System.Windows.Forms.Label();
            this.txtAddEventName = new System.Windows.Forms.TextBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lblEventDateAdd = new System.Windows.Forms.Label();
            this.dateAddEventDate = new System.Windows.Forms.DateTimePicker();
            this.cboAddLocation = new System.Windows.Forms.ComboBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateUpdateEventDate = new System.Windows.Forms.DateTimePicker();
            this.cboUpdateLocation = new System.Windows.Forms.ComboBox();
            this.btnUpdateSave = new FontAwesome.Sharp.IconButton();
            this.btnUpdateCanel = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateEventName = new System.Windows.Forms.TextBox();
            this.dsKaioordinate = new Kai.dsKaioordinate();
            this.lOCATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOCATIONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelAdd.SuspendLayout();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaioordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.btnAddSave.Size = new System.Drawing.Size(120, 39);
            this.btnAddSave.TabIndex = 33;
            this.btnAddSave.Text = "SAVE   ";
            this.btnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnAddCancel.Location = new System.Drawing.Point(328, 252);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(120, 39);
            this.btnAddCancel.TabIndex = 32;
            this.btnAddCancel.Text = "CANCEL ";
            this.btnAddCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lblLocationAdd
            // 
            this.lblLocationAdd.AutoSize = true;
            this.lblLocationAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocationAdd.Location = new System.Drawing.Point(63, 60);
            this.lblLocationAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationAdd.Name = "lblLocationAdd";
            this.lblLocationAdd.Size = new System.Drawing.Size(81, 24);
            this.lblLocationAdd.TabIndex = 31;
            this.lblLocationAdd.Text = "Location";
            // 
            // lblEventNameAdd
            // 
            this.lblEventNameAdd.AutoSize = true;
            this.lblEventNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventNameAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEventNameAdd.Location = new System.Drawing.Point(31, 5);
            this.lblEventNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventNameAdd.Name = "lblEventNameAdd";
            this.lblEventNameAdd.Size = new System.Drawing.Size(114, 24);
            this.lblEventNameAdd.TabIndex = 30;
            this.lblEventNameAdd.Text = "Event Name";
            // 
            // txtAddEventName
            // 
            this.txtAddEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEventName.Location = new System.Drawing.Point(149, 2);
            this.txtAddEventName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddEventName.Name = "txtAddEventName";
            this.txtAddEventName.Size = new System.Drawing.Size(300, 29);
            this.txtAddEventName.TabIndex = 27;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.lblEventDateAdd);
            this.panelAdd.Controls.Add(this.dateAddEventDate);
            this.panelAdd.Controls.Add(this.cboAddLocation);
            this.panelAdd.Controls.Add(this.btnAddSave);
            this.panelAdd.Controls.Add(this.btnAddCancel);
            this.panelAdd.Controls.Add(this.lblLocationAdd);
            this.panelAdd.Controls.Add(this.lblEventNameAdd);
            this.panelAdd.Controls.Add(this.txtAddEventName);
            this.panelAdd.Location = new System.Drawing.Point(895, 49);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(458, 305);
            this.panelAdd.TabIndex = 45;
            // 
            // lblEventDateAdd
            // 
            this.lblEventDateAdd.AutoSize = true;
            this.lblEventDateAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDateAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEventDateAdd.Location = new System.Drawing.Point(43, 106);
            this.lblEventDateAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDateAdd.Name = "lblEventDateAdd";
            this.lblEventDateAdd.Size = new System.Drawing.Size(101, 24);
            this.lblEventDateAdd.TabIndex = 36;
            this.lblEventDateAdd.Text = "Event Date";
            // 
            // dateAddEventDate
            // 
            this.dateAddEventDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateAddEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateAddEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAddEventDate.Location = new System.Drawing.Point(149, 104);
            this.dateAddEventDate.Name = "dateAddEventDate";
            this.dateAddEventDate.Size = new System.Drawing.Size(148, 29);
            this.dateAddEventDate.TabIndex = 35;
            // 
            // cboAddLocation
            // 
            this.cboAddLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboAddLocation.FormattingEnabled = true;
            this.cboAddLocation.Location = new System.Drawing.Point(149, 55);
            this.cboAddLocation.Name = "cboAddLocation";
            this.cboAddLocation.Size = new System.Drawing.Size(299, 32);
            this.cboAddLocation.TabIndex = 34;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.lblDate);
            this.panelDelete.Controls.Add(this.txtEventDate);
            this.panelDelete.Controls.Add(this.txtLocation);
            this.panelDelete.Controls.Add(this.lblLocation);
            this.panelDelete.Controls.Add(this.lblEventName);
            this.panelDelete.Controls.Add(this.lblEventID);
            this.panelDelete.Controls.Add(this.txtEventName);
            this.panelDelete.Controls.Add(this.txtEventID);
            this.panelDelete.Location = new System.Drawing.Point(390, 50);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(450, 292);
            this.panelDelete.TabIndex = 44;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(44, 160);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 24);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Event Date";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDate.Location = new System.Drawing.Point(149, 157);
            this.txtEventDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventDate.MaxLength = 10;
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.ReadOnly = true;
            this.txtEventDate.Size = new System.Drawing.Size(204, 29);
            this.txtEventDate.TabIndex = 33;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(149, 106);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(300, 29);
            this.txtLocation.TabIndex = 32;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocation.Location = new System.Drawing.Point(65, 109);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(81, 24);
            this.lblLocation.TabIndex = 31;
            this.lblLocation.Text = "Location";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEventName.Location = new System.Drawing.Point(31, 57);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(114, 24);
            this.lblEventName.TabIndex = 30;
            this.lblEventName.Text = "Event Name";
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEventID.Location = new System.Drawing.Point(65, 9);
            this.lblEventID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(80, 24);
            this.lblEventID.TabIndex = 29;
            this.lblEventID.Text = "Event ID";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(149, 55);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(300, 29);
            this.txtEventName.TabIndex = 27;
            // 
            // txtEventID
            // 
            this.txtEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(149, 4);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(100, 29);
            this.txtEventID.TabIndex = 26;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(739, 420);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 100);
            this.btnReturn.TabIndex = 42;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 60;
            this.btnDelete.Location = new System.Drawing.Point(608, 420);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 60;
            this.btnUpdate.Location = new System.Drawing.Point(504, 420);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 60;
            this.btnAdd.Location = new System.Drawing.Point(400, 420);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 60;
            this.btnDown.Location = new System.Drawing.Point(250, 420);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 100);
            this.btnDown.TabIndex = 38;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 60;
            this.btnUp.Location = new System.Drawing.Point(50, 420);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 100);
            this.btnUp.TabIndex = 37;
            this.btnUp.Text = "UP";
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 24;
            this.listBoxEvents.Location = new System.Drawing.Point(50, 50);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(300, 292);
            this.listBoxEvents.TabIndex = 36;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(50, 50);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(291, 292);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 47;
            this.picLogo.TabStop = false;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.label1);
            this.panelUpdate.Controls.Add(this.dateUpdateEventDate);
            this.panelUpdate.Controls.Add(this.cboUpdateLocation);
            this.panelUpdate.Controls.Add(this.btnUpdateSave);
            this.panelUpdate.Controls.Add(this.btnUpdateCanel);
            this.panelUpdate.Controls.Add(this.label2);
            this.panelUpdate.Controls.Add(this.label3);
            this.panelUpdate.Controls.Add(this.txtUpdateEventName);
            this.panelUpdate.Location = new System.Drawing.Point(1384, 49);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(458, 305);
            this.panelUpdate.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(43, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Event Date";
            // 
            // dateUpdateEventDate
            // 
            this.dateUpdateEventDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateUpdateEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateUpdateEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUpdateEventDate.Location = new System.Drawing.Point(149, 104);
            this.dateUpdateEventDate.Name = "dateUpdateEventDate";
            this.dateUpdateEventDate.Size = new System.Drawing.Size(148, 29);
            this.dateUpdateEventDate.TabIndex = 35;
            // 
            // cboUpdateLocation
            // 
            this.cboUpdateLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboUpdateLocation.FormattingEnabled = true;
            this.cboUpdateLocation.Location = new System.Drawing.Point(149, 55);
            this.cboUpdateLocation.Name = "cboUpdateLocation";
            this.cboUpdateLocation.Size = new System.Drawing.Size(299, 32);
            this.cboUpdateLocation.TabIndex = 34;
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
            this.btnUpdateSave.Size = new System.Drawing.Size(120, 39);
            this.btnUpdateSave.TabIndex = 33;
            this.btnUpdateSave.Text = "SAVE   ";
            this.btnUpdateSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSave.UseVisualStyleBackColor = false;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // btnUpdateCanel
            // 
            this.btnUpdateCanel.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCanel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnUpdateCanel.IconColor = System.Drawing.Color.Black;
            this.btnUpdateCanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateCanel.IconSize = 36;
            this.btnUpdateCanel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateCanel.Location = new System.Drawing.Point(328, 252);
            this.btnUpdateCanel.Name = "btnUpdateCanel";
            this.btnUpdateCanel.Size = new System.Drawing.Size(120, 39);
            this.btnUpdateCanel.TabIndex = 32;
            this.btnUpdateCanel.Text = "CANCEL ";
            this.btnUpdateCanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCanel.UseVisualStyleBackColor = false;
            this.btnUpdateCanel.Click += new System.EventHandler(this.btnUpdateCanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(63, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(31, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Event Name";
            // 
            // txtUpdateEventName
            // 
            this.txtUpdateEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateEventName.Location = new System.Drawing.Point(149, 2);
            this.txtUpdateEventName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateEventName.Name = "txtUpdateEventName";
            this.txtUpdateEventName.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateEventName.TabIndex = 27;
            // 
            // dsKaioordinate
            // 
            this.dsKaioordinate.DataSetName = "dsKaioordinate";
            this.dsKaioordinate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOCATIONBindingSource
            // 
            this.lOCATIONBindingSource.DataMember = "LOCATION";
            this.lOCATIONBindingSource.DataSource = this.dsKaioordinate;
            // 
            // lOCATIONBindingSource1
            // 
            this.lOCATIONBindingSource1.DataMember = "LOCATION";
            this.lOCATIONBindingSource1.DataSource = this.dsKaioordinate;
            // 
            // EventMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(2003, 561);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EventMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Maintenance";
            this.Load += new System.EventHandler(this.EventMaintenance_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaioordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAddSave;
        private FontAwesome.Sharp.IconButton btnAddCancel;
        private System.Windows.Forms.Label lblLocationAdd;
        private System.Windows.Forms.Label lblEventNameAdd;
        private System.Windows.Forms.TextBox txtAddEventName;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventID;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DateTimePicker dateAddEventDate;
        private System.Windows.Forms.ComboBox cboAddLocation;
        private System.Windows.Forms.Label lblEventDateAdd;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateUpdateEventDate;
        private System.Windows.Forms.ComboBox cboUpdateLocation;
        private FontAwesome.Sharp.IconButton btnUpdateSave;
        private FontAwesome.Sharp.IconButton btnUpdateCanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateEventName;
        private System.Windows.Forms.BindingSource lOCATIONBindingSource;
        private dsKaioordinate dsKaioordinate;
        private System.Windows.Forms.BindingSource lOCATIONBindingSource1;
    }
}