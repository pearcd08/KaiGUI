namespace Kai
{
    partial class KaiMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaiMaintenance));
            this.listBoxKai = new System.Windows.Forms.ListBox();
            this.kAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKaioordinate = new Kai.dsKaioordinate();
            this.txtKaiID = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtKaiName = new System.Windows.Forms.TextBox();
            this.lblKaiID = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblKaiName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPreparationTime = new System.Windows.Forms.Label();
            this.lblPreparation = new System.Windows.Forms.Label();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.txtPreperationTime = new System.Windows.Forms.TextBox();
            this.txtServingQuantity = new System.Windows.Forms.TextBox();
            this.txtPreperation = new System.Windows.Forms.TextBox();
            this.cboUpdateEvent = new System.Windows.Forms.ComboBox();
            this.cboxUpdatePreparation = new System.Windows.Forms.CheckBox();
            this.numUpdateServingQuantity = new System.Windows.Forms.NumericUpDown();
            this.numUpdatePreparationTime = new System.Windows.Forms.NumericUpDown();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.lblMinutesUpdate = new System.Windows.Forms.Label();
            this.btnUpdateSave = new FontAwesome.Sharp.IconButton();
            this.lblKaiNameUpdate = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new FontAwesome.Sharp.IconButton();
            this.txtUpdateKaiName = new System.Windows.Forms.TextBox();
            this.lblEventUpdate = new System.Windows.Forms.Label();
            this.lblPreparationUpdate = new System.Windows.Forms.Label();
            this.lblServingQuantityUpdate = new System.Windows.Forms.Label();
            this.lblPreparationTimeUpdate = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAddSave = new FontAwesome.Sharp.IconButton();
            this.lblKaiNameAdd = new System.Windows.Forms.Label();
            this.btnAddCancel = new FontAwesome.Sharp.IconButton();
            this.txtAddKaiName = new System.Windows.Forms.TextBox();
            this.lblEventAdd = new System.Windows.Forms.Label();
            this.lblPreparationAdd = new System.Windows.Forms.Label();
            this.lblServingQuantityAdd = new System.Windows.Forms.Label();
            this.lblPreparationTimeAdd = new System.Windows.Forms.Label();
            this.numAddPreparationTime = new System.Windows.Forms.NumericUpDown();
            this.numAddServingQuantity = new System.Windows.Forms.NumericUpDown();
            this.cboxAddPreparation = new System.Windows.Forms.CheckBox();
            this.cboAddEvent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaioordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateServingQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdatePreparationTime)).BeginInit();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelDelete.SuspendLayout();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPreparationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddServingQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKai
            // 
            this.listBoxKai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxKai.FormattingEnabled = true;
            this.listBoxKai.ItemHeight = 24;
            this.listBoxKai.Location = new System.Drawing.Point(40, 40);
            this.listBoxKai.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxKai.Name = "listBoxKai";
            this.listBoxKai.Size = new System.Drawing.Size(291, 316);
            this.listBoxKai.TabIndex = 0;
            this.listBoxKai.SelectedIndexChanged += new System.EventHandler(this.listBoxKai_SelectedIndexChanged);
            // 
            // kAIBindingSource
            // 
            this.kAIBindingSource.DataMember = "KAI";
            this.kAIBindingSource.DataSource = this.dsKaioordinate;
            // 
            // dsKaioordinate
            // 
            this.dsKaioordinate.DataSetName = "dsKaioordinate";
            this.dsKaioordinate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtKaiID
            // 
            this.txtKaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaiID.Location = new System.Drawing.Point(182, 7);
            this.txtKaiID.Margin = new System.Windows.Forms.Padding(2);
            this.txtKaiID.Name = "txtKaiID";
            this.txtKaiID.ReadOnly = true;
            this.txtKaiID.Size = new System.Drawing.Size(100, 29);
            this.txtKaiID.TabIndex = 1;
            // 
            // txtEvent
            // 
            this.txtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent.Location = new System.Drawing.Point(183, 55);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.ReadOnly = true;
            this.txtEvent.Size = new System.Drawing.Size(300, 29);
            this.txtEvent.TabIndex = 2;
            // 
            // txtKaiName
            // 
            this.txtKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaiName.Location = new System.Drawing.Point(182, 107);
            this.txtKaiName.Margin = new System.Windows.Forms.Padding(2);
            this.txtKaiName.Name = "txtKaiName";
            this.txtKaiName.ReadOnly = true;
            this.txtKaiName.Size = new System.Drawing.Size(300, 29);
            this.txtKaiName.TabIndex = 5;
            // 
            // lblKaiID
            // 
            this.lblKaiID.AutoSize = true;
            this.lblKaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKaiID.Location = new System.Drawing.Point(120, 10);
            this.lblKaiID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaiID.Name = "lblKaiID";
            this.lblKaiID.Size = new System.Drawing.Size(58, 24);
            this.lblKaiID.TabIndex = 7;
            this.lblKaiID.Text = "Kai ID";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEvent.Location = new System.Drawing.Point(120, 60);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(58, 24);
            this.lblEvent.TabIndex = 8;
            this.lblEvent.Text = "Event";
            // 
            // lblKaiName
            // 
            this.lblKaiName.AutoSize = true;
            this.lblKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKaiName.Location = new System.Drawing.Point(86, 110);
            this.lblKaiName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaiName.Name = "lblKaiName";
            this.lblKaiName.Size = new System.Drawing.Size(92, 24);
            this.lblKaiName.TabIndex = 9;
            this.lblKaiName.Text = "Kai Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(31, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Serving Quantity";
            // 
            // lblPreparationTime
            // 
            this.lblPreparationTime.AutoSize = true;
            this.lblPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparationTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreparationTime.Location = new System.Drawing.Point(23, 209);
            this.lblPreparationTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreparationTime.Name = "lblPreparationTime";
            this.lblPreparationTime.Size = new System.Drawing.Size(154, 24);
            this.lblPreparationTime.TabIndex = 11;
            this.lblPreparationTime.Text = "Preparation Time";
            // 
            // lblPreparation
            // 
            this.lblPreparation.AutoSize = true;
            this.lblPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparation.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreparation.Location = new System.Drawing.Point(61, 160);
            this.lblPreparation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreparation.Name = "lblPreparation";
            this.lblPreparation.Size = new System.Drawing.Size(116, 24);
            this.lblPreparation.TabIndex = 12;
            this.lblPreparation.Text = "Preparation?";
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 60;
            this.btnUp.Location = new System.Drawing.Point(40, 409);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 100);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "UP";
            this.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 60;
            this.btnDown.Location = new System.Drawing.Point(231, 409);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 100);
            this.btnDown.TabIndex = 14;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 60;
            this.btnAdd.Location = new System.Drawing.Point(396, 409);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 60;
            this.btnUpdate.Location = new System.Drawing.Point(500, 409);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 100);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 60;
            this.btnDelete.Location = new System.Drawing.Point(604, 409);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(752, 409);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 100);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.iconReturn_Click);
            // 
            // txtPreperationTime
            // 
            this.txtPreperationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreperationTime.Location = new System.Drawing.Point(183, 206);
            this.txtPreperationTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreperationTime.Name = "txtPreperationTime";
            this.txtPreperationTime.ReadOnly = true;
            this.txtPreperationTime.Size = new System.Drawing.Size(100, 29);
            this.txtPreperationTime.TabIndex = 19;
            // 
            // txtServingQuantity
            // 
            this.txtServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServingQuantity.Location = new System.Drawing.Point(183, 254);
            this.txtServingQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtServingQuantity.Name = "txtServingQuantity";
            this.txtServingQuantity.ReadOnly = true;
            this.txtServingQuantity.Size = new System.Drawing.Size(100, 29);
            this.txtServingQuantity.TabIndex = 20;
            // 
            // txtPreperation
            // 
            this.txtPreperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreperation.Location = new System.Drawing.Point(183, 160);
            this.txtPreperation.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreperation.Name = "txtPreperation";
            this.txtPreperation.ReadOnly = true;
            this.txtPreperation.Size = new System.Drawing.Size(100, 29);
            this.txtPreperation.TabIndex = 21;
            // 
            // cboUpdateEvent
            // 
            this.cboUpdateEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateEvent.FormattingEnabled = true;
            this.cboUpdateEvent.Location = new System.Drawing.Point(165, 16);
            this.cboUpdateEvent.Name = "cboUpdateEvent";
            this.cboUpdateEvent.Size = new System.Drawing.Size(300, 32);
            this.cboUpdateEvent.TabIndex = 22;
            // 
            // cboxUpdatePreparation
            // 
            this.cboxUpdatePreparation.AutoSize = true;
            this.cboxUpdatePreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboxUpdatePreparation.Location = new System.Drawing.Point(165, 122);
            this.cboxUpdatePreparation.Name = "cboxUpdatePreparation";
            this.cboxUpdatePreparation.Size = new System.Drawing.Size(15, 14);
            this.cboxUpdatePreparation.TabIndex = 23;
            this.cboxUpdatePreparation.UseVisualStyleBackColor = true;
            this.cboxUpdatePreparation.CheckedChanged += new System.EventHandler(this.cboxUpdatePreparation_CheckedChanged_1);
            // 
            // numUpdateServingQuantity
            // 
            this.numUpdateServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpdateServingQuantity.Location = new System.Drawing.Point(165, 210);
            this.numUpdateServingQuantity.Name = "numUpdateServingQuantity";
            this.numUpdateServingQuantity.Size = new System.Drawing.Size(100, 29);
            this.numUpdateServingQuantity.TabIndex = 24;
            // 
            // numUpdatePreparationTime
            // 
            this.numUpdatePreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpdatePreparationTime.Location = new System.Drawing.Point(165, 167);
            this.numUpdatePreparationTime.Name = "numUpdatePreparationTime";
            this.numUpdatePreparationTime.Size = new System.Drawing.Size(100, 29);
            this.numUpdatePreparationTime.TabIndex = 25;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.lblMinutesUpdate);
            this.panelUpdate.Controls.Add(this.btnUpdateSave);
            this.panelUpdate.Controls.Add(this.lblKaiNameUpdate);
            this.panelUpdate.Controls.Add(this.btnUpdateCancel);
            this.panelUpdate.Controls.Add(this.txtUpdateKaiName);
            this.panelUpdate.Controls.Add(this.lblEventUpdate);
            this.panelUpdate.Controls.Add(this.lblPreparationUpdate);
            this.panelUpdate.Controls.Add(this.lblServingQuantityUpdate);
            this.panelUpdate.Controls.Add(this.lblPreparationTimeUpdate);
            this.panelUpdate.Controls.Add(this.numUpdatePreparationTime);
            this.panelUpdate.Controls.Add(this.numUpdateServingQuantity);
            this.panelUpdate.Controls.Add(this.cboxUpdatePreparation);
            this.panelUpdate.Controls.Add(this.cboUpdateEvent);
            this.panelUpdate.Location = new System.Drawing.Point(1427, 43);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(507, 354);
            this.panelUpdate.TabIndex = 27;
            this.panelUpdate.Visible = false;
            // 
            // lblMinutesUpdate
            // 
            this.lblMinutesUpdate.AutoSize = true;
            this.lblMinutesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinutesUpdate.Location = new System.Drawing.Point(270, 172);
            this.lblMinutesUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutesUpdate.Name = "lblMinutesUpdate";
            this.lblMinutesUpdate.Size = new System.Drawing.Size(76, 24);
            this.lblMinutesUpdate.TabIndex = 30;
            this.lblMinutesUpdate.Text = "minutes";
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnUpdateSave.IconColor = System.Drawing.Color.Black;
            this.btnUpdateSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateSave.IconSize = 36;
            this.btnUpdateSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateSave.Location = new System.Drawing.Point(117, 265);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(148, 39);
            this.btnUpdateSave.TabIndex = 29;
            this.btnUpdateSave.Text = "SAVE";
            this.btnUpdateSave.UseVisualStyleBackColor = false;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // lblKaiNameUpdate
            // 
            this.lblKaiNameUpdate.AutoSize = true;
            this.lblKaiNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiNameUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKaiNameUpdate.Location = new System.Drawing.Point(68, 69);
            this.lblKaiNameUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaiNameUpdate.Name = "lblKaiNameUpdate";
            this.lblKaiNameUpdate.Size = new System.Drawing.Size(92, 24);
            this.lblKaiNameUpdate.TabIndex = 28;
            this.lblKaiNameUpdate.Text = "Kai Name";
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnUpdateCancel.IconColor = System.Drawing.Color.Black;
            this.btnUpdateCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateCancel.IconSize = 36;
            this.btnUpdateCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdateCancel.Location = new System.Drawing.Point(317, 265);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(148, 39);
            this.btnUpdateCancel.TabIndex = 26;
            this.btnUpdateCancel.Text = "CANCEL";
            this.btnUpdateCancel.UseVisualStyleBackColor = false;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtUpdateKaiName
            // 
            this.txtUpdateKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateKaiName.Location = new System.Drawing.Point(165, 66);
            this.txtUpdateKaiName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateKaiName.Name = "txtUpdateKaiName";
            this.txtUpdateKaiName.Size = new System.Drawing.Size(300, 29);
            this.txtUpdateKaiName.TabIndex = 28;
            // 
            // lblEventUpdate
            // 
            this.lblEventUpdate.AutoSize = true;
            this.lblEventUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEventUpdate.Location = new System.Drawing.Point(102, 19);
            this.lblEventUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventUpdate.Name = "lblEventUpdate";
            this.lblEventUpdate.Size = new System.Drawing.Size(58, 24);
            this.lblEventUpdate.TabIndex = 28;
            this.lblEventUpdate.Text = "Event";
            // 
            // lblPreparationUpdate
            // 
            this.lblPreparationUpdate.AutoSize = true;
            this.lblPreparationUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparationUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreparationUpdate.Location = new System.Drawing.Point(43, 116);
            this.lblPreparationUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreparationUpdate.Name = "lblPreparationUpdate";
            this.lblPreparationUpdate.Size = new System.Drawing.Size(116, 24);
            this.lblPreparationUpdate.TabIndex = 28;
            this.lblPreparationUpdate.Text = "Preparation?";
            // 
            // lblServingQuantityUpdate
            // 
            this.lblServingQuantityUpdate.AutoSize = true;
            this.lblServingQuantityUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingQuantityUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblServingQuantityUpdate.Location = new System.Drawing.Point(13, 212);
            this.lblServingQuantityUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServingQuantityUpdate.Name = "lblServingQuantityUpdate";
            this.lblServingQuantityUpdate.Size = new System.Drawing.Size(147, 24);
            this.lblServingQuantityUpdate.TabIndex = 28;
            this.lblServingQuantityUpdate.Text = "Serving Quantity";
            // 
            // lblPreparationTimeUpdate
            // 
            this.lblPreparationTimeUpdate.AutoSize = true;
            this.lblPreparationTimeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparationTimeUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreparationTimeUpdate.Location = new System.Drawing.Point(5, 169);
            this.lblPreparationTimeUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreparationTimeUpdate.Name = "lblPreparationTimeUpdate";
            this.lblPreparationTimeUpdate.Size = new System.Drawing.Size(154, 24);
            this.lblPreparationTimeUpdate.TabIndex = 12;
            this.lblPreparationTimeUpdate.Text = "Preparation Time";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(40, 40);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(291, 276);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.label13);
            this.panelDelete.Controls.Add(this.txtPreperation);
            this.panelDelete.Controls.Add(this.txtServingQuantity);
            this.panelDelete.Controls.Add(this.txtPreperationTime);
            this.panelDelete.Controls.Add(this.lblPreparation);
            this.panelDelete.Controls.Add(this.lblPreparationTime);
            this.panelDelete.Controls.Add(this.label3);
            this.panelDelete.Controls.Add(this.lblKaiName);
            this.panelDelete.Controls.Add(this.lblEvent);
            this.panelDelete.Controls.Add(this.lblKaiID);
            this.panelDelete.Controls.Add(this.txtKaiName);
            this.panelDelete.Controls.Add(this.txtEvent);
            this.panelDelete.Controls.Add(this.txtKaiID);
            this.panelDelete.Location = new System.Drawing.Point(369, 40);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(494, 314);
            this.panelDelete.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(287, 210);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "minutes";
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.lbl);
            this.panelAdd.Controls.Add(this.btnAddSave);
            this.panelAdd.Controls.Add(this.lblKaiNameAdd);
            this.panelAdd.Controls.Add(this.btnAddCancel);
            this.panelAdd.Controls.Add(this.txtAddKaiName);
            this.panelAdd.Controls.Add(this.lblEventAdd);
            this.panelAdd.Controls.Add(this.lblPreparationAdd);
            this.panelAdd.Controls.Add(this.lblServingQuantityAdd);
            this.panelAdd.Controls.Add(this.lblPreparationTimeAdd);
            this.panelAdd.Controls.Add(this.numAddPreparationTime);
            this.panelAdd.Controls.Add(this.numAddServingQuantity);
            this.panelAdd.Controls.Add(this.cboxAddPreparation);
            this.panelAdd.Controls.Add(this.cboAddEvent);
            this.panelAdd.Location = new System.Drawing.Point(958, 40);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(507, 354);
            this.panelAdd.TabIndex = 31;
            this.panelAdd.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl.Location = new System.Drawing.Point(270, 172);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(76, 24);
            this.lbl.TabIndex = 30;
            this.lbl.Text = "minutes";
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAddSave.IconColor = System.Drawing.Color.Black;
            this.btnAddSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSave.IconSize = 36;
            this.btnAddSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddSave.Location = new System.Drawing.Point(117, 265);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(148, 39);
            this.btnAddSave.TabIndex = 29;
            this.btnAddSave.Text = "SAVE";
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // lblKaiNameAdd
            // 
            this.lblKaiNameAdd.AutoSize = true;
            this.lblKaiNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiNameAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKaiNameAdd.Location = new System.Drawing.Point(68, 69);
            this.lblKaiNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaiNameAdd.Name = "lblKaiNameAdd";
            this.lblKaiNameAdd.Size = new System.Drawing.Size(92, 24);
            this.lblKaiNameAdd.TabIndex = 28;
            this.lblKaiNameAdd.Text = "Kai Name";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnAddCancel.IconColor = System.Drawing.Color.Black;
            this.btnAddCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCancel.IconSize = 36;
            this.btnAddCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddCancel.Location = new System.Drawing.Point(317, 265);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(148, 39);
            this.btnAddCancel.TabIndex = 26;
            this.btnAddCancel.Text = "CANCEL";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // txtAddKaiName
            // 
            this.txtAddKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddKaiName.Location = new System.Drawing.Point(165, 66);
            this.txtAddKaiName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddKaiName.Name = "txtAddKaiName";
            this.txtAddKaiName.Size = new System.Drawing.Size(300, 29);
            this.txtAddKaiName.TabIndex = 28;
            // 
            // lblEventAdd
            // 
            this.lblEventAdd.AutoSize = true;
            this.lblEventAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEventAdd.Location = new System.Drawing.Point(102, 19);
            this.lblEventAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventAdd.Name = "lblEventAdd";
            this.lblEventAdd.Size = new System.Drawing.Size(58, 24);
            this.lblEventAdd.TabIndex = 28;
            this.lblEventAdd.Text = "Event";
            // 
            // lblPreparationAdd
            // 
            this.lblPreparationAdd.AutoSize = true;
            this.lblPreparationAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparationAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreparationAdd.Location = new System.Drawing.Point(43, 116);
            this.lblPreparationAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreparationAdd.Name = "lblPreparationAdd";
            this.lblPreparationAdd.Size = new System.Drawing.Size(117, 24);
            this.lblPreparationAdd.TabIndex = 28;
            this.lblPreparationAdd.Text = "Preperation?";
            // 
            // lblServingQuantityAdd
            // 
            this.lblServingQuantityAdd.AutoSize = true;
            this.lblServingQuantityAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingQuantityAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblServingQuantityAdd.Location = new System.Drawing.Point(13, 212);
            this.lblServingQuantityAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServingQuantityAdd.Name = "lblServingQuantityAdd";
            this.lblServingQuantityAdd.Size = new System.Drawing.Size(147, 24);
            this.lblServingQuantityAdd.TabIndex = 28;
            this.lblServingQuantityAdd.Text = "Serving Quantity";
            // 
            // lblPreparationTimeAdd
            // 
            this.lblPreparationTimeAdd.AutoSize = true;
            this.lblPreparationTimeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparationTimeAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreparationTimeAdd.Location = new System.Drawing.Point(5, 169);
            this.lblPreparationTimeAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreparationTimeAdd.Name = "lblPreparationTimeAdd";
            this.lblPreparationTimeAdd.Size = new System.Drawing.Size(154, 24);
            this.lblPreparationTimeAdd.TabIndex = 12;
            this.lblPreparationTimeAdd.Text = "Preparation Time";
            // 
            // numAddPreparationTime
            // 
            this.numAddPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddPreparationTime.Location = new System.Drawing.Point(165, 167);
            this.numAddPreparationTime.Name = "numAddPreparationTime";
            this.numAddPreparationTime.Size = new System.Drawing.Size(100, 29);
            this.numAddPreparationTime.TabIndex = 25;
            // 
            // numAddServingQuantity
            // 
            this.numAddServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddServingQuantity.Location = new System.Drawing.Point(165, 210);
            this.numAddServingQuantity.Name = "numAddServingQuantity";
            this.numAddServingQuantity.Size = new System.Drawing.Size(100, 29);
            this.numAddServingQuantity.TabIndex = 24;
            // 
            // cboxAddPreparation
            // 
            this.cboxAddPreparation.AutoSize = true;
            this.cboxAddPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboxAddPreparation.Location = new System.Drawing.Point(165, 122);
            this.cboxAddPreparation.Name = "cboxAddPreparation";
            this.cboxAddPreparation.Size = new System.Drawing.Size(15, 14);
            this.cboxAddPreparation.TabIndex = 23;
            this.cboxAddPreparation.UseVisualStyleBackColor = true;
            this.cboxAddPreparation.CheckedChanged += new System.EventHandler(this.cboxAddPreparation_CheckedChanged);
            // 
            // cboAddEvent
            // 
            this.cboAddEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAddEvent.FormattingEnabled = true;
            this.cboAddEvent.Location = new System.Drawing.Point(165, 16);
            this.cboAddEvent.Name = "cboAddEvent";
            this.cboAddEvent.Size = new System.Drawing.Size(300, 32);
            this.cboAddEvent.TabIndex = 22;
            // 
            // KaiMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1799, 561);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listBoxKai);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "KaiMaintenance";
            this.Text = "Kai Maintenance";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.KaiMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKaioordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateServingQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdatePreparationTime)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddPreparationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddServingQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKai;
        private System.Windows.Forms.TextBox txtKaiID;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtKaiName;
        private System.Windows.Forms.Label lblKaiID;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblKaiName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPreparationTime;
        private System.Windows.Forms.Label lblPreparation;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.TextBox txtPreperationTime;
        private System.Windows.Forms.TextBox txtServingQuantity;
        private System.Windows.Forms.TextBox txtPreperation;
        private System.Windows.Forms.ComboBox cboUpdateEvent;
        private System.Windows.Forms.CheckBox cboxUpdatePreparation;
        private System.Windows.Forms.NumericUpDown numUpdateServingQuantity;
        private System.Windows.Forms.NumericUpDown numUpdatePreparationTime;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label lblKaiNameUpdate;
        private System.Windows.Forms.TextBox txtUpdateKaiName;
        private System.Windows.Forms.Label lblEventUpdate;
        private System.Windows.Forms.Label lblPreparationUpdate;
        private System.Windows.Forms.Label lblServingQuantityUpdate;
        private System.Windows.Forms.Label lblPreparationTimeUpdate;
        private System.Windows.Forms.Label lblMinutesUpdate;
        private FontAwesome.Sharp.IconButton btnUpdateSave;
        private FontAwesome.Sharp.IconButton btnUpdateCancel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.BindingSource kAIBindingSource;
        private dsKaioordinate dsKaioordinate;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label lbl;
        private FontAwesome.Sharp.IconButton btnAddSave;
        private System.Windows.Forms.Label lblKaiNameAdd;
        private FontAwesome.Sharp.IconButton btnAddCancel;
        private System.Windows.Forms.TextBox txtAddKaiName;
        private System.Windows.Forms.Label lblEventAdd;
        private System.Windows.Forms.Label lblPreparationAdd;
        private System.Windows.Forms.Label lblServingQuantityAdd;
        private System.Windows.Forms.Label lblPreparationTimeAdd;
        private System.Windows.Forms.NumericUpDown numAddPreparationTime;
        private System.Windows.Forms.NumericUpDown numAddServingQuantity;
        private System.Windows.Forms.CheckBox cboxAddPreparation;
        private System.Windows.Forms.ComboBox cboAddEvent;
        private System.Windows.Forms.Label label13;
    }
}